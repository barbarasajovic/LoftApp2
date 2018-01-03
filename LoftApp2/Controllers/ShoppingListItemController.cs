using LoftApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoftApp2.Controllers
{
    public class ShoppingListItemController : ApiController
    {


        [HttpGet]
        public IEnumerable<ShoppingListItem> GetItemsByShoppingListId(int id)
        {
            List<ShoppingListItem> s_list = new List<ShoppingListItem>();


            return s_list;
        }

        [HttpPost]
        public int Save(ShoppingListItem sli)
        {
            sli.Persist();

            return sli.Id;

            //return Ok(sli.Id);
        }

        [HttpPost]
        public void Delete(int id)
        {

        }


    }
}
