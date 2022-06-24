using System;
using System.Collections.Generic;

namespace Shared.EntityFramework
{
    public partial class Blazor
    {
        public Guid Id { get; set; }
        public Guid SecurityKey { get; set; }
        public DateTime Expires { get; set; }
        public int DeviceType { get; set; }
        public DateTime Created { get; set; }
        public string TwoLetterIso639 { get; set; } = null!;
        public int StockStatus { get; set; }
    }
}
