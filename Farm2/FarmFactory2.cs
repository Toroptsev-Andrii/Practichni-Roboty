using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КПЗ_ПР_2
{
    public class FarmFactory2 : IFarmFactory
    {
        public Animal CreateAnimal() => new Cow();
        public Produce CreateProduce() => new Milk();
        public Building CreateBuilding() => new Barn();
    }
}