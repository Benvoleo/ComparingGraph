using System;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace EulerianGraph
{
    public partial class MainForm : Form
    {
        public EulerianGraph.Comparing.Graph graph1;
        public EulerianGraph.Comparing.Graph graph2;

        /// <summary>
        /// main construct
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            graph1 = new Comparing.Graph();
            graph2 = new Comparing.Graph();

            graph1.G = new Comparing.DrawGraph(pictureBox1.Width, pictureBox1.Height, graph1);
            pictureBox1.Image = graph1.G.GetBitmap();

            graph2.G = new Comparing.DrawGraph(pictureBox2.Width, pictureBox2.Height, graph2);
            pictureBox2.Image = graph2.G.GetBitmap();

        }

        /// <summary>
        /// load graph
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="picture"></param>
        /// <param name="name"></param>
        private void Input(EulerianGraph.Comparing.Graph graph, PictureBox picture, string name)
        {
            picture.Hide();
            graph.ClearAllData();
            
            if (FromFile_radioButton.Checked)
            {
                if (graph.ReadFromFile())
                {
                    graph.EulerianOrNot();
                    picture.Show();
                    graph.G.clearSheet();
                    graph.Visualize();
                    if (graph.IsEulerian)
                    {
                        graph.G.clearSheet();
                        graph.DrawWay();
                    }
                }
            }
            else
            {
                KeyboardInputForm form = new KeyboardInputForm(graph);
                form.groupBox1.Text += name;
                form.ShowDialog();
                try
                {
                    graph.ConvertMFOtoMatrix();
                    graph.EulerianOrNot();
                    picture.Show();
                    graph.G.clearSheet();
                    graph.Visualize();
                    if (graph.IsEulerian)
                    {
                        graph.G.clearSheet();
                        graph.DrawWay();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong input", "Error");
                }
            }
        }

        /// <summary>
        /// info
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="name"></param>
        private void Info(EulerianGraph.Comparing.Graph graph, string name)
        {
            InformationForm form = new InformationForm();
            form.Show();
            form.Text += name;
            if (graph.Name == null)
                form.NameTextBox.Text = "Данные введены вручную или не введены";
            else
                form.NameTextBox.Text = graph.Name;

            form.NumDTextBox.Text = Convert.ToString(graph1.NumberOfDots);
            form.NumLTextBox.Text = Convert.ToString(graph1.NumberOfFacets);
            form.EureTextBox.Text = Convert.ToString(graph1.IsEulerian);

            int longestRoute = 0;
            int numRows = 0;

            foreach (int val in graph1.Matrix)
            {
                if (val == 0) {
                    numRows++;
                }
                if (val > 0) {
                    longestRoute++;
                }
            }

            form.LongRoute.Text = Convert.ToString(graph1.NumberOfFacets);

            if (graph.IsEulerian)
            {
                form.WayLabel.Visible = true;
                form.WayTextBox.Visible = true;
                string str = "";
                foreach (var item in graph.eulerianWay)
                {
                    str += Convert.ToString(item) + " ";
                }
                form.WayTextBox.Text = str;
            }
            else
            {
                form.WayLabel.Visible = false;
                form.WayTextBox.Visible = false;
                form.WayTextBox.Text = "";
            }
        }

        /// <summary>
        /// koad graph 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputG1_button_Click(object sender, EventArgs e)
        {
            Input(graph1, pictureBox1, " first graph 1");         
        }

        /// <summary>
        /// load grapgh 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputG2_button_Click(object sender, EventArgs e)
        {
            Input(graph2, pictureBox2, " для графа 2");
        }

        /// <summary>
        /// info graph 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoG1_button_Click(object sender, EventArgs e)
        {
            Info(graph1, " о Графе 1");
        }

        /// <summary>
        /// info graph 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoG2_button_Click(object sender, EventArgs e)
        {
            Info(graph2, " о Графе 2");
        }

        /// <summary>
        /// compare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_button_Click(object sender, EventArgs e)
        {
            if (graph1.IsEulerian && graph2.IsEulerian)
                MessageBox.Show("Оба графы эйлеровы, следовательно равны!\n","Результаты сравнения");
            else
                MessageBox.Show("Графы не равны", "Результаты сравнения");  
        }

        /// <summary>
        /// clear graph 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanG1_button_Click(object sender, EventArgs e)
        {
            graph1.ClearAllData();
            pictureBox1.Image = graph1.G.GetBitmap();
        }

        /// <summary>
        /// clear graph 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanG2_button_Click(object sender, EventArgs e)
        {
            graph2.ClearAllData();
            pictureBox2.Image = graph2.G.GetBitmap();
        }

        /// <summary>
        /// save data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveData_button_Click(object sender, EventArgs e)
        {
            if (graph1checkBox.Checked)
                graph1.SaveToFile("граф 1");
            
            if (graph2checkBox.Checked)
                graph2.SaveToFile("граф 2");
        }

        /// <summary>
        /// dafault
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {

            ToolTip tip = new ToolTip();
            tip.SetToolTip(InputG1_button, "Ввести информацию для графа 1");
            tip.SetToolTip(InputG2_button, "Ввести информацию для графа 2");
            tip.SetToolTip(CleanG1_button, "Очистить всю информацию о графе 1");
            tip.SetToolTip(CleanG2_button, "Очистить всю информацию о графе 2");
            tip.SetToolTip(InfoG1_button, "Получить подробную информацию о графе 1: кол-во вершин и ребер, название файла и информацию о эйлеровости графа");
            tip.SetToolTip(InfoG2_button, "Получить подробную информацию о графе 1: кол-во вершин и ребер, название файла и информацию о эйлеровости графа");
            tip.SetToolTip(Check_button, "Сравнить два графа на эйлеровость");
            tip.SetToolTip(SaveData_button, "Сохранить изображения выбранных графов");  
        }
    }   
}
