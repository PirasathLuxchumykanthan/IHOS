using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RazorClassLibray
{
    public class Loader
    {
        private loader.Status _Status = loader.Status.StartUp;
        private Action? _Handler;
        public event Action Handler {
            add => _Handler += value;
            remove => _Handler -= value;
        }
        public loader.Status Status { 
            get => _Status;
            private set {
                if (_Status != value)
                {
                    _Status = value;
                    this._Handler?.Invoke();
                }
            }
        }
        private List<string> Names { get; } = new List<string>();
        private string GetName(Type type) => $"{type.Assembly}.{type.Namespace}.{type.Name}";
        public void Finnish(Type type) => this.Finnish(GetName(type));
        public void Finnish(Type type, string AddOnID) => this.Finnish($"{GetName(type)}[{AddOnID}]");
        public void Finnish(string Name)
        {
            if (!Names.Contains(Name))
                return;
            Names.Remove(Name);
            if (Names.Count == 0)
                Status = loader.Status.Finnish;
        }
        public void Loading(Type type,bool ForceStartUp=false) => this.Loading(GetName(type), ForceStartUp);
        public void Loading(Type type,string AddOnID, bool ForceStartUp = false) => this.Loading($"{GetName(type)}[{AddOnID}]", ForceStartUp);
        public void Loading(string Name, bool ForceStartUp = false)
        {
            if (Names.Contains(Name))
                return;
                Names.Add(Name);
            if (ForceStartUp)
                Status = loader.Status.StartUp;
            else if (Status.Equals(loader.Status.Finnish))
                Status = loader.Status.Loading;
        }
    }
}
