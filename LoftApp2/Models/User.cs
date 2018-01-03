using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoftApp2.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Surname { get; set; }

        public int Phonenumber { get; set; }

        public string Mail { get; set; }

        internal void Persist()
        {
            throw new NotImplementedException();
        }
    }
}