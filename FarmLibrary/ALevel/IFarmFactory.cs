using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КПЗ_ПР_2
{
    public interface IFarmFactory
    {
        Animal CreateAnimal();
        Produce CreateProduce();
        Building CreateBuilding();
    }
}