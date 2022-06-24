using Shared.RazorClassLibray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatform.BlazorApplication;

public class ConnectionOverwrite : Shared.RazorClassLibray.ConnectionOverwrite
{
    private string? _GetBlazorConnectionSecurityKey;
    public override string GetBlazorConnectionSecurityKey => _GetBlazorConnectionSecurityKey;

    private string? _GetBlazorID;
    public override string GetBlazorID => _GetBlazorID;
    public ConnectionOverwrite(Loader Loader, Definition Definition, Shared.RazorClassLibray.Network Network, Shared.RazorClassLibray.Device Device) : base(Loader, Definition, Network, Device)
    {
    //   _ = SecureStorage.GetAsync("Token").ContinueWith(a => {
    //       if (a.Result == null) {
    //           this.Done();
    //           return;
    //       }
    //       this._GetBlazorID = a.Result.Split(":")[0];
    //       this._GetBlazorID = a.Result.Split(":")[1];
    //       this.Done();
    //   });
    //
    }
}
