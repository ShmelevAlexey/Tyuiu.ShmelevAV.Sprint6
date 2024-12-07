namespace Tyuiu.ShmelevAV.Sprint6.Task3.V15
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
            labelConditionText_SAV = new Label();
            groupBoxOutput_SAV = new GroupBox();
            dataGridViewMatrix_SAV = new DataGridView();
            buttonStart_SAV = new Button();
            buttonHelp_SAV = new Button();
            groupBoxCondition_SAV.SuspendLayout();
            groupBoxOutput_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SAV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_SAV
            // 
            groupBoxCondition_SAV.Controls.Add(labelConditionText_SAV);
            groupBoxCondition_SAV.Location = new Point(12, 12);
            groupBoxCondition_SAV.Name = "groupBoxCondition_SAV";
            groupBoxCondition_SAV.Size = new Size(389, 290);
            groupBoxCondition_SAV.TabIndex = 0;
            groupBoxCondition_SAV.TabStop = false;
            groupBoxCondition_SAV.Text = "Условие";
            // 
            // labelConditionText_SAV
            // 
            labelConditionText_SAV.AutoSize = true;
            labelConditionText_SAV.Location = new Point(6, 19);
            labelConditionText_SAV.Name = "labelConditionText_SAV";
            labelConditionText_SAV.Size = new Size(335, 135);
            labelConditionText_SAV.TabIndex = 0;
            labelConditionText_SAV.Text = "Дан массив 5 на 5 элементов.\r\n\r\n 33  28  31  19   4\r\n   1  32  -3 -17 -12\r\n  24 -19  26  31  -3\r\n  30 -16  29  28   8\r\n  30   5  11   7  32\r\n\r\nВыполнить сортировку по возрастанию в третьем столбце.";
            // 
            // groupBoxOutput_SAV
            // 
            groupBoxOutput_SAV.Controls.Add(dataGridViewMatrix_SAV);
            groupBoxOutput_SAV.Location = new Point(407, 12);
            groupBoxOutput_SAV.Name = "groupBoxOutput_SAV";
            groupBoxOutput_SAV.Size = new Size(319, 243);
            groupBoxOutput_SAV.TabIndex = 1;
            groupBoxOutput_SAV.TabStop = false;
            groupBoxOutput_SAV.Text = "Вывод данных";
            // 
            // dataGridViewMatrix_SAV
            // 
            dataGridViewMatrix_SAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_SAV.Location = new Point(6, 22);
            dataGridViewMatrix_SAV.Name = "dataGridViewMatrix_SAV";
            dataGridViewMatrix_SAV.Size = new Size(307, 215);
            dataGridViewMatrix_SAV.TabIndex = 1;
            // 
            // buttonStart_SAV
            // 
            buttonStart_SAV.Location = new Point(649, 279);
            buttonStart_SAV.Name = "buttonStart_SAV";
            buttonStart_SAV.Size = new Size(77, 23);
            buttonStart_SAV.TabIndex = 2;
            buttonStart_SAV.Text = "Выполнить";
            buttonStart_SAV.UseVisualStyleBackColor = true;
            buttonStart_SAV.Click += buttonStart_SAV_Click;
            // 
            // buttonHelp_SAV
            // 
            buttonHelp_SAV.Location = new Point(623, 280);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(20, 20);
            buttonHelp_SAV.TabIndex = 3;
            buttonHelp_SAV.Text = "?";
            buttonHelp_SAV.UseVisualStyleBackColor = true;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 314);
            Controls.Add(buttonHelp_SAV);
            Controls.Add(buttonStart_SAV);
            Controls.Add(groupBoxOutput_SAV);
            Controls.Add(groupBoxCondition_SAV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 15 | Шмелев А. В.";
            Load += FormMain_Load;
            groupBoxCondition_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.PerformLayout();
            groupBoxOutput_SAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_SAV;
        private GroupBox groupBoxOutput_SAV;
        private Label labelConditionText_SAV;
        private DataGridView dataGridViewMatrix_SAV;
        private Button buttonStart_SAV;
        private Button buttonHelp_SAV;
    }
}
