using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QiwiRestMoq.Model
{
    public class Provider
    {
        public string ProviderCode { get; set; }
        public string Name { get; set; }
        public bool Payable { get; set; }
        public bool Form { get; set; }
        public List<string> Parents { get; set; }
        public List<Provider> Children { get; set; }
    }
}
