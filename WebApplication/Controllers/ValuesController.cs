using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{

    public class ValuesController : ApiController
      {
        private string[] lista
        {
            get
            {
                if (System.Web.HttpContext.Current.Application[< em > "lista" </ em >] == null)
                {
                    System.Web.HttpContext.Current.Application[< em > "lista" </ em >] =
                        new string[] { < em > "value1" </ em >, < em > "value2" </ em > };
                }
                return
                    (string[])System.Web.HttpContext.Current.Application[< em > "lista" </ em >];
            }
        /// <summary>
        /// Retrieves the list of values
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return lista;
        }
        /// <summary>
        /// Retrieves one value from the list of values
        /// </summary>
        /// <param name=<em>"id"</em>>The id of the item to be retrieved</param>
        /// <returns></returns>
        public string Get(int id)
        {
            return lista[id];
        }
        /// <summary>
        /// Insert a new value in the list
        /// </summary>
        /// <param name=<em>"value"</em>>New value to be inserted</param>
        public void Post([FromBody]string value)
        {
        }
        /// <summary>
        /// Change a single value in the list
        /// </summary>
        /// <param name=<em>"id"</em>>The id of the value to be changed</param>
        /// <param name=<em>"value"</em>>The new value</param>
        public void Put(int id, [FromBody]string value)
        {
            lista[id] = value;
        }
        /// <summary>
        /// Delete an item from the list
        /// </summary>
        /// <param name=<em>"id"</em>>id of the item to be deleted</param>
        public void Delete(int id)
        {
        }
    }
}
