using ScottPlot;
using System;
using TimeCostMeter;
namespace Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            formsPlot1.Dock = DockStyle.Fill; // <--- Добавить эту строку
            //CreateScatterPlot();
            CreateScatterPlot();
        }
        private void CreateScatterPlot()
        {
            var col = TimeCostMeter.Program.ReturnCollection();
            double[] ArraySizeX = col.Select(el => Convert.ToDouble(el.SetLength)).ToArray();
            //double[] TimeSpanY = col.Select(el => Convert.ToDouble(el.TimeSpan)).ToArray();
            double[] Iterations = col.Select(el => Convert.ToDouble(el.IterationsCount)).ToArray();
            var scatterPlot = this.formsPlot1.Plot.Add.Scatter(ArraySizeX, Iterations);

            formsPlot1.Plot.XLabel("Размер массива");
            formsPlot1.Plot.YLabel("Время выполнения");
            formsPlot1.Plot.Title("Диаграмма Рассеяния");
            scatterPlot.LineStyle.Width = 0;
            formsPlot1.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
