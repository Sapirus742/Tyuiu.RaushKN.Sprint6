namespace Tyuiu.RaushKN.Sprint6.Task0.V12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_RKN = new GroupBox();
            textBoxTask_RKN = new TextBox();
            pictureBoxFormula_RKN = new PictureBox();
            groupBoxEnter_RKN = new GroupBox();
            textBoxVarX_RKN = new TextBox();
            textBoxVar_X_RKN = new TextBox();
            groupBoxResult_RKN = new GroupBox();
            textBox_Result_RKN = new TextBox();
            textBoxResult_RKN = new TextBox();
            buttonResult_RKN = new Button();
            buttonHelp_RKN = new Button();
            groupBoxTask_RKN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_RKN).BeginInit();
            groupBoxEnter_RKN.SuspendLayout();
            groupBoxResult_RKN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_RKN
            // 
            groupBoxTask_RKN.Controls.Add(textBoxTask_RKN);
            groupBoxTask_RKN.Location = new Point(24, 25);
            groupBoxTask_RKN.Name = "groupBoxTask_RKN";
            groupBoxTask_RKN.Size = new Size(341, 213);
            groupBoxTask_RKN.TabIndex = 0;
            groupBoxTask_RKN.TabStop = false;
            groupBoxTask_RKN.Text = "Условие";
            // 
            // textBoxTask_RKN
            // 
            textBoxTask_RKN.BackColor = SystemColors.Control;
            textBoxTask_RKN.BorderStyle = BorderStyle.None;
            textBoxTask_RKN.Location = new Point(10, 23);
            textBoxTask_RKN.Multiline = true;
            textBoxTask_RKN.Name = "textBoxTask_RKN";
            textBoxTask_RKN.ReadOnly = true;
            textBoxTask_RKN.Size = new Size(222, 30);
            textBoxTask_RKN.TabIndex = 0;
            textBoxTask_RKN.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_RKN
            // 
            pictureBoxFormula_RKN.Image = (Image)resources.GetObject("pictureBoxFormula_RKN.Image");
            pictureBoxFormula_RKN.Location = new Point(398, 57);
            pictureBoxFormula_RKN.Name = "pictureBoxFormula_RKN";
            pictureBoxFormula_RKN.Size = new Size(135, 66);
            pictureBoxFormula_RKN.TabIndex = 1;
            pictureBoxFormula_RKN.TabStop = false;
            // 
            // groupBoxEnter_RKN
            // 
            groupBoxEnter_RKN.Controls.Add(textBoxVarX_RKN);
            groupBoxEnter_RKN.Controls.Add(textBoxVar_X_RKN);
            groupBoxEnter_RKN.Location = new Point(24, 248);
            groupBoxEnter_RKN.Name = "groupBoxEnter_RKN";
            groupBoxEnter_RKN.Size = new Size(341, 109);
            groupBoxEnter_RKN.TabIndex = 2;
            groupBoxEnter_RKN.TabStop = false;
            groupBoxEnter_RKN.Text = "Ввод данных";
            // 
            // textBoxVarX_RKN
            // 
            textBoxVarX_RKN.BackColor = SystemColors.Window;
            textBoxVarX_RKN.BorderStyle = BorderStyle.None;
            textBoxVarX_RKN.Location = new Point(22, 56);
            textBoxVarX_RKN.Name = "textBoxVarX_RKN";
            textBoxVarX_RKN.Size = new Size(100, 16);
            textBoxVarX_RKN.TabIndex = 1;
            textBoxVarX_RKN.KeyPress += textBoxVarX_KeyPress;
            // 
            // textBoxVar_X_RKN
            // 
            textBoxVar_X_RKN.BackColor = SystemColors.Control;
            textBoxVar_X_RKN.BorderStyle = BorderStyle.None;
            textBoxVar_X_RKN.Location = new Point(22, 34);
            textBoxVar_X_RKN.Name = "textBoxVar_X_RKN";
            textBoxVar_X_RKN.Size = new Size(100, 16);
            textBoxVar_X_RKN.TabIndex = 0;
            textBoxVar_X_RKN.Text = "Переменная X";
            // 
            // groupBoxResult_RKN
            // 
            groupBoxResult_RKN.Controls.Add(textBox_Result_RKN);
            groupBoxResult_RKN.Controls.Add(textBoxResult_RKN);
            groupBoxResult_RKN.Location = new Point(371, 248);
            groupBoxResult_RKN.Name = "groupBoxResult_RKN";
            groupBoxResult_RKN.Size = new Size(163, 109);
            groupBoxResult_RKN.TabIndex = 3;
            groupBoxResult_RKN.TabStop = false;
            groupBoxResult_RKN.Text = "Вывод данных";
            // 
            // textBox_Result_RKN
            // 
            textBox_Result_RKN.BackColor = SystemColors.Control;
            textBox_Result_RKN.BorderStyle = BorderStyle.None;
            textBox_Result_RKN.Location = new Point(12, 34);
            textBox_Result_RKN.Name = "textBox_Result_RKN";
            textBox_Result_RKN.ReadOnly = true;
            textBox_Result_RKN.Size = new Size(100, 16);
            textBox_Result_RKN.TabIndex = 1;
            textBox_Result_RKN.Text = "Результат:";
            // 
            // textBoxResult_RKN
            // 
            textBoxResult_RKN.BackColor = SystemColors.Window;
            textBoxResult_RKN.BorderStyle = BorderStyle.None;
            textBoxResult_RKN.Location = new Point(12, 56);
            textBoxResult_RKN.Name = "textBoxResult_RKN";
            textBoxResult_RKN.ReadOnly = true;
            textBoxResult_RKN.Size = new Size(100, 16);
            textBoxResult_RKN.TabIndex = 0;
            textBoxResult_RKN.TextChanged += buttonDone_Click;
            // 
            // buttonResult_RKN
            // 
            buttonResult_RKN.Location = new Point(417, 363);
            buttonResult_RKN.Name = "buttonResult_RKN";
            buttonResult_RKN.Size = new Size(116, 27);
            buttonResult_RKN.TabIndex = 4;
            buttonResult_RKN.Text = "Выполнить";
            buttonResult_RKN.UseVisualStyleBackColor = true;
            buttonResult_RKN.Click += buttonDone_Click;
            // 
            // buttonHelp_RKN
            // 
            buttonHelp_RKN.Location = new Point(381, 365);
            buttonHelp_RKN.Name = "buttonHelp_RKN";
            buttonHelp_RKN.Size = new Size(30, 23);
            buttonHelp_RKN.TabIndex = 5;
            buttonHelp_RKN.Text = "?";
            buttonHelp_RKN.UseVisualStyleBackColor = true;
            buttonHelp_RKN.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(573, 399);
            Controls.Add(buttonHelp_RKN);
            Controls.Add(buttonResult_RKN);
            Controls.Add(groupBoxResult_RKN);
            Controls.Add(groupBoxEnter_RKN);
            Controls.Add(pictureBoxFormula_RKN);
            Controls.Add(groupBoxTask_RKN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 12 | Рауш К.Н.";
            groupBoxTask_RKN.ResumeLayout(false);
            groupBoxTask_RKN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_RKN).EndInit();
            groupBoxEnter_RKN.ResumeLayout(false);
            groupBoxEnter_RKN.PerformLayout();
            groupBoxResult_RKN.ResumeLayout(false);
            groupBoxResult_RKN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_RKN;
        private PictureBox pictureBoxFormula_RKN;
        private GroupBox groupBoxEnter_RKN;
        private GroupBox groupBoxResult_RKN;
        private Button buttonResult_RKN;
        private Button buttonHelp_RKN;
        private TextBox textBoxResult_RKN;
        private TextBox textBoxTask_RKN;
        private TextBox textBox_Result_RKN;
        private TextBox textBoxVarX_RKN;
        private TextBox textBoxVar_X_RKN;
    }
}
