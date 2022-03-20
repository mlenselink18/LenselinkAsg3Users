using System.Collections.Generic;

namespace LenselinkAsg3Users.Models
{
    public class DB
    {
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>
            {
                new User
                {
                    ID = 1,
                    NameFirst = "John",
                    NameLast = "Smith",
                    Email = "jsmit@email.com"
                },
                new User
                {
                    ID = 2,
                    NameFirst = "Neo",
                    NameLast = "Anderson",
                    Email = "theone@hotmail.com"
                },
                new User
                {
                    ID = 3,
                    NameFirst = "Bart",
                    NameLast = "Simpson",
                    Email = "eatmyshorts@nunya.biz"
                },
                new User
                {
                    ID = 4,
                    NameFirst = "Homer",
                    NameLast = "Simpson",
                    Email = "hsimpson@springfieldpower.com"
                },
                new User
                {
                    ID = 5,
                    NameFirst = "Mary",
                    NameLast = "Delamater",
                    Email = "mdel@murach.com"
                },
                new User
                {
                    ID = 6,
                    NameFirst = "Zak",
                    NameLast = "Revalcaba",
                    Email = "zrav@murach.com"
                },
                new User
                {
                    ID = 7,
                    NameFirst = "Mark",
                    NameLast = "Zuckerburg",
                    Email = "mark@facemash.com"
                },
                new User
                {
                    ID = 8,
                    NameFirst = "Bill",
                    NameLast = "Gates",
                    Email = "william@microsoft.com"
                },
                new User
                {
                    ID = 9,
                    NameFirst = "Mike",
                    NameLast = "Wazowski",
                    Email = "mwazowski@monsters.org"
                },
                new User
                {
                    ID = 10,
                    NameFirst = "Forrest",
                    NameLast = "Gump",
                    Email = "fgump@bubbagump.com"
                }
            };
            return users;
        }

        public static List<User> GestUsersByLastName(string input)
        {
            List<User> users = DB.GetUsers();
            List<User> results = new List<User>();
            foreach (User u in users)
            {
                if (u.NameLast.ToLower().Contains(input.ToLower()))
                {
                    results.Add(u);
                }
            }
            return results;
        }

        public static User GetUserByID(int id)
        {
            List<User> users = DB.GetUsers();
            foreach (User u in users)
            {
                if (u.ID == id)
                {
                    return u;
                }
            }
            return null;
        }
    }
}
