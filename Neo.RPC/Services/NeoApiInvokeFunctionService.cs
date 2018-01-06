using System;
using System.Collections.Generic;
using System.Text;
using Neo.JsonRpc.Client;
using Neo.RPC.Services.Asset;
using Neo.RPC.Services.Contract;

namespace Neo.RPC.Services
{
    public class NeoApiInvokeFunctionService: RpcClientWrapper
    {
        public NeoApiInvokeFunctionService(IClient client) : base(client)
        {
            GetAssetState = new NeoInvokeFunction(client);
        }

        public NeoInvokeFunction InvokeFunction { get; private set; }
    }
}
