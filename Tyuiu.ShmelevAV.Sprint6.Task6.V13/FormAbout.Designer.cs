namespace Tyuiu.ShmelevAV.Sprint6.Task6.V13
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
            pictureBoxZero_SAV = new PictureBox();
            labelText_SAV = new Label();
            buttonOk_SAV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZero_SAV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxZero_SAV
            // 
            pictureBoxZero_SAV.Image = Properties.Resources.Rei_Ayanami_Moon;
            pictureBoxZero_SAV.Location = new Point(22, 67);
            pictureBoxZero_SAV.Name = "pictureBoxZero_SAV";
            pictureBoxZero_SAV.Size = new Size(150, 113);
            pictureBoxZero_SAV.TabIndex = 0;
            pictureBoxZero_SAV.TabStop = false;
            // 
            // labelText_SAV
            // 
            labelText_SAV.AutoSize = true;
            labelText_SAV.Location = new Point(188, 56);
            labelText_SAV.Name = "labelText_SAV";
            labelText_SAV.Size = new Size(303, 135);
            labelText_SAV.TabIndex = 1;
            labelText_SAV.Text = resources.GetString("labelText_SAV.Text");
            // 
            // buttonOk_SAV
            // 
            buttonOk_SAV.Location = new Point(416, 212);
            buttonOk_SAV.Name = "buttonOk_SAV";
            buttonOk_SAV.Size = new Size(75, 23);
            buttonOk_SAV.TabIndex = 2;
            buttonOk_SAV.Text = "Ok";
            buttonOk_SAV.UseVisualStyleBackColor = true;
            buttonOk_SAV.Click += buttonOk_SAV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 247);
            Controls.Add(buttonOk_SAV);
            Controls.Add(labelText_SAV);
            Controls.Add(pictureBoxZero_SAV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxZero_SAV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxZero_SAV;
        private Label labelText_SAV;
        private Button buttonOk_SAV;
    }
}