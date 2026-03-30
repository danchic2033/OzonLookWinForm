using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzonLookWinForm
{
    public class FitClothesData
    {
        public List<Product> TypeOfClothes { get; set; }

        public FitClothesData() 
        {
            TypeOfClothes = new List<Product>();
        }

    }
}
