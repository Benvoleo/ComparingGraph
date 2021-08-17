
namespace EulerianGraph
{
    partial class InformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WayTextBox = new System.Windows.Forms.TextBox();
            this.EureTextBox = new System.Windows.Forms.TextBox();
            this.NumLTextBox = new System.Windows.Forms.TextBox();
            this.NumDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.WayLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LongRoute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.LongRoute);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.WayTextBox);
            this.groupBox1.Controls.Add(this.EureTextBox);
            this.groupBox1.Controls.Add(this.NumLTextBox);
            this.groupBox1.Controls.Add(this.NumDTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.WayLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // WayTextBox
            // 
            this.WayTextBox.Location = new System.Drawing.Point(11, 220);
            this.WayTextBox.Multiline = true;
            this.WayTextBox.Name = "WayTextBox";
            this.WayTextBox.ReadOnly = true;
            this.WayTextBox.Size = new System.Drawing.Size(336, 27);
            this.WayTextBox.TabIndex = 9;
            // 
            // EureTextBox
            // 
            this.EureTextBox.Location = new System.Drawing.Point(11, 176);
            this.EureTextBox.Multiline = true;
            this.EureTextBox.Name = "EureTextBox";
            this.EureTextBox.ReadOnly = true;
            this.EureTextBox.Size = new System.Drawing.Size(336, 27);
            this.EureTextBox.TabIndex = 8;
            // 
            // NumLTextBox
            // 
            this.NumLTextBox.Location = new System.Drawing.Point(11, 134);
            this.NumLTextBox.Multiline = true;
            this.NumLTextBox.Name = "NumLTextBox";
            this.NumLTextBox.ReadOnly = true;
            this.NumLTextBox.Size = new System.Drawing.Size(336, 27);
            this.NumLTextBox.TabIndex = 7;
            // 
            // NumDTextBox
            // 
            this.NumDTextBox.Location = new System.Drawing.Point(11, 85);
            this.NumDTextBox.Multiline = true;
            this.NumDTextBox.Name = "NumDTextBox";
            this.NumDTextBox.ReadOnly = true;
            this.NumDTextBox.Size = new System.Drawing.Size(336, 27);
            this.NumDTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(11, 37);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(336, 27);
            this.NameTextBox.TabIndex = 5;
            // 
            // WayLabel
            // 
            this.WayLabel.AutoSize = true;
            this.WayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayLabel.Location = new System.Drawing.Point(8, 202);
            this.WayLabel.Name = "WayLabel";
            this.WayLabel.Size = new System.Drawing.Size(77, 15);
            this.WayLabel.TabIndex = 4;
            this.WayLabel.Text = "Eulerian way";
            this.WayLabel.Click += new System.EventHandler(this.WayLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "isEulerian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name of file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of rims";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of peaks ";
            // 
            // LongRoute
            // 
            this.LongRoute.Location = new System.Drawing.Point(11, 268);
            this.LongRoute.Multiline = true;
            this.LongRoute.Name = "LongRoute";
            this.LongRoute.ReadOnly = true;
            this.LongRoute.Size = new System.Drawing.Size(336, 27);
            this.LongRoute.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Longest route";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(383, 330);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformationForm";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.InformationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox NumDTextBox;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.Label WayLabel;
        public System.Windows.Forms.TextBox WayTextBox;
        public System.Windows.Forms.TextBox EureTextBox;
        public System.Windows.Forms.TextBox NumLTextBox;
        public System.Windows.Forms.TextBox LongRoute;
        public System.Windows.Forms.Label label5;
    }
}