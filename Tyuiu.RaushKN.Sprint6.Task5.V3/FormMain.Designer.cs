namespace Tyuiu.RaushKN.Sprint6.Task5.V3
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
            buttonSave_RKN = new Button();
            buttonResult_RKN = new Button();
            buttonHelp_RKN = new Button();
            groupBoxTask_RKN = new GroupBox();
            textBoxTask_RKN = new TextBox();
            groupBoxResult_RKN = new GroupBox();
            dataGridViewResult_RKN = new DataGridView();
            formsPlotChartResult_RKN = new ScottPlot.WinForms.FormsPlot();
            groupBoxTask_RKN.SuspendLayout();
            groupBoxResult_RKN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_RKN).BeginInit();
            SuspendLayout();
            // 
            // buttonSave_RKN
            // 
            buttonSave_RKN.BackColor = Color.LightSeaGreen;
            buttonSave_RKN.Location = new Point(696, 27);
            buttonSave_RKN.Name = "buttonSave_RKN";
            buttonSave_RKN.Size = new Size(96, 56);
            buttonSave_RKN.TabIndex = 21;
            buttonSave_RKN.Text = "Открыть\r\n";
            buttonSave_RKN.UseVisualStyleBackColor = false;
            buttonSave_RKN.Click += buttonOpen_Click;
            // 
            // buttonResult_RKN
            // 
            buttonResult_RKN.BackColor = Color.Green;
            buttonResult_RKN.Location = new Point(573, 27);
            buttonResult_RKN.Name = "buttonResult_RKN";
            buttonResult_RKN.Size = new Size(117, 57);
            buttonResult_RKN.TabIndex = 19;
            buttonResult_RKN.Text = "Выполнить";
            buttonResult_RKN.UseVisualStyleBackColor = false;
            buttonResult_RKN.Click += bettonDone_Click;
            buttonResult_RKN.MouseEnter += buttonResult_RKN_MouseEnter;
            buttonResult_RKN.MouseLeave += buttonResult_RKN_MouseLeave;
            // 
            // buttonHelp_RKN
            // 
            buttonHelp_RKN.BackColor = Color.DodgerBlue;
            buttonHelp_RKN.Location = new Point(798, 29);
            buttonHelp_RKN.Name = "buttonHelp_RKN";
            buttonHelp_RKN.Size = new Size(91, 55);
            buttonHelp_RKN.TabIndex = 18;
            buttonHelp_RKN.Text = "Справка";
            buttonHelp_RKN.UseVisualStyleBackColor = false;
            buttonHelp_RKN.Click += buttonHelp_Click;
            // 
            // groupBoxTask_RKN
            // 
            groupBoxTask_RKN.Controls.Add(textBoxTask_RKN);
            groupBoxTask_RKN.Location = new Point(12, 12);
            groupBoxTask_RKN.Name = "groupBoxTask_RKN";
            groupBoxTask_RKN.Size = new Size(555, 72);
            groupBoxTask_RKN.TabIndex = 16;
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
            textBoxTask_RKN.Size = new Size(445, 44);
            textBoxTask_RKN.TabIndex = 0;
            textBoxTask_RKN.Text = "Прочитать данные из файла InPutDataFileTask5.txt. Вывести в dataGridView\r\nположительные значения и построить диаграмму по этим значениям\r\n";
            textBoxTask_RKN.SelectionStart = 0;
            // 
            // groupBoxResult_RKN
            // 
            groupBoxResult_RKN.Controls.Add(dataGridViewResult_RKN);
            groupBoxResult_RKN.Controls.Add(formsPlotChartResult_RKN);
            groupBoxResult_RKN.Location = new Point(12, 81);
            groupBoxResult_RKN.Name = "groupBoxResult_RKN";
            groupBoxResult_RKN.Size = new Size(877, 494);
            groupBoxResult_RKN.TabIndex = 20;
            groupBoxResult_RKN.TabStop = false;
            groupBoxResult_RKN.Text = "Вывод данных";
            // 
            // dataGridViewResult_RKN
            // 
            dataGridViewResult_RKN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_RKN.Location = new Point(7, 31);
            dataGridViewResult_RKN.Name = "dataGridViewResult_RKN";
            dataGridViewResult_RKN.Size = new Size(240, 271);
            dataGridViewResult_RKN.TabIndex = 4;
            // 
            // formsPlotChartResult_RKN
            // 
            formsPlotChartResult_RKN.DisplayScale = 1F;
            formsPlotChartResult_RKN.Location = new Point(253, 43);
            formsPlotChartResult_RKN.Name = "formsPlotChartResult_RKN";
            formsPlotChartResult_RKN.Size = new Size(624, 259);
            formsPlotChartResult_RKN.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 395);
            Controls.Add(buttonSave_RKN);
            Controls.Add(buttonResult_RKN);
            Controls.Add(buttonHelp_RKN);
            Controls.Add(groupBoxTask_RKN);
            Controls.Add(groupBoxResult_RKN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 3 | Рауш К.Н.";
            groupBoxTask_RKN.ResumeLayout(false);
            groupBoxTask_RKN.PerformLayout();
            groupBoxResult_RKN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_RKN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave_RKN;
        private Button buttonResult_RKN;
        private Button buttonHelp_RKN;
        private GroupBox groupBoxTask_RKN;
        private TextBox textBoxTask_RKN;
        private GroupBox groupBoxResult_RKN;
        private DataGridView dataGridViewResult_RKN;
        private ScottPlot.WinForms.FormsPlot formsPlotChartResult_RKN;
    }
}
