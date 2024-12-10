namespace Tyuiu.RaushKN.Sprint6.Task6.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            LabelInfo_RKN = new TextBox();
            buttonOk_RKN = new Button();
            SuspendLayout();
            // 
            // LabelInfo_RKN
            // 
            LabelInfo_RKN.BorderStyle = BorderStyle.None;
            LabelInfo_RKN.Location = new Point(12, 12);
            LabelInfo_RKN.Multiline = true;
            LabelInfo_RKN.Name = "LabelInfo_RKN";
            LabelInfo_RKN.ReadOnly = true;
            LabelInfo_RKN.Size = new Size(322, 152);
            LabelInfo_RKN.TabIndex = 0;
            LabelInfo_RKN.Text = resources.GetString("LabelInfo_RKN.Text");
            LabelInfo_RKN.SelectionStart = 0;
            // 
            // buttonOk_RKN
            // 
            buttonOk_RKN.AllowDrop = true;
            buttonOk_RKN.Location = new Point(204, 155);
            buttonOk_RKN.Name = "buttonOk_RKN";
            buttonOk_RKN.Size = new Size(112, 39);
            buttonOk_RKN.TabIndex = 1;
            buttonOk_RKN.Text = "Ок";
            buttonOk_RKN.UseVisualStyleBackColor = true;
            buttonOk_RKN.Click += buttonRKN_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 206);
            Controls.Add(buttonOk_RKN);
            Controls.Add(LabelInfo_RKN);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LabelInfo_RKN;
        private Button buttonOk_RKN;
    }
}