using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КПЗ_ПР_2
{
    public class FarmFactory3 : IFarmFactory
    {
        public Animal CreateAnimal() => new Sheep();
        public Produce CreateProduce() => new Brynza();
        public Building CreateBuilding() => new Koshara();
    }
}