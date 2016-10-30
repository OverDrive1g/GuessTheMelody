using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessTheMelody.Core
{
    class Users
    {
        private static Users _instance;
        private List<User> _users;

        private Users()
        {
            _users = new List<User>();
        }

        public static Users Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Users();
                }
                return _instance;
            }
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User[] getUserByLevel(String level)
        {
            List<User> result = new List<User>();

            foreach (var item in _users)
            {
                if(item._level == level)
                {
                    result.Add(item);
                }
            }

            var res = from user in result
                      orderby user._score descending
                      select user;

            //foreach (User u in res)
            //{
            //    Console.WriteLine("{0} - {1} - {2}", u._name, u._level, u._score);
            //}

            return res.ToArray();
        }
    }
}
