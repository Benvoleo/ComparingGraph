
namespace EulerianGraph
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Check_button = new System.Windows.Forms.Button();
            this.SettingBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graph2checkBox = new System.Windows.Forms.CheckBox();
            this.graph1checkBox = new System.Windows.Forms.CheckBox();
            this.FromKeyboard_radioButton = new System.Windows.Forms.RadioButton();
            this.FromFile_radioButton = new System.Windows.Forms.RadioButton();
            this.SaveData_button = new System.Windows.Forms.Button();
            this.InfoG2_button = new System.Windows.Forms.Button();
            this.InputG2_button = new System.Windows.Forms.Button();
            this.CleanG2_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.InfoG1_button = new System.Windows.Forms.Button();
            this.CleanG1_button = new System.Windows.Forms.Button();
            this.InputG1_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SettingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Check_button
            // 
            this.Check_button.BackColor = System.Drawing.Color.Cornsilk;
            this.Check_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check_button.Location = new System.Drawing.Point(351, 523);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(124, 52);
            this.Check_button.TabIndex = 0;
            this.Check_button.Text = "Compare";
            this.Check_button.UseVisualStyleBackColor = false;
            this.Check_button.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // SettingBox
            // 
            this.SettingBox.BackColor = System.Drawing.Color.Cornsilk;
            this.SettingBox.Controls.Add(this.label1);
            this.SettingBox.Controls.Add(this.graph2checkBox);
            this.SettingBox.Controls.Add(this.graph1checkBox);
            this.SettingBox.Controls.Add(this.FromKeyboard_radioButton);
            this.SettingBox.Controls.Add(this.FromFile_radioButton);
            this.SettingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingBox.Location = new System.Drawing.Point(12, 522);
            this.SettingBox.Name = "SettingBox";
            this.SettingBox.Size = new System.Drawing.Size(333, 100);
            this.SettingBox.TabIndex = 13;
            this.SettingBox.TabStop = false;
            this.SettingBox.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(210, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Save graph";
            // 
            // graph2checkBox
            // 
            this.graph2checkBox.AutoSize = true;
            this.graph2checkBox.Location = new System.Drawing.Point(213, 61);
            this.graph2checkBox.Name = "graph2checkBox";
            this.graph2checkBox.Size = new System.Drawing.Size(86, 21);
            this.graph2checkBox.TabIndex = 5;
            this.graph2checkBox.Text = "Graph 2";
            this.graph2checkBox.UseVisualStyleBackColor = true;
            // 
            // graph1checkBox
            // 
            this.graph1checkBox.AutoSize = true;
            this.graph1checkBox.Location = new System.Drawing.Point(213, 40);
            this.graph1checkBox.Name = "graph1checkBox";
            this.graph1checkBox.Size = new System.Drawing.Size(86, 21);
            this.graph1checkBox.TabIndex = 4;
            this.graph1checkBox.Text = "Graph 1";
            this.graph1checkBox.UseVisualStyleBackColor = true;
            // 
            // FromKeyboard_radioButton
            // 
            this.FromKeyboard_radioButton.AutoSize = true;
            this.FromKeyboard_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromKeyboard_radioButton.Location = new System.Drawing.Point(25, 59);
            this.FromKeyboard_radioButton.Name = "FromKeyboard_radioButton";
            this.FromKeyboard_radioButton.Size = new System.Drawing.Size(152, 21);
            this.FromKeyboard_radioButton.TabIndex = 3;
            this.FromKeyboard_radioButton.Text = "Input from keyboard";
            this.FromKeyboard_radioButton.UseVisualStyleBackColor = true;
            // 
            // FromFile_radioButton
            // 
            this.FromFile_radioButton.AutoSize = true;
            this.FromFile_radioButton.Checked = true;
            this.FromFile_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromFile_radioButton.Location = new System.Drawing.Point(25, 32);
            this.FromFile_radioButton.Name = "FromFile_radioButton";
            this.FromFile_radioButton.Size = new System.Drawing.Size(111, 21);
            this.FromFile_radioButton.TabIndex = 2;
            this.FromFile_radioButton.TabStop = true;
            this.FromFile_radioButton.Text = "Input from file";
            this.FromFile_radioButton.UseVisualStyleBackColor = true;
            // 
            // SaveData_button
            // 
            this.SaveData_button.BackColor = System.Drawing.Color.Cornsilk;
            this.SaveData_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveData_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveData_button.Location = new System.Drawing.Point(351, 581);
            this.SaveData_button.Name = "SaveData_button";
            this.SaveData_button.Size = new System.Drawing.Size(124, 44);
            this.SaveData_button.TabIndex = 16;
            this.SaveData_button.Text = "Save all info";
            this.SaveData_button.UseVisualStyleBackColor = false;
            this.SaveData_button.Click += new System.EventHandler(this.SaveData_button_Click);
            // 
            // InfoG2_button
            // 
            this.InfoG2_button.BackColor = System.Drawing.Color.Cornsilk;
            this.InfoG2_button.Cursor = System.Windows.Forms.Cursors.Help;
            this.InfoG2_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfoG2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoG2_button.Location = new System.Drawing.Point(1076, 12);
            this.InfoG2_button.Name = "InfoG2_button";
            this.InfoG2_button.Size = new System.Drawing.Size(71, 35);
            this.InfoG2_button.TabIndex = 8;
            this.InfoG2_button.Text = "Info";
            this.InfoG2_button.UseVisualStyleBackColor = false;
            this.InfoG2_button.Click += new System.EventHandler(this.InfoG2_button_Click);
            // 
            // InputG2_button
            // 
            this.InputG2_button.BackColor = System.Drawing.Color.Cornsilk;
            this.InputG2_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputG2_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InputG2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputG2_button.Location = new System.Drawing.Point(649, 12);
            this.InputG2_button.Name = "InputG2_button";
            this.InputG2_button.Size = new System.Drawing.Size(146, 35);
            this.InputG2_button.TabIndex = 7;
            this.InputG2_button.Text = "Input graph";
            this.InputG2_button.UseVisualStyleBackColor = false;
            this.InputG2_button.Click += new System.EventHandler(this.InputG2_button_Click);
            // 
            // CleanG2_button
            // 
            this.CleanG2_button.BackColor = System.Drawing.Color.Cornsilk;
            this.CleanG2_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanG2_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CleanG2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanG2_button.Location = new System.Drawing.Point(1153, 13);
            this.CleanG2_button.Name = "CleanG2_button";
            this.CleanG2_button.Size = new System.Drawing.Size(75, 34);
            this.CleanG2_button.TabIndex = 6;
            this.CleanG2_button.Text = "Clear";
            this.CleanG2_button.UseVisualStyleBackColor = false;
            this.CleanG2_button.Click += new System.EventHandler(this.CleanG2_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 433);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 464);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph 1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(649, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 464);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graph 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(560, 433);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // InfoG1_button
            // 
            this.InfoG1_button.BackColor = System.Drawing.Color.Cornsilk;
            this.InfoG1_button.Cursor = System.Windows.Forms.Cursors.Help;
            this.InfoG1_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfoG1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoG1_button.Location = new System.Drawing.Point(439, 11);
            this.InfoG1_button.Name = "InfoG1_button";
            this.InfoG1_button.Size = new System.Drawing.Size(71, 35);
            this.InfoG1_button.TabIndex = 8;
            this.InfoG1_button.Text = "Info";
            this.InfoG1_button.UseVisualStyleBackColor = false;
            this.InfoG1_button.Click += new System.EventHandler(this.InfoG1_button_Click);
            // 
            // CleanG1_button
            // 
            this.CleanG1_button.BackColor = System.Drawing.Color.Cornsilk;
            this.CleanG1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanG1_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CleanG1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanG1_button.Location = new System.Drawing.Point(516, 11);
            this.CleanG1_button.Name = "CleanG1_button";
            this.CleanG1_button.Size = new System.Drawing.Size(75, 35);
            this.CleanG1_button.TabIndex = 6;
            this.CleanG1_button.Text = "Clear";
            this.CleanG1_button.UseVisualStyleBackColor = false;
            this.CleanG1_button.Click += new System.EventHandler(this.CleanG1_button_Click);
            // 
            // InputG1_button
            // 
            this.InputG1_button.BackColor = System.Drawing.Color.Cornsilk;
            this.InputG1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputG1_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InputG1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputG1_button.Location = new System.Drawing.Point(12, 12);
            this.InputG1_button.Name = "InputG1_button";
            this.InputG1_button.Size = new System.Drawing.Size(146, 34);
            this.InputG1_button.TabIndex = 7;
            this.InputG1_button.Text = "Input graph";
            this.InputG1_button.UseVisualStyleBackColor = false;
            this.InputG1_button.Click += new System.EventHandler(this.InputG1_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox3.Location = new System.Drawing.Point(597, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(46, 506);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1238, 629);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.InfoG2_button);
            this.Controls.Add(this.InputG1_button);
            this.Controls.Add(this.CleanG2_button);
            this.Controls.Add(this.InputG2_button);
            this.Controls.Add(this.InfoG1_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CleanG1_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveData_button);
            this.Controls.Add(this.SettingBox);
            this.Controls.Add(this.Check_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Visualize all graphs";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SettingBox.ResumeLayout(false);
            this.SettingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Check_button;
        private System.Windows.Forms.GroupBox SettingBox;
        private System.Windows.Forms.Button SaveData_button;
        private System.Windows.Forms.Button InfoG2_button;
        private System.Windows.Forms.Button CleanG2_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox graph2checkBox;
        private System.Windows.Forms.CheckBox graph1checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton FromKeyboard_radioButton;
        public System.Windows.Forms.RadioButton FromFile_radioButton;
        public System.Windows.Forms.Button InputG2_button;
        private System.Windows.Forms.Button InfoG1_button;
        private System.Windows.Forms.Button CleanG1_button;
        public System.Windows.Forms.Button InputG1_button;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

