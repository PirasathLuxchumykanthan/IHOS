using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RazorClassLibray;
public interface Network
{
    public event Action Handler;
    public network.Status Status { get; }
}
