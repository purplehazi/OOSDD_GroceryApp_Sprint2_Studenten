
namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public string EmailAddress { get; set; } // added property
        public string Password { get; set; }
        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            EmailAddress=emailAddress;
            Password=password;
        }
    }
}
