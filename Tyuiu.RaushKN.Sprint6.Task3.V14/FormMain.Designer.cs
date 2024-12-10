using System.Windows.Forms;

namespace Tyuiu.RaushKN.Sprint6.Task3.V14
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
            groupBoxTask_RKN = new GroupBox();
            dataGridViewMatrixData_RKN = new DataGridView();
            textBoxTask_RKN = new TextBox();
            groupBoxResult_RKN = new GroupBox();
            dataGridViewMatrixResult_RKN = new DataGridView();
            buttonResult_RKN = new Button();
            buttonHelp_RKN = new Button();
            groupBoxTask_RKN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixData_RKN).BeginInit();
            groupBoxResult_RKN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixResult_RKN).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_RKN
            // 
            groupBoxTask_RKN.Controls.Add(dataGridViewMatrixData_RKN);
            groupBoxTask_RKN.Controls.Add(textBoxTask_RKN);
            groupBoxTask_RKN.Location = new Point(12, 12);
            groupBoxTask_RKN.Name = "groupBoxTask_RKN";
            groupBoxTask_RKN.Size = new Size(524, 289);
            groupBoxTask_RKN.TabIndex = 6;
            groupBoxTask_RKN.TabStop = false;
            groupBoxTask_RKN.Text = "Условие";
            // 
            // dataGridViewMatrixData_RKN
            // 
            dataGridViewMatrixData_RKN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixData_RKN.Location = new Point(314, 42);
            dataGridViewMatrixData_RKN.Name = "dataGridViewMatrixData_RKN";
            dataGridViewMatrixData_RKN.RowHeadersVisible = false;
            dataGridViewMatrixData_RKN.Size = new Size(175, 143);
            dataGridViewMatrixData_RKN.TabIndex = 0;
            // 
            // textBoxTask_RKN
            // 
            textBoxTask_RKN.BackColor = SystemColors.Control;
            textBoxTask_RKN.BorderStyle = BorderStyle.None;
            textBoxTask_RKN.Location = new Point(6, 22);
            textBoxTask_RKN.Multiline = true;
            textBoxTask_RKN.Name = "textBoxTask_RKN";
            textBoxTask_RKN.ReadOnly = true;
            textBoxTask_RKN.Size = new Size(302, 201);
            textBoxTask_RKN.TabIndex = 0;
            textBoxTask_RKN.Text = "Дана матрица 5 на 5:\r\n\r\n1   4  -5 -12  -8\r\n\r\n-7 -20  11 -13   6\r\n\r\n2 -12   1 -12   3\r\n\r\n-1  -7 -20  -6  17\r\n\r\n-3   3   2  13 -17\r\n\r\nЗаменить четные значения во второй строке на 0.";
            // 
            // groupBoxResult_RKN
            // 
            groupBoxResult_RKN.Controls.Add(dataGridViewMatrixResult_RKN);
            groupBoxResult_RKN.Location = new Point(542, 12);
            groupBoxResult_RKN.Name = "groupBoxResult_RKN";
            groupBoxResult_RKN.Size = new Size(309, 235);
            groupBoxResult_RKN.TabIndex = 10;
            groupBoxResult_RKN.TabStop = false;
            groupBoxResult_RKN.Text = "Вывод данных";
            // 
            // dataGridViewMatrixResult_RKN
            // 
            dataGridViewMatrixResult_RKN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixResult_RKN.Location = new Point(18, 42);
            dataGridViewMatrixResult_RKN.Name = "dataGridViewMatrixResult_RKN";
            dataGridViewMatrixResult_RKN.RowHeadersVisible = false;
            dataGridViewMatrixResult_RKN.Size = new Size(165, 143);
            dataGridViewMatrixResult_RKN.TabIndex = 1;
            // 
            // buttonResult_RKN
            // 
            buttonResult_RKN.BackColor = SystemColors.ButtonFace;
            buttonResult_RKN.Location = new Point(698, 258);
            buttonResult_RKN.Name = "buttonResult_RKN";
            buttonResult_RKN.Size = new Size(135, 48);
            buttonResult_RKN.TabIndex = 12;
            buttonResult_RKN.Text = "Выполнить";
            buttonResult_RKN.UseVisualStyleBackColor = false;
            buttonResult_RKN.Click += buttonResult_RKN_Click;
            // 
            // buttonHelp_RKN
            // 
            buttonHelp_RKN.BackColor = Color.White;
            buttonHelp_RKN.Location = new Point(650, 263);
            buttonHelp_RKN.Name = "buttonHelp_RKN";
            buttonHelp_RKN.Size = new Size(42, 38);
            buttonHelp_RKN.TabIndex = 11;
            buttonHelp_RKN.Text = "?";
            buttonHelp_RKN.UseVisualStyleBackColor = false;
            buttonHelp_RKN.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 320);
            Controls.Add(buttonResult_RKN);
            Controls.Add(buttonHelp_RKN);
            Controls.Add(groupBoxResult_RKN);
            Controls.Add(groupBoxTask_RKN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 27 | Рауш К.Н.";
            Load += FormMain_Load;
            groupBoxTask_RKN.ResumeLayout(false);
            groupBoxTask_RKN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixData_RKN).EndInit();
            groupBoxResult_RKN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixResult_RKN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_RKN;
        private TextBox textBoxTask_RKN;
        private GroupBox groupBoxResult_RKN;
        private DataGridView dataGridViewMatrixData_RKN;
        private Button buttonResult_RKN;
        private Button buttonHelp_RKN;
        private DataGridView dataGridViewMatrixResult_RKN;
    }
}
