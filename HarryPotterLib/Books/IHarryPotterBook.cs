using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Books
{
    public interface IHarryPotterBook
    {
        decimal price { get; }
        int count { get; set; }
    }
}
