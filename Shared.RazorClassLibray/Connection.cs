using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RazorClassLibray;
public interface Connection
{
    public HubConnectionState State { get; }
    public HubConnection Hub { get; }
    public event Action Handler;
}
