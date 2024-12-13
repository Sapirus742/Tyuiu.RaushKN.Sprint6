namespace Tyuiu.RaushKN.Sprint6.Task6.V5
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
            groupBoxMenu_RKN = new GroupBox();
            buttonHelp_RKN = new Button();
            buttonDone_RKN = new Button();
            buttonOpenFile_RKN = new Button();
            groupBoxTask_RKN = new GroupBox();
            textBoxTask_RKN = new TextBox();
            groupBoxOutPutData_RKN = new GroupBox();
            textBoxResult_RKN = new TextBox();
            textBoxLoadFromFile_RKN = new TextBox();
            openFileDialogTask_RKN = new OpenFileDialog();
            toolTip_RKN = new ToolTip(components);
            groupBoxMenu_RKN.SuspendLayout();
            groupBoxTask_RKN.SuspendLayout();
            groupBoxOutPutData_RKN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMenu_RKN
            // 
            groupBoxMenu_RKN.BackColor = Color.White;
            groupBoxMenu_RKN.Controls.Add(buttonHelp_RKN);
            groupBoxMenu_RKN.Controls.Add(buttonDone_RKN);
            groupBoxMenu_RKN.Controls.Add(buttonOpenFile_RKN);
            groupBoxMenu_RKN.Location = new Point(12, 12);
            groupBoxMenu_RKN.Name = "groupBoxMenu_RKN";
            groupBoxMenu_RKN.Size = new Size(825, 100);
            groupBoxMenu_RKN.TabIndex = 0;
            groupBoxMenu_RKN.TabStop = false;
            // 
            // buttonHelp_RKN
            // 
            buttonHelp_RKN.ForeColor = Color.Black;
            buttonHelp_RKN.Location = new Point(718, 22);
            buttonHelp_RKN.Name = "buttonHelp_RKN";
            buttonHelp_RKN.Size = new Size(85, 62);
            buttonHelp_RKN.TabIndex = 2;
            buttonHelp_RKN.Text = "Справка";
            buttonHelp_RKN.TextImageRelation = TextImageRelation.ImageAboveText;
            toolTip_RKN.SetToolTip(buttonHelp_RKN, "Справка о программе");
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
            toolTip_RKN.SetToolTip(buttonDone_RKN, "Выполнить");
            buttonDone_RKN.UseVisualStyleBackColor = true;
            buttonDone_RKN.Click += buttonDone_Clik;
            // 
            // buttonOpenFile_RKN
            // 
            buttonOpenFile_RKN.Location = new Point(6, 22);
            buttonOpenFile_RKN.Name = "buttonOpenFile_RKN";
            buttonOpenFile_RKN.Size = new Size(81, 62);
            buttonOpenFile_RKN.TabIndex = 0;
            buttonOpenFile_RKN.Text = "Загрузить";
            toolTip_RKN.SetToolTip(buttonOpenFile_RKN, "Загрузить файл");
            buttonOpenFile_RKN.UseVisualStyleBackColor = true;
            buttonOpenFile_RKN.Click += buttonOpenFile_Click;
            // 
            // groupBoxTask_RKN
            // 
            groupBoxTask_RKN.Controls.Add(textBoxTask_RKN);
            groupBoxTask_RKN.Location = new Point(12, 118);
            groupBoxTask_RKN.Name = "groupBoxTask_RKN";
            groupBoxTask_RKN.Size = new Size(825, 72);
            groupBoxTask_RKN.TabIndex = 1;
            groupBoxTask_RKN.TabStop = false;
            groupBoxTask_RKN.Text = "Условие";
            // 
            // textBoxTask_RKN
            // 
            textBoxTask_RKN.BackColor = SystemColors.Control;
            textBoxTask_RKN.Location = new Point(0, 22);
            textBoxTask_RKN.Multiline = true;
            textBoxTask_RKN.Name = "textBoxTask_RKN";
            textBoxTask_RKN.ReadOnly = true;
            textBoxTask_RKN.Size = new Size(819, 44);
            textBoxTask_RKN.TabIndex = 0;
            textBoxTask_RKN.Text = resources.GetString("textBoxTask_RKN.Text");
            // 
            // groupBoxOutPutData_RKN
            // 
            groupBoxOutPutData_RKN.Controls.Add(textBoxResult_RKN);
            groupBoxOutPutData_RKN.Controls.Add(textBoxLoadFromFile_RKN);
            groupBoxOutPutData_RKN.Location = new Point(12, 190);
            groupBoxOutPutData_RKN.Name = "groupBoxOutPutData_RKN";
            groupBoxOutPutData_RKN.Size = new Size(825, 342);
            groupBoxOutPutData_RKN.TabIndex = 2;
            groupBoxOutPutData_RKN.TabStop = false;
            // 
            // textBoxResult_RKN
            // 
            textBoxResult_RKN.Location = new Point(426, 22);
            textBoxResult_RKN.Multiline = true;
            textBoxResult_RKN.Name = "textBoxResult_RKN";
            textBoxResult_RKN.Size = new Size(393, 314);
            textBoxResult_RKN.TabIndex = 1;
            textBoxResult_RKN.Text = "Вывод";
            // 
            // textBoxLoadFromFile_RKN
            // 
            textBoxLoadFromFile_RKN.Location = new Point(6, 22);
            textBoxLoadFromFile_RKN.Multiline = true;
            textBoxLoadFromFile_RKN.Name = "textBoxLoadFromFile_RKN";
            textBoxLoadFromFile_RKN.Size = new Size(420, 314);
            textBoxLoadFromFile_RKN.TabIndex = 0;
            textBoxLoadFromFile_RKN.Text = "Ввод";
            // 
            // openFileDialogTask_RKN
            // 
            openFileDialogTask_RKN.FileName = "openFileDialogTask_RKN";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 544);
            Controls.Add(groupBoxOutPutData_RKN);
            Controls.Add(groupBoxTask_RKN);
            Controls.Add(groupBoxMenu_RKN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 5 | Рауш К.Н.";
            groupBoxMenu_RKN.ResumeLayout(false);
            groupBoxTask_RKN.ResumeLayout(false);
            groupBoxTask_RKN.PerformLayout();
            groupBoxOutPutData_RKN.ResumeLayout(false);
            groupBoxOutPutData_RKN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMenu_RKN;
        private GroupBox groupBoxTask_RKN;
        private GroupBox groupBoxOutPutData_RKN;
        private OpenFileDialog openFileDialogTask_RKN;
        private Button buttonHelp_RKN;
        private Button buttonDone_RKN;
        private Button buttonOpenFile_RKN;
        private TextBox textBoxTask_RKN;
        private TextBox textBoxResult_RKN;
        private TextBox textBoxLoadFromFile_RKN;
        private ToolTip toolTip_RKN;
    }
}
