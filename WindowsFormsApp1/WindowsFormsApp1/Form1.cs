using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double x;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Start";
            timer1.Tick += timer1_Tick;
            timer1.Interval = 50;

            chart1.Series[0].ChartType = SeriesChartType.Line;
        }
        private void timer1_Tick(object sender , EventArgs e)
        {
            chart1.Series[0].Points.AddXY(x,3* Math.Sin(5*x)+5*MATH)
        }
    }
}
