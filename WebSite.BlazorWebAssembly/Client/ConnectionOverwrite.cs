using Shared.RazorClassLibray;

namespace WebSite.BlazorWebAssembly.Client;

public class ConnectionOverwrite : Shared.RazorClassLibray.ConnectionOverwrite
{
    public override string GetBlazorConnectionSecurityKey => base.GetBlazorConnectionSecurityKey;
    public override string GetBlazorID => base.GetBlazorID;
    public ConnectionOverwrite(Loader Loader, Definition Definition, Network Network, Shared.RazorClassLibray.Device Device) : base(Loader, Definition, Network, Device)
    {
    }
}
