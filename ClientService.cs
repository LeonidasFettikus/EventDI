using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EventDI
{
    public class ClientService : HostedService
    {
        private IWritableOptions<ClientSettings> _clients;

        public ClientService(IMemoryCache cacheService,
                                ILogger<ClientService> logger,
                                IWritableOptions<ClientSettings> clients)
        {
            _clients = clients;
            _clients.PropertyChanged += PropertyChanged;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(10, cancellationToken);
        }

        private void PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

        }
    }
}