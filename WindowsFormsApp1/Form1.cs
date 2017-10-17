using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> result = doStuff();

            label1.Text = "Nu kör vi!";
            label2.Text = "Snart...";

            await result;

            label1.Text = "Klart!";
            label2.Text = "Klart!";
        }

        private async Task<int> doStuff()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(3000);
                return 1;
            });
        }
    }
}
