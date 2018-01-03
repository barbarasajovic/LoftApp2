using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoftApp2.Models
{
    public class ShoppingListItem
    {


        public int Id { get; set; }

        public int Id_ShoppingList { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int AddedBy { get; set; }

        public int BoughtBy { get; set; }




        internal int Persist()
        {
            if (this.Id == 0)
            {

            }
            else
            {

            }

            return this.Id;
        }



    }
}