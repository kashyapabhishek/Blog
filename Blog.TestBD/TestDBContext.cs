using Blog.Repository;
using Blog.CoreModel;
using System.Collections.Generic;

namespace Blog.TestBD
{
    public class TestDBContext : IConnectionDB
    {
        public IEnumerable<User> Users(){
            return new List<User>(){
                new User(){
                    ID = 1,
                    Username = "kashyap638",
                    Password = "Login@123",
                    Email = "Kashyap638@gmail.com"
                },
                new User(){
                    ID = 1,
                    Username = "abhishek638",
                    Password = "Login@123",
                    Email = "Abhishek638@gmail.com"
                },
                new User(){
                    ID = 1,
                    Username = "prakesh638",
                    Password = "Login@123",
                    Email = "Prakesh638@gmail.com"
                },
                new User(){
                    ID = 1,
                    Username = "rahul638",
                    Password = "Login@123",
                    Email = "Rahul638@gmail.com"
                },
                new User(){
                    ID = 1,
                    Username = "mohit638",
                    Password = "Login@123",
                    Email = "Mohit638@gmail.com"
                }
            };
        }
    }
}