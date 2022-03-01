using System;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using LibElite.EDSM.Types;

namespace LibElite.EDSM
{
    public class EliteServerStatus
    {
        public DateTimeOffset LastUpdate { get; private set; }

        public string LastServerMessage { get; private set; }

        public async Task<ServerStatus> GetServerStatus()
        {
            EDSMEliteServerStatus status = await EDSM.BaseUrl
                .AppendPathSegments("api-status-v1", "elite-server")
                .GetJsonAsync<EDSMEliteServerStatus>();
            LastUpdate = status.LastUpdate;
            LastServerMessage = status.Message;
            return (ServerStatus) status.Status;
        }
    }
}
