using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КПЗ_ПР_2
{
    public class FarmFactory1 : IFarmFactory
    {
        public Animal CreateAnimal() => new Chicken();
        public Produce CreateProduce() => new Egg();
        public Building CreateBuilding() => new Coop();
    }
}