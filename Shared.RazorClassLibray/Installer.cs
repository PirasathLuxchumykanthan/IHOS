using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RazorClassLibray
{
    public class Installer
    {
        private installer.Status _Status = installer.Status.Wait;
        private Action? _Handler;
        public event Action Handler {
            add => _Handler += value;
            remove => _Handler -= value;
        }
        public installer.Status Status {
            get => this._Status;
            private set {
                if (value == installer.Status.Wait || _Status==installer.Status.Done)
                    return;
                _Status = value;
                this._Handler?.Invoke();
            }
        }
        public virtual void Done() => Status = installer.Status.Done;
    }
}
