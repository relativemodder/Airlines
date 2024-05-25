using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.Models;

namespace Airlines.Services
{
    public class Session
    {
        private static Session? _instance;
        private User? _user;

        public static Session GetSession()
        {
            if (_instance == null)
            {
                _instance = new Session();
            }

            return _instance;
        }

        public User? GetUser()
        {
            return _user;
        }

        public void SetUser(User? user)
        {
            _user = user;
        }
    }
}
