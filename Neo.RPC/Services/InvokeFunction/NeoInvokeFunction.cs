using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Neo.JsonRpc.Client;

namespace Neo.RPC.Services.InvokeFunction
{
    public class NeoInvokeFunction : RpcRequestResponseHandler<DTOs.InvokeFunction>
    {
        public NeoInvokeFunction(IClient client) : base(client, ApiMethods.invokefunction.ToString())
        {
        }

        public Task<DTOs.InvokeFunction> SendRequestAsync(string assetId, object id = null)
        {
            if (assetId == null) throw new ArgumentNullException(nameof(assetId));
            return base.SendRequestAsync(id, assetId);
        }

        public RpcRequest BuildRequest(string assetId, object id = null)
        {
            if (assetId == null) throw new ArgumentNullException(nameof(assetId));
            return base.BuildRequest(id, assetId);
        }
    }
}
