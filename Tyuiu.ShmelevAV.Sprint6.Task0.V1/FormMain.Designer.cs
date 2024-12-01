namespace Tyuiu.ShmelevAV.Sprint6.Task0.V1
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
            groupBoxCondition_SAV = new GroupBox();
            pictureBoxFormula_SAV = new PictureBox();
            labelGoal_SAV = new Label();
            groupBoxInput_SAV = new GroupBox();
            labelVariable_SAV = new Label();
            textBoxWrite_SAV = new TextBox();
            groupBoxOutput_SAV = new GroupBox();
            textBoxResult_SAV = new TextBox();
            buttonStart_SAV = new Button();
            buttonHelp_SAV = new Button();
            groupBoxCondition_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SAV).BeginInit();
            groupBoxInput_SAV.SuspendLayout();
            groupBoxOutput_SAV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_SAV
            // 
            groupBoxCondition_SAV.Controls.Add(pictureBoxFormula_SAV);
            groupBoxCondition_SAV.Controls.Add(labelGoal_SAV);
            groupBoxCondition_SAV.Location = new Point(27, 23);
            groupBoxCondition_SAV.Name = "groupBoxCondition_SAV";
            groupBoxCondition_SAV.Size = new Size(530, 164);
            groupBoxCondition_SAV.TabIndex = 0;
            groupBoxCondition_SAV.TabStop = false;
            groupBoxCondition_SAV.Text = "Условие";
            // 
            // pictureBoxFormula_SAV
            // 
            pictureBoxFormula_SAV.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFormula_SAV.Image = Properties.Resources.Untitled;
            pictureBoxFormula_SAV.Location = new Point(405, 19);
            pictureBoxFormula_SAV.Name = "pictureBoxFormula_SAV";
            pictureBoxFormula_SAV.Size = new Size(115, 52);
            pictureBoxFormula_SAV.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFormula_SAV.TabIndex = 2;
            pictureBoxFormula_SAV.TabStop = false;
            // 
            // labelGoal_SAV
            // 
            labelGoal_SAV.AutoSize = true;
            labelGoal_SAV.Location = new Point(6, 19);
            labelGoal_SAV.Name = "labelGoal_SAV";
            labelGoal_SAV.Size = new Size(205, 15);
            labelGoal_SAV.TabIndex = 1;
            labelGoal_SAV.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_SAV
            // 
            groupBoxInput_SAV.Controls.Add(labelVariable_SAV);
            groupBoxInput_SAV.Controls.Add(textBoxWrite_SAV);
            groupBoxInput_SAV.Location = new Point(27, 193);
            groupBoxInput_SAV.Name = "groupBoxInput_SAV";
            groupBoxInput_SAV.Size = new Size(348, 100);
            groupBoxInput_SAV.TabIndex = 1;
            groupBoxInput_SAV.TabStop = false;
            groupBoxInput_SAV.Text = "Ввод данных";
            // 
            // labelVariable_SAV
            // 
            labelVariable_SAV.AutoSize = true;
            labelVariable_SAV.Location = new Point(130, 19);
            labelVariable_SAV.Name = "labelVariable_SAV";
            labelVariable_SAV.Size = new Size(89, 15);
            labelVariable_SAV.TabIndex = 3;
            labelVariable_SAV.Text = "Переменная X:";
            // 
            // textBoxWrite_SAV
            // 
            textBoxWrite_SAV.Cursor = Cursors.IBeam;
            textBoxWrite_SAV.Location = new Point(124, 39);
            textBoxWrite_SAV.Name = "textBoxWrite_SAV";
            textBoxWrite_SAV.Size = new Size(100, 23);
            textBoxWrite_SAV.TabIndex = 0;
            textBoxWrite_SAV.KeyPress += textBoxWrite_SAV_KeyPress;
            // 
            // groupBoxOutput_SAV
            // 
            groupBoxOutput_SAV.Controls.Add(textBoxResult_SAV);
            groupBoxOutput_SAV.Location = new Point(381, 193);
            groupBoxOutput_SAV.Name = "groupBoxOutput_SAV";
            groupBoxOutput_SAV.Size = new Size(176, 100);
            groupBoxOutput_SAV.TabIndex = 2;
            groupBoxOutput_SAV.TabStop = false;
            groupBoxOutput_SAV.Text = "Вывод данных";
            // 
            // textBoxResult_SAV
            // 
            textBoxResult_SAV.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult_SAV.Location = new Point(38, 39);
            textBoxResult_SAV.Name = "textBoxResult_SAV";
            textBoxResult_SAV.ReadOnly = true;
            textBoxResult_SAV.Size = new Size(100, 23);
            textBoxResult_SAV.TabIndex = 0;
            // 
            // buttonStart_SAV
            // 
            buttonStart_SAV.Cursor = Cursors.Hand;
            buttonStart_SAV.Location = new Point(472, 319);
            buttonStart_SAV.Name = "buttonStart_SAV";
            buttonStart_SAV.Size = new Size(100, 30);
            buttonStart_SAV.TabIndex = 3;
            buttonStart_SAV.Text = "Выполнить";
            buttonStart_SAV.UseVisualStyleBackColor = true;
            buttonStart_SAV.Click += buttonStart_SAV_Click;
            // 
            // buttonHelp_SAV
            // 
            buttonHelp_SAV.Cursor = Cursors.Help;
            buttonHelp_SAV.FlatStyle = FlatStyle.Flat;
            buttonHelp_SAV.Location = new Point(12, 324);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(25, 25);
            buttonHelp_SAV.TabIndex = 4;
            buttonHelp_SAV.Text = "?";
            buttonHelp_SAV.UseVisualStyleBackColor = true;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(buttonHelp_SAV);
            Controls.Add(buttonStart_SAV);
            Controls.Add(groupBoxOutput_SAV);
            Controls.Add(groupBoxInput_SAV);
            Controls.Add(groupBoxCondition_SAV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 1 | Шмелев А. В.";
            groupBoxCondition_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SAV).EndInit();
            groupBoxInput_SAV.ResumeLayout(false);
            groupBoxInput_SAV.PerformLayout();
            groupBoxOutput_SAV.ResumeLayout(false);
            groupBoxOutput_SAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_SAV;
        private GroupBox groupBoxInput_SAV;
        private GroupBox groupBoxOutput_SAV;
        private TextBox textBoxWrite_SAV;
        private Label labelGoal_SAV;
        private PictureBox pictureBoxFormula_SAV;
        private Label labelVariable_SAV;
        private TextBox textBoxResult_SAV;
        private Button buttonStart_SAV;
        private Button buttonHelp_SAV;
    }
}
