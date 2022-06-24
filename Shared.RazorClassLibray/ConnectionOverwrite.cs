using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
namespace Shared.RazorClassLibray
{
    public class ConnectionOverwrite:Installer,Connection,IDisposable
    {
        private HubConnection? _Hub;
        public HubConnection Hub => _Hub ??= new HubConnectionBuilder().WithUrl($"{Definition.Host}/ApplicationServices", x => {
            x.Headers.Add("DeviceType", ((int)this.Device.Type).ToString());
            x.Headers.Add("DefinitionTwoLetterISO639", Definition.TwoLetterISO639);
            var BlazorConnectionID = GetBlazorID;
            var BlazorConnectionSecurityKey = GetBlazorConnectionSecurityKey;
            if (BlazorConnectionID is not null && BlazorConnectionSecurityKey is not null) {
                x.Headers.Add("BlazorConnectionID", BlazorConnectionID);
                x.Headers.Add("BlazorConnectionSecurityKey", BlazorConnectionID);
            }
            //x.Headers.Add("BlazorTimeZone",)

        }).WithAutomaticReconnect().Build();
        private Action? _Handler;
        public event Action Handler {
            add => _Handler += value;
            remove => _Handler -= value;
        }
        
        private HubConnectionState _State = HubConnectionState.Disconnected;
        public HubConnectionState State {
            get => _State;
            private set {
                if (_State != value) 
                    if ((_State = value) == HubConnectionState.Connected)
                        this._Handler?.Invoke(); 
      
            }
        }
        public virtual string? GetBlazorID { get; }
        public virtual string? GetBlazorConnectionSecurityKey { get; }
        private readonly Definition Definition;
        private readonly Network Network;
        private readonly Device Device;
        private readonly Loader Loader; 
        public ConnectionOverwrite(Loader Loader,Definition Definition,Network Network,Device Device)
        {

            this.Device = Device;
            (this.Loader = Loader).Loading(this.GetType(), true);
            this.Definition = Definition;
            this.Network = Network;
            this.Handler += () => {
                //this.Network.Handler += Connect;
                //this.Hub.Closed += Hub_restart;
                //this.Hub.Reconnecting += Hub_restart;
                //this.Hub.Reconnected += Hub_restart;
                //this.Hub.On<Shared.DataClass.blazor.Connection>("*.Blazor.Connection", BC => { 



                //});
                // Connect();
            };
        }
        private async Task Hub_restart(string? arg) => Connect();
        private async Task Hub_restart(Exception? arg) => Connect();
        private void Connect()
        {
            if ((this.State=this.Hub.State) == HubConnectionState.Connected)
            {
                this.Loader.Finnish(this.GetType());
                return;
            }
            if (this.Network.Status.Equals(Shared.RazorClassLibray.network.Status.Online)&& this.Hub.State == HubConnectionState.Disconnected) {
                this.Loader.Loading(this.GetType(), true);
                try
                {
                    Hub.StartAsync().ContinueWith(a => {
                        if (a.IsCompleted && this.Hub.State == HubConnectionState.Connected) {
                            this.State = HubConnectionState.Connected;
                            this.Loader.Finnish(this.GetType());
                        }
                    });
                }
                catch (Exception)
                {

                }
            }
        }

        public void Dispose()
        {
           Hub?.DisposeAsync();
        }
    }
}
