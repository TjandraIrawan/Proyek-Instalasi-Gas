using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class LoginModel
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public int Hitung { get; set; }
        public LoginModel(string UserID, string Password)
        {
            this.UserID = UserID;
            this.Password = Password;
        }
    }
}
