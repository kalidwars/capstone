using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SWIM.Models;

namespace SWIM.Services
{
    public class DatabaseService
    {
        static SQLiteAsyncConnection database;

        public DatabaseService(string dbPath)
        {

            Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            Stream embeddedDatabaseStream = assembly.GetManifestResourceStream("SWIM.data.db");

            
            if (!File.Exists(dbPath))
            {

                FileStream fileStreamToWrite = File.Create(dbPath);
                embeddedDatabaseStream.Seek(0, SeekOrigin.Begin);
                embeddedDatabaseStream.CopyTo(fileStreamToWrite);
                fileStreamToWrite.Close();
            }
            
            database = new SQLiteAsyncConnection(dbPath, false);
            database.CreateTablesAsync<User, Bill, Usage, Transaction, Enquiry>().Wait();
            database.CreateTableAsync<Fault>().Wait();
            
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await database.Table<User>().ToListAsync();
        }
        
        
        public List<Usage> GetUsageAsync()
        {
            var result = database.Table<Usage>().ToListAsync().Result;
            return result;
        }                     

        public List<Bill> GetBillAsync()
        {
            var result = database.Table<Bill>().ToListAsync().Result;
            return result;
        }

        public List<Fault> GetFaultAsync()
        {
            var result = database.Table<Fault>().ToListAsync().Result;
            return result;
        }

        public Task<int> InsertFaultAsync(Fault fault)
        {
            return database.InsertAsync(fault);
        }
    }
}
