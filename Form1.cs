using System;
using System.Windows.Forms;

namespace КПЗ_ПР_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Farm 1");
            comboBox1.Items.Add("Farm 2");
            comboBox1.Items.Add("Farm 3");
            comboBox1.SelectedIndex = 0;
        }

        IFarmFactory factory;
        Animal animal;
        Produce produce;
        Building building;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: factory = new FarmFactory1(); break;
                case 1: factory = new FarmFactory2(); break;
                case 2: factory = new FarmFactory3(); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                animal = factory.CreateAnimal();
                MessageBox.Show(animal.GetInfo());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                produce = factory.CreateProduce();
                MessageBox.Show(produce.GetInfo());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                building = factory.CreateBuilding();
                MessageBox.Show(building.GetInfo());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}