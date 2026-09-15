using System;
using System.Windows.Forms;

namespace КПЗ_ПР_2
{
    public partial class Form1 : Form
    {
        private AbstractFarmFactory factory;
        private Animal animal;
        private Produce produce;
        private Building building;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Подільська фабрика");
            comboBox1.Items.Add("Полтавська фабрика");
            comboBox1.Items.Add("Карпатська фабрика");
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    factory = new PodillyaFarmFactory();
                    break;
                case 1:
                    factory = new PoltavaFarmFactory();
                    break;
                case 2:
                    factory = new CarpathianFarmFactory();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                animal = factory.CreateAnimal();
                MessageBox.Show(animal.GetInfo(), "Тварина");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                produce = factory.CreateProduce();
                MessageBox.Show(produce.GetInfo(), "Продукція");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                building = factory.CreateBuilding();
                MessageBox.Show(building.GetInfo(), "Будівля");
            }
        }
    }
}