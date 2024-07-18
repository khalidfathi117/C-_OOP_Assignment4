using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9.Question_2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        enum Role
        {
            Admin,
            User
        }
        private string[] Usernames { get; set; }
        private string[] Passwords { get; set; }
        private Role[] Roles { get; set; }
        public BasicAuthenticationService()
        {
            Usernames = new string[]
            {
                "Khalid",
                "Youssef",
                "Mohammed",
                "Fathi",
            };
            Passwords = new string[]
            {
                "khalid123",
                "youssef123",
                "mohammed123",
                "fathi123",
            };
            Roles = new Role[]
            {
                Role.Admin,
                Role.User,
                Role.User,
                Role.User,
            };
        }
        public bool AuthenticateUser(string username, string password)
        {
            for (int i = 0; i < Usernames.Length; i++)
            {
                if (username == Usernames[i])
                {
                    if (password == Passwords[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < Usernames.Length; i++)
            {
                if (username == Usernames[i])
                {
                    if (role.ToLower() == Roles[i].ToString().ToLower())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
