using LoftApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoftApp2.Controllers
{
    public class UserController : ApiController
    {

        [HttpGet]
        public IEnumerable<User> GetUsersByShoppingListId(int id)
        {
            List<User> s_list = new List<User>();


            return s_list;
        }

        [HttpGet]
        public IEnumerable<User> GetUser(int id)
        {
            List<User> s_list = new List<User>();


            return s_list;
        }

        [HttpPost]
        public int Save(User user)
        {
            user.Persist();

            return user.Id;

            //return Ok(sli.Id);
        }

    }
}
