using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КПЗ_П_2
{
    public partial class Form1 : Form
    {
        private FarmApplication app;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IFarmFactory factory = new PodillyaFarmFactory();
            app = new FarmApplication(factory);
            MessageBox.Show(app.RunFarmDay(), "Подільська ферма");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IFarmFactory factory = new PoltavaFarmFactory();
            app = new FarmApplication(factory);
            MessageBox.Show(app.RunFarmDay(), "Полтавська ферма");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IFarmFactory factory = new CarpathianFarmFactory();
            app = new FarmApplication(factory);
            MessageBox.Show(app.RunFarmDay(), "Карпатська ферма");
        }
    }

    public interface IAnimal
    {
        string GetSpecies();
        string DailyBehavior();
    }

    public interface IProduce
    {
        string GetItemName();
        int GetMarketValue();
    }

    public interface IBuilding
    {
        string GetBuildingType();
        int GetCapacity();
        string Accommodate(IAnimal animal);
    }

    public class PodillyaChicken : IAnimal
    {
        public string GetSpecies() => "Курка";
        public string DailyBehavior() => "Шукає зерно та п'є воду";
    }

    public class PodillyaEgg : IProduce
    {
        public string GetItemName() => "Яйця";
        public int GetMarketValue() => 30;
    }

    public class PodillyaCoop : IBuilding
    {
        public string GetBuildingType() => "Курник";
        public int GetCapacity() => 50;
        public string Accommodate(IAnimal animal) => $"Курник вміщує тварину: {animal.GetSpecies()}";
    }

    public class PoltavaCow : IAnimal
    {
        public string GetSpecies() => "Корова";
        public string DailyBehavior() => "Пасеться на траві біля води";
    }

    public class PoltavaMilk : IProduce
    {
        public string GetItemName() => "Молоко";
        public int GetMarketValue() => 85;
    }

    public class PoltavaBarn : IBuilding
    {
        public string GetBuildingType() => "Корівник";
        public int GetCapacity() => 80;
        public string Accommodate(IAnimal animal) => $"Корівник вміщує тварину: {animal.GetSpecies()}";
    }

    public class CarpathianSheep : IAnimal
    {
        public string GetSpecies() => "Вівця";
        public string DailyBehavior() => "Пасеться біля гірських схилів";
    }

    public class CarpathianBrynza : IProduce
    {
        public string GetItemName() => "Бринза";
        public int GetMarketValue() => 180;
    }

    public class CarpathianKoshara : IBuilding
    {
        public string GetBuildingType() => "Кошара";
        public int GetCapacity() => 120;
        public string Accommodate(IAnimal animal) => $"Кошара вміщує тварину: {animal.GetSpecies()}";
    }

    public interface IFarmFactory
    {
        IAnimal CreateAnimal();
        IProduce CreateProduce();
        IBuilding CreateBuilding();
    }

    public class PodillyaFarmFactory : IFarmFactory
    {
        public IAnimal CreateAnimal() => new PodillyaChicken();
        public IProduce CreateProduce() => new PodillyaEgg();
        public IBuilding CreateBuilding() => new PodillyaCoop();
    }

    public class PoltavaFarmFactory : IFarmFactory
    {
        public IAnimal CreateAnimal() => new PoltavaCow();
        public IProduce CreateProduce() => new PoltavaMilk();
        public IBuilding CreateBuilding() => new PoltavaBarn();
    }

    public class CarpathianFarmFactory : IFarmFactory
    {
        public IAnimal CreateAnimal() => new CarpathianSheep();
        public IProduce CreateProduce() => new CarpathianBrynza();
        public IBuilding CreateBuilding() => new CarpathianKoshara();
    }

    public class FarmApplication
    {
        private readonly IFarmFactory _factory;
        private IAnimal _animal;
        private IProduce _produce;
        private IBuilding _building;

        public FarmApplication(IFarmFactory factory)
        {
            _factory = factory;
            _animal = _factory.CreateAnimal();
            _produce = _factory.CreateProduce();
            _building = _factory.CreateBuilding();
        }

        public string RunFarmDay()
        {
            return $"• Тварина: {_animal.GetSpecies()}\n" +
                   $"  Дія: {_animal.DailyBehavior()}\n\n" +
                   $"• Продукція: {_produce.GetItemName()} ({_produce.GetMarketValue()} грн)\n\n" +
                   $"• Споруда: {_building.GetBuildingType()} (до {_building.GetCapacity()} місць)\n" +
                   $"  Розміщення: {_building.Accommodate(_animal)}";
        }
    }
}