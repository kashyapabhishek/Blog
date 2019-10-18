using System;
using Blog.CoreModel;
using System.Collections.Generic;
using Blog.Repository;
using System.Linq;

namespace Blog.InMemoryDataStore
{
    public class UserInMemory : IUser
    {
        private readonly IConnectionDB _ConnectionDB;

        public UserInMemory(IConnectionDB ConnectionDB)
        {
            _ConnectionDB = ConnectionDB;
        }

        public User GetUser(int id){
            // for now use inmemory data
            try
            {
               return this._ConnectionDB.Users().FirstOrDefault(a=> a.ID == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public IEnumerable<User> GetUsers(){
            try
            {
                return this._ConnectionDB.Users();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
