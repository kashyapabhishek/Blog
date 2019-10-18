using Blog.CoreModel;
using System.Collections.Generic;

namespace Blog.Repository
{
    public interface IUser
    {
        User GetUser(int id);
        IEnumerable<User> GetUsers();
    }
}