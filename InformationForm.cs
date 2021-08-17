using System;
using System.Windows.Forms;

namespace EulerianGraph
{
    /// <summary>
    /// Класс с формой хранящей информацию
    /// </summary>
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Задание стандартных значений для текстовых полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InformationForm_Load(object sender, EventArgs e)
        {
            ///Вывод имени файла
            NameTextBox.Text = "0";
            ///Вывод количества вершин
            NumDTextBox.Text = "0";
            ///Вывод количества ребер
            NumLTextBox.Text = "0";
            ///Вывод наличия эйлерова пути
            EureTextBox.Text = "False";
            ///Вывод эйлерова пути
            WayTextBox.Text = "0";
        }

        private void WayLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
