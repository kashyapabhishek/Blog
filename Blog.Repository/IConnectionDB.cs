using Blog.CoreModel;
using System.Collections.Generic;

namespace Blog.Repository
{
    public interface IConnectionDB
    {
         IEnumerable<User> Users();
    }
}