namespace Tyuiu.RaushKN.Sprint6.Task7.V16
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxOutPutData_RKN = new GroupBox();
            dataGridViewOutMatrix_RKN = new DataGridView();
            dataGridViewInMatrix_RKN = new DataGridView();
            groupBoxTask_RKN = new GroupBox();
            textBoxTask_RKN = new TextBox();
            groupBoxMenu_RKN = new GroupBox();
            buttonSaveFile_RKN = new Button();
            buttonHelp_RKN = new Button();
            buttonDone_RKN = new Button();
            buttonOpenFile_RKN = new Button();
            openFileDialogTask_RKN = new OpenFileDialog();
            toolTip_RKN = new ToolTip(components);
            saveFileDialogMatrix_RKN = new SaveFileDialog();
            groupBoxOutPutData_RKN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_RKN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_RKN).BeginInit();
            groupBoxTask_RKN.SuspendLayout();
            groupBoxMenu_RKN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOutPutData_RKN
            // 
            groupBoxOutPutData_RKN.Controls.Add(dataGridViewOutMatrix_RKN);
            groupBoxOutPutData_RKN.Controls.Add(dataGridViewInMatrix_RKN);
            groupBoxOutPutData_RKN.Dock = DockStyle.Bottom;
            groupBoxOutPutData_RKN.Location = new Point(0, 177);
            groupBoxOutPutData_RKN.Name = "groupBoxOutPutData_RKN";
            groupBoxOutPutData_RKN.Size = new Size(858, 352);
            groupBoxOutPutData_RKN.TabIndex = 5;
            groupBoxOutPutData_RKN.TabStop = false;
            // 
            // dataGridViewOutMatrix_RKN
            // 
            dataGridViewOutMatrix_RKN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_RKN.Location = new Point(409, 22);
            dataGridViewOutMatrix_RKN.Name = "dataGridViewOutMatrix_RKN";
            dataGridViewOutMatrix_RKN.Size = new Size(435, 314);
            dataGridViewOutMatrix_RKN.TabIndex = 1;
            // 
            // dataGridViewInMatrix_RKN
            // 
            dataGridViewInMatrix_RKN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_RKN.Location = new Point(15, 22);
            dataGridViewInMatrix_RKN.Name = "dataGridViewInMatrix_RKN";
            dataGridViewInMatrix_RKN.Size = new Size(372, 314);
            dataGridViewInMatrix_RKN.TabIndex = 0;
            // 
            // groupBoxTask_RKN
            // 
            groupBoxTask_RKN.Controls.Add(textBoxTask_RKN);
            groupBoxTask_RKN.Location = new Point(6, 106);
            groupBoxTask_RKN.Name = "groupBoxTask_RKN";
            groupBoxTask_RKN.Size = new Size(825, 72);
            groupBoxTask_RKN.TabIndex = 4;
            groupBoxTask_RKN.TabStop = false;
            groupBoxTask_RKN.Text = "Условие";
            // 
            // textBoxTask_RKN
            // 
            textBoxTask_RKN.BackColor = SystemColors.Control;
            textBoxTask_RKN.Dock = DockStyle.Fill;
            textBoxTask_RKN.Location = new Point(3, 19);
            textBoxTask_RKN.Multiline = true;
            textBoxTask_RKN.Name = "textBoxTask_RKN";
            textBoxTask_RKN.ReadOnly = true;
            textBoxTask_RKN.Size = new Size(819, 50);
            textBoxTask_RKN.TabIndex = 0;
            textBoxTask_RKN.Text = resources.GetString("textBoxTask_RKN.Text");
            // 
            // groupBoxMenu_RKN
            // 
            groupBoxMenu_RKN.Controls.Add(buttonSaveFile_RKN);
            groupBoxMenu_RKN.Controls.Add(buttonHelp_RKN);
            groupBoxMenu_RKN.Controls.Add(buttonDone_RKN);
            groupBoxMenu_RKN.Controls.Add(buttonOpenFile_RKN);
            groupBoxMenu_RKN.Dock = DockStyle.Top;
            groupBoxMenu_RKN.Location = new Point(0, 0);
            groupBoxMenu_RKN.Name = "groupBoxMenu_RKN";
            groupBoxMenu_RKN.Size = new Size(858, 100);
            groupBoxMenu_RKN.TabIndex = 3;
            groupBoxMenu_RKN.TabStop = false;
            // 
            // buttonSaveFile_RKN
            // 
            buttonSaveFile_RKN.Enabled = false;
            buttonSaveFile_RKN.Location = new Point(184, 22);
            buttonSaveFile_RKN.Name = "buttonSaveFile_RKN";
            buttonSaveFile_RKN.Size = new Size(88, 62);
            buttonSaveFile_RKN.TabIndex = 3;
            buttonSaveFile_RKN.Text = "Сохранить";
            buttonSaveFile_RKN.UseVisualStyleBackColor = true;
            buttonSaveFile_RKN.Click += buttonSaveFile_Click;
            // 
            // buttonHelp_RKN
            // 
            buttonHelp_RKN.Location = new Point(777, 22);
            buttonHelp_RKN.Name = "buttonHelp_RKN";
            buttonHelp_RKN.Size = new Size(75, 62);
            buttonHelp_RKN.TabIndex = 2;
            buttonHelp_RKN.Text = "Справка";
            buttonHelp_RKN.UseVisualStyleBackColor = true;
            buttonHelp_RKN.Click += buttonHelp_Click;
            // 
            // buttonDone_RKN
            // 
            buttonDone_RKN.Enabled = false;
            buttonDone_RKN.Location = new Point(93, 22);
            buttonDone_RKN.Name = "buttonDone_RKN";
            buttonDone_RKN.Size = new Size(85, 62);
            buttonDone_RKN.TabIndex = 1;
            buttonDone_RKN.Text = "Выполнить";
            buttonDone_RKN.UseVisualStyleBackColor = true;
            buttonDone_RKN.Click += buttonDone_Click;
            // 
            // buttonOpenFile_RKN
            // 
            buttonOpenFile_RKN.Location = new Point(6, 22);
            buttonOpenFile_RKN.Name = "buttonOpenFile_RKN";
            buttonOpenFile_RKN.Size = new Size(81, 62);
            buttonOpenFile_RKN.TabIndex = 0;
            buttonOpenFile_RKN.Text = "Загрузить";
            buttonOpenFile_RKN.UseVisualStyleBackColor = true;
            buttonOpenFile_RKN.Click += buttonOpenFile_Click;
            // 
            // openFileDialogTask_RKN
            // 
            openFileDialogTask_RKN.FileName = "openFileDialogTask_RKN";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 529);
            Controls.Add(groupBoxOutPutData_RKN);
            Controls.Add(groupBoxTask_RKN);
            Controls.Add(groupBoxMenu_RKN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 16 | Рауш К.Н.";
            groupBoxOutPutData_RKN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_RKN).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_RKN).EndInit();
            groupBoxTask_RKN.ResumeLayout(false);
            groupBoxTask_RKN.PerformLayout();
            groupBoxMenu_RKN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOutPutData_RKN;
        private GroupBox groupBoxTask_RKN;
        private TextBox textBoxTask_RKN;
        private GroupBox groupBoxMenu_RKN;
        private Button buttonHelp_RKN;
        private Button buttonDone_RKN;
        private Button buttonOpenFile_RKN;
        private OpenFileDialog openFileDialogTask_RKN;
        private ToolTip toolTip_RKN;
        private DataGridView dataGridViewOutMatrix_RKN;
        private DataGridView dataGridViewInMatrix_RKN;
        private SaveFileDialog saveFileDialogMatrix_RKN;
        private Button buttonSaveFile_RKN;
    }
}
