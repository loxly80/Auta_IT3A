using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auta_IT3A
{
    public partial class Form1 : Form
    {
        private List<Car> trucks;
        private Car truck;

        public Form1()
        {
            InitializeComponent();
            numLoadStuff.Maximum = int.MaxValue;
            numUnloadStuff.Maximum = int.MaxValue;
            numMaxWeight.Maximum = int.MaxValue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trucks = new List<Car>();
            if(truck == null)
            {
                groupBox1.Enabled = false;
            }
        }

        private void ShowCar(Car car)
        {
            lblMarque.Text = car.Marque;
            lblMaxWeight.Text = $"{car.MaxWeight} kg";
            lblLoaded.Text = $"{car.Loaded} kg";
        }

        private void btnLoad1000_Click(object sender, EventArgs e)
        {
            var loaded = truck.Load(1000);
            MessageBox.Show($"Naloženo {loaded} kg");
            ShowCar(truck);
        }

        private void btnLoad2000_Click(object sender, EventArgs e)
        {
            var loaded = truck.Load(2000);
            MessageBox.Show($"Naloženo {loaded} kg");
            ShowCar(truck);
        }

        private void btnLoad3000_Click(object sender, EventArgs e)
        {
            var loaded = truck.Load(3000);
            MessageBox.Show($"Naloženo {loaded} kg");
            ShowCar(truck);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var loaded = truck.Load(Convert.ToInt32(numLoadStuff.Value));
            MessageBox.Show($"Naloženo {loaded} kg");
            ShowCar(truck);
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            var loaded = truck.Unload(Convert.ToInt32(numUnloadStuff.Value));
            MessageBox.Show($"Vyloženo {loaded} kg");
            ShowCar(truck);
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            var loaded = truck.Park();
            MessageBox.Show($"Vyloženo {loaded} kg");
            ShowCar(truck);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            txtMargue.Text = "";
            numMaxWeight.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            trucks.Add(new Car(txtMargue.Text, Convert.ToInt32(numMaxWeight.Value)));
            groupBox2.Visible = false;
            ShowTrucks();
        }

        private void ShowTrucks()
        {
            listBox1.Items.Clear();
            foreach(var t in trucks)
            {
                listBox1.Items.Add($"{t.Marque} ({t.MaxWeight}kg)");
            }
        }

        private void txtMargue_TextChanged(object sender, EventArgs e)
        {
            btnCreateCar.Enabled = txtMargue.Text.Trim().Length > 0 && numMaxWeight.Value > 0;
        }

        private void numMaxWeight_ValueChanged(object sender, EventArgs e)
        {
            btnCreateCar.Enabled = txtMargue.Text.Trim().Length > 0 && numMaxWeight.Value > 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            truck = trucks[listBox1.SelectedIndex];
            ShowCar(truck);
            groupBox1.Enabled = true;
        }
    }
}
