using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ComparingGraph
{
    public partial class KeyboardInputForm : Form
    {
        public KeyboardInputForm()
        {
            InitializeComponent();
        }

        public KeyboardInputForm(Comparing.Graph eurelian)
        {
            InitializeComponent();
            current = eurelian;
        }

        /// <summary>
        /// MFO array
        /// </summary>
        public int[] Array { get; set; }        

        /// <summary>
        /// Current graph
        /// </summary>
        public Comparing.Graph current;
       
        /// <summary>
        /// Enter from keyboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Check_button_Click(object sender, EventArgs e)
        {
            MassivTextBox.BackColor = Color.White;

            string AllText = MassivTextBox.Text;
      
            List<string> tmp = new List<string>();
            string[] ArrayWithData = new string[120];

            List<int> OutputArray = new List<int>();

            try
            {
                ArrayWithData = AllText.Split(' ');

                Array = new int[ArrayWithData.Length];
                for (int i = 0; i < ArrayWithData.Length; i++)
                {
                    OutputArray.Add(Convert.ToInt32(ArrayWithData[i]));
                }
               
                MassivTextBox.BackColor = Color.Green;

                current.MFO = OutputArray;
                
            }

            catch (Exception)
            {
                MassivTextBox.BackColor = Color.Red;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void KeyboardInputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
