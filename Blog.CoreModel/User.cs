

namespace Blog.CoreModel
{
    public class User
    {
        public int ID { get; set; } 
        public string Username { get; set; }  
        public string Password { get; set; }    
        public string ConfirmPassword { get; set; } 
        public string Model { get; set; }
    }
}