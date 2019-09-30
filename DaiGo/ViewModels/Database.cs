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