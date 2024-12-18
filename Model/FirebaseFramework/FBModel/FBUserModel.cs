using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAuthMVVM.Model.FirebaseFramework.FBModel
{
    public class FBUserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //public string Phone { get; set; }
        public int Points { get; set; }
        public int Rank { get; set; }
        public string Usertype { get; set; }
        public int Uid { get; set; }
    }
}
