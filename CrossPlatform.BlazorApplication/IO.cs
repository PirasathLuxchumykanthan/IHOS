using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatform.BlazorApplication;
public class IO : Shared.RazorClassLibray.IO
{
    public void Delete(Guid ID, Guid Key)
    {
        throw new NotImplementedException();
    }

    public byte[] Get(Guid ID, Guid Key)
    {
        throw new NotImplementedException();
    }

    public bool Have(Guid ID, Guid Key)
    {
        throw new NotImplementedException();
    }
    public void Save(byte[] Bytes, Guid ID, Guid Key, DateTime Expires)
    {
        throw new NotImplementedException();
    }
}
