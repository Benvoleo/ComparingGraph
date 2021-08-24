using System;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ComparingGraph
{
    public partial class MainForm : Form
    {
        public ComparingGraph.Comparing.Graph graph1;
        public ComparingGraph.Comparing.Graph graph2;

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
        private void Input(ComparingGraph.Comparing.Graph graph, PictureBox picture, string name)
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
                    if (graph.NumberOfDots > 20)
                    {
                        graph.G.clearSheet();
                        graph.ClearAllData();
                        MessageBox.Show("Dots > 20", "Error");
                        
                        throw new Exception();

                    }
                    if (graph.NumberOfFacets > 50)
                    {
                        graph.G.clearSheet();
                        graph.ClearAllData();
                        MessageBox.Show("Facets > 50", "Error");
                        

                        throw new Exception("Facets > 50");

                    }


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
        private void Info(ComparingGraph.Comparing.Graph graph, string name)
        {
            InformationForm form = new InformationForm();
            form.Show();
            form.Text += name;
            if (graph.Name == null)
                form.NameTextBox.Text = "Keyboard input";
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
            Input(graph2, pictureBox2, " graph 2");
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
                MessageBox.Show("Euler graphs are equal!\n", "Result");
            else
                MessageBox.Show("The graphs are not equal", "Result");  
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }   
}
