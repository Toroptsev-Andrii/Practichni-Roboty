using System;

namespace КПЗ_ПР_2
{
    //
    public abstract class Animal
    {
        public string Species { get; set; }
        public abstract string GetInfo();
    }

    public abstract class Produce
    {
        public string ItemName { get; set; }
        public string Price { get; set; }
        public abstract string GetInfo();
    }

    public abstract class Building
    {
        public string BuildingType { get; set; }
        public string CapacityInfo { get; set; }
        public abstract string GetInfo();
    }

    //
    public abstract class AbstractFarmFactory
    {
        public abstract Animal CreateAnimal();
        public abstract Produce CreateProduce();
        public abstract Building CreateBuilding();
    }

    //
    public class PodillyaChicken : Animal
    {
        public PodillyaChicken()
        {
            Species = "Подільська курка";
        }

        public override string GetInfo() =>
            $"Вид: {Species}. Гуляє на подвір'ї, несеться щоранку.";
    }

    public class PodillyaEgg : Produce
    {
        public PodillyaEgg()
        {
            ItemName = "Домашні яйця";
            Price = "65 грн/дес.";
        }

        public override string GetInfo() =>
            $"Продукція: {ItemName}, роздрібна ціна: {Price}.";
    }

    public class PodillyaCoop : Building
    {
        public PodillyaCoop()
        {
            BuildingType = "Каркасний курник";
            CapacityInfo = "до 30 голів птиці";
        }

        public override string GetInfo() =>
            $"Споруда: {BuildingType}, розрахунок на {CapacityInfo}.";
    }

    public class PodillyaFarmFactory : AbstractFarmFactory
    {
        public override Animal CreateAnimal() => new PodillyaChicken();
        public override Produce CreateProduce() => new PodillyaEgg();
        public override Building CreateBuilding() => new PodillyaCoop();
    }

    //
    public class PoltavaCow : Animal
    {
        public PoltavaCow()
        {
            Species = "Молочна корова";
        }

        public override string GetInfo() =>
            $"Вид: {Species}. Пасеться на лузі біля річки";
    }

    public class PoltavaMilk : Produce
    {
        public PoltavaMilk()
        {
            ItemName = "Незбиране молоко";
            Price = "35 грн/л";
        }

        public override string GetInfo() =>
            $"Продукція: {ItemName}, ціна: {Price}.";
    }

    public class PoltavaBarn : Building
    {
        public PoltavaBarn()
        {
            BuildingType = "Цегляний корівник зі стійлами";
            CapacityInfo = "12 корів";
        }

        public override string GetInfo() =>
            $"Споруда: {BuildingType}, місткість: {CapacityInfo}.";
    }

    public class PoltavaFarmFactory : AbstractFarmFactory
    {
        public override Animal CreateAnimal() => new PoltavaCow();
        public override Produce CreateProduce() => new PoltavaMilk();
        public override Building CreateBuilding() => new PoltavaBarn();
    }

    //
    public class CarpathianSheep : Animal
    {
        public CarpathianSheep()
        {
            Species = "Карпатська гірська вівця";
        }

        public override string GetInfo() =>
            $"Вид: {Species}. Випасається на високогірних полонинах у супроводі чабана.";
    }

    public class CarpathianBrynza : Produce
    {
        public CarpathianBrynza()
        {
            ItemName = "Овеча сичужна бринза";
            Price = "170 грн/кг";
        }

        public override string GetInfo() =>
            $"Продукція: {ItemName}, ціна: {Price}.";
    }

    public class CarpathianKoshara : Building
    {
        public CarpathianKoshara()
        {
            BuildingType = "Дерев'яна полонинська кошара";
            CapacityInfo = "отара до 120 голів";
        }

        public override string GetInfo() =>
            $"Споруда: {BuildingType}, вміщує: {CapacityInfo}.";
    }

    public class CarpathianFarmFactory : AbstractFarmFactory
    {
        public override Animal CreateAnimal() => new CarpathianSheep();
        public override Produce CreateProduce() => new CarpathianBrynza();
        public override Building CreateBuilding() => new CarpathianKoshara();
    }
}