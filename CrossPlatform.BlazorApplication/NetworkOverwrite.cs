using Shared.RazorClassLibray.network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatform.BlazorApplication;
public class NetworkOverwrite : Shared.RazorClassLibray.Network
{
    private Status _Status = Status.StartUp;
    public Status Status { 
        get => _Status;
        private set {
            if (value.Equals(Status.StartUp))
                return;
            if (value != _Status) {
                _Status = value;
                this._Handler?.Invoke();
            }
              
        }
    }
    private Action? _Handler;
    public event Action Handler
    {
        add => _Handler += value;
        remove => _Handler -= value;
    }
    public NetworkOverwrite() {
        this.Hardware();
        Connectivity.ConnectivityChanged += (s, e) => Hardware();
    }
    private void Hardware() => this.Status = Microsoft.Maui.Networking.Connectivity.Current.NetworkAccess == NetworkAccess.Internet ? Status.Online : Status.Offline;
}
