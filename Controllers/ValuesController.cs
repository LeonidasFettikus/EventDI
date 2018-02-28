using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EventDI.Controllers
{
    [Route("conf/values")]
    public class ValuesController : Controller
    {
        private IWritableOptions<ClientSettings> _clients;

        public ValuesController(IWritableOptions<ClientSettings> clients)
        {
            _clients = clients;
        }

        [HttpPost]
        [Route("update")]
        public void UpdateClients([FromBody] ClientSettings updatedClients)
        {
            var clients = _clients.Value;
            _clients.Update(c => c = updatedClients);
        }
    }
}
