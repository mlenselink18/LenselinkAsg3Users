using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LenselinkAsg3Users.Models
{
    public class User
    {
        public int ID { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string FullName
        {
            get
            {
                var display = NameFirst + " " + NameLast;
                return display;
            }
        }

        public string Slug => NameFirst.Replace(' ', '-') + NameLast.Replace(' ', '-');
    }
}
