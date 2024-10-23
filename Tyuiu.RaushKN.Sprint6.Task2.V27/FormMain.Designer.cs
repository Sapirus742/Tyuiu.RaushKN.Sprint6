namespace Tyuiu.RaushKN.Sprint6.Task2.V27
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonResult_RKN = new Button();
            buttonHelp_RKN = new Button();
            groupBoxEnter_RKN = new GroupBox();
            textBoxStop_RKN = new TextBox();
            textBox_Stop_RKN = new TextBox();
            textBoxStart_RKN = new TextBox();
            textBox_Start_RKN = new TextBox();
            groupBoxTask_RKN = new GroupBox();
            pictureBoxFormula_RKN = new PictureBox();
            textBoxTask_RKN = new TextBox();
            groupBoxResult_RKN = new GroupBox();
            dataGridViewResult_RKN = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxEnter_RKN.SuspendLayout();
            groupBoxTask_RKN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_RKN).BeginInit();
            groupBoxResult_RKN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_RKN).BeginInit();
            SuspendLayout();
            // 
            // buttonResult_RKN
            // 
            buttonResult_RKN.BackColor = Color.Green;
            buttonResult_RKN.Location = new Point(407, 360);
            buttonResult_RKN.Name = "buttonResult_RKN";
            buttonResult_RKN.Size = new Size(164, 57);
            buttonResult_RKN.TabIndex = 8;
            buttonResult_RKN.Text = "Выполнить";
            buttonResult_RKN.UseVisualStyleBackColor = false;
            buttonResult_RKN.Click += bettonDone_Click;
            buttonResult_RKN.MouseDown += buttonResult_RKN_MouseDown;
            buttonResult_RKN.MouseEnter += buttonResult_RKN_MouseEnter;
            buttonResult_RKN.MouseLeave += buttonResult_RKN_MouseLeave;
            // 
            // buttonHelp_RKN
            // 
            buttonHelp_RKN.BackColor = Color.DodgerBlue;
            buttonHelp_RKN.Location = new Point(310, 361);
            buttonHelp_RKN.Name = "buttonHelp_RKN";
            buttonHelp_RKN.Size = new Size(91, 55);
            buttonHelp_RKN.TabIndex = 7;
            buttonHelp_RKN.Text = "Справка";
            buttonHelp_RKN.UseVisualStyleBackColor = false;
            buttonHelp_RKN.Click += buttonHelp_Click;
            // 
            // groupBoxEnter_RKN
            // 
            groupBoxEnter_RKN.Controls.Add(textBoxStop_RKN);
            groupBoxEnter_RKN.Controls.Add(textBox_Stop_RKN);
            groupBoxEnter_RKN.Controls.Add(textBoxStart_RKN);
            groupBoxEnter_RKN.Controls.Add(textBox_Start_RKN);
            groupBoxEnter_RKN.Location = new Point(12, 338);
            groupBoxEnter_RKN.Name = "groupBoxEnter_RKN";
            groupBoxEnter_RKN.Size = new Size(280, 91);
            groupBoxEnter_RKN.TabIndex = 6;
            groupBoxEnter_RKN.TabStop = false;
            groupBoxEnter_RKN.Text = "Ввод данных";
            // 
            // textBoxStop_RKN
            // 
            textBoxStop_RKN.BorderStyle = BorderStyle.None;
            textBoxStop_RKN.Location = new Point(162, 61);
            textBoxStop_RKN.Name = "textBoxStop_RKN";
            textBoxStop_RKN.Size = new Size(100, 16);
            textBoxStop_RKN.TabIndex = 3;
            // 
            // textBox_Stop_RKN
            // 
            textBox_Stop_RKN.BackColor = SystemColors.Control;
            textBox_Stop_RKN.BorderStyle = BorderStyle.None;
            textBox_Stop_RKN.Location = new Point(162, 39);
            textBox_Stop_RKN.Name = "textBox_Stop_RKN";
            textBox_Stop_RKN.ReadOnly = true;
            textBox_Stop_RKN.Size = new Size(100, 16);
            textBox_Stop_RKN.TabIndex = 2;
            textBox_Stop_RKN.Text = "Конец шага:";
            // 
            // textBoxStart_RKN
            // 
            textBoxStart_RKN.BorderStyle = BorderStyle.None;
            textBoxStart_RKN.Location = new Point(12, 61);
            textBoxStart_RKN.Name = "textBoxStart_RKN";
            textBoxStart_RKN.Size = new Size(100, 16);
            textBoxStart_RKN.TabIndex = 1;
            // 
            // textBox_Start_RKN
            // 
            textBox_Start_RKN.BackColor = SystemColors.Control;
            textBox_Start_RKN.BorderStyle = BorderStyle.None;
            textBox_Start_RKN.Location = new Point(12, 39);
            textBox_Start_RKN.Name = "textBox_Start_RKN";
            textBox_Start_RKN.ReadOnly = true;
            textBox_Start_RKN.Size = new Size(100, 16);
            textBox_Start_RKN.TabIndex = 0;
            textBox_Start_RKN.Text = "Старт шага:";
            // 
            // groupBoxTask_RKN
            // 
            groupBoxTask_RKN.Controls.Add(pictureBoxFormula_RKN);
            groupBoxTask_RKN.Controls.Add(textBoxTask_RKN);
            groupBoxTask_RKN.Location = new Point(12, 12);
            groupBoxTask_RKN.Name = "groupBoxTask_RKN";
            groupBoxTask_RKN.Size = new Size(555, 320);
            groupBoxTask_RKN.TabIndex = 5;
            groupBoxTask_RKN.TabStop = false;
            groupBoxTask_RKN.Text = "Условие";
            // 
            // pictureBoxFormula_RKN
            // 
            pictureBoxFormula_RKN.Location = new Point(449, 28);
            pictureBoxFormula_RKN.Name = "pictureBoxFormula_RKN";
            pictureBoxFormula_RKN.Size = new Size(86, 67);
            pictureBoxFormula_RKN.TabIndex = 1;
            pictureBoxFormula_RKN.TabStop = false;
            // 
            // textBoxTask_RKN
            // 
            textBoxTask_RKN.BackColor = SystemColors.Control;
            textBoxTask_RKN.BorderStyle = BorderStyle.None;
            textBoxTask_RKN.Location = new Point(12, 28);
            textBoxTask_RKN.Multiline = true;
            textBoxTask_RKN.Name = "textBoxTask_RKN";
            textBoxTask_RKN.ReadOnly = true;
            textBoxTask_RKN.Size = new Size(393, 37);
            textBoxTask_RKN.TabIndex = 0;
            textBoxTask_RKN.Text = "Протабулировать функцию на заданном диапазоне\r\nРезультат вывести в DataGridView и построить график функции\r\n\r\n\r\n";
            // 
            // groupBoxResult_RKN
            // 
            groupBoxResult_RKN.Controls.Add(dataGridViewResult_RKN);
            groupBoxResult_RKN.Location = new Point(583, 12);
            groupBoxResult_RKN.Name = "groupBoxResult_RKN";
            groupBoxResult_RKN.Size = new Size(657, 417);
            groupBoxResult_RKN.TabIndex = 9;
            groupBoxResult_RKN.TabStop = false;
            groupBoxResult_RKN.Text = "Вывод данных";
            // 
            // dataGridViewResult_RKN
            // 
            dataGridViewResult_RKN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_RKN.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult_RKN.Location = new Point(22, 28);
            dataGridViewResult_RKN.Name = "dataGridViewResult_RKN";
            dataGridViewResult_RKN.RowHeadersVisible = false;
            dataGridViewResult_RKN.Size = new Size(103, 375);
            dataGridViewResult_RKN.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(x)";
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 450);
            Controls.Add(groupBoxResult_RKN);
            Controls.Add(buttonResult_RKN);
            Controls.Add(buttonHelp_RKN);
            Controls.Add(groupBoxEnter_RKN);
            Controls.Add(groupBoxTask_RKN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 27 | Рауш К.Н.";
            groupBoxEnter_RKN.ResumeLayout(false);
            groupBoxEnter_RKN.PerformLayout();
            groupBoxTask_RKN.ResumeLayout(false);
            groupBoxTask_RKN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_RKN).EndInit();
            groupBoxResult_RKN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_RKN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonResult_RKN;
        private Button buttonHelp_RKN;
        private GroupBox groupBoxEnter_RKN;
        private TextBox textBoxStop_RKN;
        private TextBox textBox_Stop_RKN;
        private TextBox textBoxStart_RKN;
        private TextBox textBox_Start_RKN;
        private GroupBox groupBoxTask_RKN;
        private PictureBox pictureBoxFormula_RKN;
        private TextBox textBoxTask_RKN;
        private GroupBox groupBoxResult_RKN;
        private DataGridView dataGridViewResult_RKN;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
