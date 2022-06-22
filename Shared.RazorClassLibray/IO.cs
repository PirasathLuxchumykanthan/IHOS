using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Shared.RazorClassLibray;
public interface IO
{
    public bool Have(Guid ID,Guid Key);
    public byte[] Get(Guid ID, Guid Key);
    public void Save(byte[] Bytes,Guid ID, Guid Key, DateTime Expires);
    public void Delete(Guid ID, Guid Key);
}
