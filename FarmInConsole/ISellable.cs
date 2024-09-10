using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInConsole
{
    public interface ISellable
    {
        double SellPrice { get; }
        string Name { get; }
        void Sell();
    }
}
