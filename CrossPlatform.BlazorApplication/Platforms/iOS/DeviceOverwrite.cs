using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatform.BlazorApplication;

public class DeviceOverwrite : Shared.RazorClassLibray.Device
{
    public Shared.RazorClassLibray.device.Type Type => Shared.RazorClassLibray.device.Type.iOS;


}
