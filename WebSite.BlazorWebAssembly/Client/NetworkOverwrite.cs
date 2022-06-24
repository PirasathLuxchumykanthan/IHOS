using Microsoft.JSInterop;
using Shared.RazorClassLibray.network;

namespace WebSite.BlazorWebAssembly.Client;
public class NetworkOverwrite : Shared.RazorClassLibray.Network, IDisposable
{
    private Status _Status = Status.Online;
    public Status Status {
        get => _Status;
        private set
        {
            if (value.Equals(Status.StartUp))
                return;
            if (value != _Status)
            {
                _Status = value;
                this._Handler?.Invoke();
            }

        }
    }

    private Action? _Handler;
    public event Action Handler {
        add => _Handler += value;
        remove => _Handler -= value;
    }
    private DotNetObjectReference<NetworkOverwrite>? ObjectReference { get; set; }
    private IJSObjectReference? JSObjectReference { get; set; }

    public NetworkOverwrite(IJSRuntime JSRuntime)
    {
        JSRuntime.InvokeAsync<IJSObjectReference>("import", $"/Network.js").AsTask().ContinueWith(a => {
            (JSObjectReference = a.Result).InvokeVoidAsync("JS", ObjectReference = DotNetObjectReference.Create(this));
        });
    }
    public void Dispose()
    {
        JSObjectReference?.DisposeAsync();
        ObjectReference?.Dispose();
    }
    [JSInvokable]
    public void Hardware(Status Status) => this.Status = Status;
}