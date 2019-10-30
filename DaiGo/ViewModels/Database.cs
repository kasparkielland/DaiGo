using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DaiGo.Models;
using SQLite;

namespace DaiGo.ViewModels
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UserRequest>().Wait();
            _database.CreateTableAsync<UserProfile>().Wait();
            _database.CreateTableAsync<AgentProfile>().Wait();
            _database.CreateTableAsync<AgentQuote>().Wait();

        }

        public Task<List<UserProfile>> GetUserProfileAsync()
        {
            return _database.Table<UserProfile>().ToListAsync();
        }
        
        public Task<List<UserProfile>> FindUserProfileAsync(string username, string password)
        {
           var userProfile = _database.Table<UserProfile>().Where(user => user.UserName == username).Where
                (pass => pass.Password == password);

            return userProfile.ToListAsync();
                   
        }
         public Task<List<UserReqeust>> Name_Request_Async(string username)
        {
           // UserRequest Table do not have a field of "UserName", only have a field of "UserID"
           // This task try to use "username" to find "user request" in UserRequest Table
            
           var name_id_table = _database.Table<UserProfile>().Where(user => user.UserName == username);
           var id = username_userid_table.UserID;
           var name_request_table = _database.Table<UserRequest>().Where(request => request.UserID == id); 
           
           return name_request_table.ToListAsync();
                   
        }



        public Task<int> SaveUserProfileAsync(UserProfile user)
        {
            return _database.InsertAsync(user);
        }

        public Task<List<AgentProfile>> GetAgentProfileAsync()
        {
            return _database.Table<AgentProfile>().ToListAsync();
        }

        public Task<int> SaveAgentProfileAsync(AgentProfile agent)
        {
            return _database.InsertAsync(agent);
        }

        public Task<List<UserRequest>> GetUserRequestAsync()
        {
            return _database.Table<UserRequest>().ToListAsync();
        }

        public Task<int> SaveUserRequestAsync(UserRequest request)
        {
            return _database.InsertAsync(request);
        }

        public Task<List<AgentQuote>> GetAgentQuoteAsync()
        {
            return _database.Table<AgentQuote>().ToListAsync();
        }

        public Task<int> SaveAgentQuoteAsync(AgentQuote quote)
        {
            return _database.InsertAsync(quote);
        }
    }
}