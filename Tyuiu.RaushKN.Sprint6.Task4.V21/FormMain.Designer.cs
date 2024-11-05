namespace Tyuiu.RaushKN.Sprint6.Task4.V21
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
            groupBoxResult_RKN = new GroupBox();
            textBoxResult_RKN = new TextBox();
            formsPlotChartResult_RKN = new ScottPlot.WinForms.FormsPlot();
            buttonResult_RKN = new Button();
            buttonHelp_RKN = new Button();
            groupBoxEnter_RKN = new GroupBox();
            textBoxStop_RKN = new TextBox();
            textBox_Stop_RKN = new TextBox();
            textBoxStart_RKN = new TextBox();
            textBox_Start_RKN = new TextBox();
            groupBoxTask_RKN = new GroupBox();
            textBoxTask_RKN = new TextBox();
            buttonSave_RKN = new Button();
            groupBoxResult_RKN.SuspendLayout();
            groupBoxEnter_RKN.SuspendLayout();
            groupBoxTask_RKN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxResult_RKN
            // 
            groupBoxResult_RKN.Controls.Add(textBoxResult_RKN);
            groupBoxResult_RKN.Controls.Add(formsPlotChartResult_RKN);
            groupBoxResult_RKN.Location = new Point(12, 81);
            groupBoxResult_RKN.Name = "groupBoxResult_RKN";
            groupBoxResult_RKN.Size = new Size(1163, 494);
            groupBoxResult_RKN.TabIndex = 14;
            groupBoxResult_RKN.TabStop = false;
            groupBoxResult_RKN.Text = "Вывод данных";
            // 
            // textBoxResult_RKN
            // 
            textBoxResult_RKN.BackColor = SystemColors.Window;
            textBoxResult_RKN.Location = new Point(6, 22);
            textBoxResult_RKN.Multiline = true;
            textBoxResult_RKN.Name = "textBoxResult_RKN";
            textBoxResult_RKN.ReadOnly = true;
            textBoxResult_RKN.Size = new Size(303, 451);
            textBoxResult_RKN.TabIndex = 2;
            // 
            // formsPlotChartResult_RKN
            // 
            formsPlotChartResult_RKN.DisplayScale = 1F;
            formsPlotChartResult_RKN.Location = new Point(315, 61);
            formsPlotChartResult_RKN.Name = "formsPlotChartResult_RKN";
            formsPlotChartResult_RKN.Size = new Size(842, 412);
            formsPlotChartResult_RKN.TabIndex = 1;
            // 
            // buttonResult_RKN
            // 
            buttonResult_RKN.BackColor = Color.Green;
            buttonResult_RKN.Location = new Point(859, 20);
            buttonResult_RKN.Name = "buttonResult_RKN";
            buttonResult_RKN.Size = new Size(117, 57);
            buttonResult_RKN.TabIndex = 13;
            buttonResult_RKN.Text = "Выполнить";
            buttonResult_RKN.UseVisualStyleBackColor = false;
            buttonResult_RKN.Click += bettonDone_Click;
            buttonResult_RKN.MouseEnter += buttonResult_RKN_MouseEnter;
            buttonResult_RKN.MouseLeave += buttonResult_RKN_MouseLeave;
            // 
            // buttonHelp_RKN
            // 
            buttonHelp_RKN.BackColor = Color.DodgerBlue;
            buttonHelp_RKN.Location = new Point(1084, 20);
            buttonHelp_RKN.Name = "buttonHelp_RKN";
            buttonHelp_RKN.Size = new Size(91, 55);
            buttonHelp_RKN.TabIndex = 12;
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
            groupBoxEnter_RKN.Location = new Point(573, 12);
            groupBoxEnter_RKN.Name = "groupBoxEnter_RKN";
            groupBoxEnter_RKN.Size = new Size(280, 72);
            groupBoxEnter_RKN.TabIndex = 11;
            groupBoxEnter_RKN.TabStop = false;
            groupBoxEnter_RKN.Text = "Ввод данных";
            // 
            // textBoxStop_RKN
            // 
            textBoxStop_RKN.BorderStyle = BorderStyle.None;
            textBoxStop_RKN.Location = new Point(123, 38);
            textBoxStop_RKN.Name = "textBoxStop_RKN";
            textBoxStop_RKN.Size = new Size(100, 16);
            textBoxStop_RKN.TabIndex = 3;
            // 
            // textBox_Stop_RKN
            // 
            textBox_Stop_RKN.BackColor = SystemColors.Control;
            textBox_Stop_RKN.BorderStyle = BorderStyle.None;
            textBox_Stop_RKN.Location = new Point(123, 16);
            textBox_Stop_RKN.Name = "textBox_Stop_RKN";
            textBox_Stop_RKN.ReadOnly = true;
            textBox_Stop_RKN.Size = new Size(100, 16);
            textBox_Stop_RKN.TabIndex = 2;
            textBox_Stop_RKN.Text = "Конец шага:";
            // 
            // textBoxStart_RKN
            // 
            textBoxStart_RKN.BorderStyle = BorderStyle.None;
            textBoxStart_RKN.Location = new Point(6, 38);
            textBoxStart_RKN.Name = "textBoxStart_RKN";
            textBoxStart_RKN.Size = new Size(100, 16);
            textBoxStart_RKN.TabIndex = 1;
            // 
            // textBox_Start_RKN
            // 
            textBox_Start_RKN.BackColor = SystemColors.Control;
            textBox_Start_RKN.BorderStyle = BorderStyle.None;
            textBox_Start_RKN.Location = new Point(6, 16);
            textBox_Start_RKN.Name = "textBox_Start_RKN";
            textBox_Start_RKN.ReadOnly = true;
            textBox_Start_RKN.Size = new Size(100, 16);
            textBox_Start_RKN.TabIndex = 0;
            textBox_Start_RKN.Text = "Старт шага:";
            // 
            // groupBoxTask_RKN
            // 
            groupBoxTask_RKN.Controls.Add(textBoxTask_RKN);
            groupBoxTask_RKN.Location = new Point(12, 12);
            groupBoxTask_RKN.Name = "groupBoxTask_RKN";
            groupBoxTask_RKN.Size = new Size(555, 72);
            groupBoxTask_RKN.TabIndex = 10;
            groupBoxTask_RKN.TabStop = false;
            groupBoxTask_RKN.Text = "Условие";
            // 
            // textBoxTask_RKN
            // 
            textBoxTask_RKN.BackColor = SystemColors.Control;
            textBoxTask_RKN.BorderStyle = BorderStyle.None;
            textBoxTask_RKN.Location = new Point(6, 16);
            textBoxTask_RKN.Multiline = true;
            textBoxTask_RKN.Name = "textBoxTask_RKN";
            textBoxTask_RKN.ReadOnly = true;
            textBoxTask_RKN.Size = new Size(393, 44);
            textBoxTask_RKN.TabIndex = 0;
            textBoxTask_RKN.Text = "Протабулировать функцию на заданном диапазоне\r\nРезультат вывести в textBox и построить график функции\r\nСохранить в OutPutFileTask3V21.txt по нажатию кнопки\r\n\r\n";
            // 
            // buttonSave_RKN
            // 
            buttonSave_RKN.BackColor = Color.LightSeaGreen;
            buttonSave_RKN.Location = new Point(982, 19);
            buttonSave_RKN.Name = "buttonSave_RKN";
            buttonSave_RKN.Size = new Size(96, 56);
            buttonSave_RKN.TabIndex = 15;
            buttonSave_RKN.Text = "Сохранить";
            buttonSave_RKN.UseVisualStyleBackColor = false;
            buttonSave_RKN.Click += buttonSave_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 587);
            Controls.Add(buttonSave_RKN);
            Controls.Add(buttonResult_RKN);
            Controls.Add(buttonHelp_RKN);
            Controls.Add(groupBoxEnter_RKN);
            Controls.Add(groupBoxTask_RKN);
            Controls.Add(groupBoxResult_RKN);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 21 | Рауш К.Н.";
            groupBoxResult_RKN.ResumeLayout(false);
            groupBoxResult_RKN.PerformLayout();
            groupBoxEnter_RKN.ResumeLayout(false);
            groupBoxEnter_RKN.PerformLayout();
            groupBoxTask_RKN.ResumeLayout(false);
            groupBoxTask_RKN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxResult_RKN;
        private Button buttonResult_RKN;
        private Button buttonHelp_RKN;
        private GroupBox groupBoxEnter_RKN;
        private TextBox textBoxStop_RKN;
        private TextBox textBox_Stop_RKN;
        private TextBox textBoxStart_RKN;
        private TextBox textBox_Start_RKN;
        private GroupBox groupBoxTask_RKN;
        private TextBox textBoxTask_RKN;
        private ScottPlot.WinForms.FormsPlot formsPlotChartResult_RKN;
        private TextBox textBoxResult_RKN;
        private Button buttonSave_RKN;
    }
}
