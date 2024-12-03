namespace Tyuiu.ShmelevAV.Sprint6.Task1.V22
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
            labelStop_SAV = new Label();
            labelStart_SAV = new Label();
            groupBoxOutput_SAV = new GroupBox();
            labelResult_SAV = new Label();
            textBoxResult_SAV = new TextBox();
            groupBoxInput_SAV = new GroupBox();
            textBoxInputStop_SAV = new TextBox();
            textBoxInputStart_SAV = new TextBox();
            buttonHelp_SAV = new Button();
            buttonStart_SAV = new Button();
            groupBoxCondition_SAV.SuspendLayout();
            groupBoxOutput_SAV.SuspendLayout();
            groupBoxInput_SAV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_SAV
            // 
            groupBoxCondition_SAV.Controls.Add(labelConditionText_SAV);
            groupBoxCondition_SAV.Location = new Point(12, 12);
            groupBoxCondition_SAV.Name = "groupBoxCondition_SAV";
            groupBoxCondition_SAV.Size = new Size(418, 254);
            groupBoxCondition_SAV.TabIndex = 0;
            groupBoxCondition_SAV.TabStop = false;
            groupBoxCondition_SAV.Text = "Условие";
            // 
            // labelConditionText_SAV
            // 
            labelConditionText_SAV.AutoSize = true;
            labelConditionText_SAV.Location = new Point(6, 19);
            labelConditionText_SAV.Name = "labelConditionText_SAV";
            labelConditionText_SAV.Size = new Size(298, 30);
            labelConditionText_SAV.TabIndex = 0;
            labelConditionText_SAV.Text = "Протабулировать функцию на заданном диапазоне. \r\nРезультат вывести в виде таблицы.";
            // 
            // labelStop_SAV
            // 
            labelStop_SAV.AutoSize = true;
            labelStop_SAV.Location = new Point(112, 34);
            labelStop_SAV.Name = "labelStop_SAV";
            labelStop_SAV.Size = new Size(75, 15);
            labelStop_SAV.TabIndex = 2;
            labelStop_SAV.Text = "Конец шага:";
            // 
            // labelStart_SAV
            // 
            labelStart_SAV.AutoSize = true;
            labelStart_SAV.Location = new Point(6, 34);
            labelStart_SAV.Name = "labelStart_SAV";
            labelStart_SAV.Size = new Size(72, 15);
            labelStart_SAV.TabIndex = 1;
            labelStart_SAV.Text = "Старт шага:";
            // 
            // groupBoxOutput_SAV
            // 
            groupBoxOutput_SAV.Controls.Add(labelResult_SAV);
            groupBoxOutput_SAV.Controls.Add(textBoxResult_SAV);
            groupBoxOutput_SAV.Location = new Point(436, 12);
            groupBoxOutput_SAV.Name = "groupBoxOutput_SAV";
            groupBoxOutput_SAV.Size = new Size(236, 357);
            groupBoxOutput_SAV.TabIndex = 1;
            groupBoxOutput_SAV.TabStop = false;
            groupBoxOutput_SAV.Text = "Вывод данных";
            // 
            // labelResult_SAV
            // 
            labelResult_SAV.AutoSize = true;
            labelResult_SAV.Location = new Point(6, 21);
            labelResult_SAV.Name = "labelResult_SAV";
            labelResult_SAV.Size = new Size(63, 15);
            labelResult_SAV.TabIndex = 1;
            labelResult_SAV.Text = "Результат:";
            // 
            // textBoxResult_SAV
            // 
            textBoxResult_SAV.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_SAV.Location = new Point(6, 39);
            textBoxResult_SAV.Multiline = true;
            textBoxResult_SAV.Name = "textBoxResult_SAV";
            textBoxResult_SAV.ReadOnly = true;
            textBoxResult_SAV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SAV.Size = new Size(224, 312);
            textBoxResult_SAV.TabIndex = 0;
            // 
            // groupBoxInput_SAV
            // 
            groupBoxInput_SAV.Controls.Add(labelStop_SAV);
            groupBoxInput_SAV.Controls.Add(textBoxInputStop_SAV);
            groupBoxInput_SAV.Controls.Add(labelStart_SAV);
            groupBoxInput_SAV.Controls.Add(textBoxInputStart_SAV);
            groupBoxInput_SAV.Location = new Point(12, 272);
            groupBoxInput_SAV.Name = "groupBoxInput_SAV";
            groupBoxInput_SAV.Size = new Size(216, 97);
            groupBoxInput_SAV.TabIndex = 2;
            groupBoxInput_SAV.TabStop = false;
            groupBoxInput_SAV.Text = "Ввод данных";
            // 
            // textBoxInputStop_SAV
            // 
            textBoxInputStop_SAV.Location = new Point(112, 52);
            textBoxInputStop_SAV.Name = "textBoxInputStop_SAV";
            textBoxInputStop_SAV.Size = new Size(100, 23);
            textBoxInputStop_SAV.TabIndex = 2;
            textBoxInputStop_SAV.Text = "5";
            // 
            // textBoxInputStart_SAV
            // 
            textBoxInputStart_SAV.Location = new Point(6, 52);
            textBoxInputStart_SAV.Name = "textBoxInputStart_SAV";
            textBoxInputStart_SAV.Size = new Size(100, 23);
            textBoxInputStart_SAV.TabIndex = 1;
            textBoxInputStart_SAV.Text = "-5";
            // 
            // buttonHelp_SAV
            // 
            buttonHelp_SAV.BackColor = SystemColors.MenuHighlight;
            buttonHelp_SAV.Location = new Point(255, 297);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(75, 57);
            buttonHelp_SAV.TabIndex = 3;
            buttonHelp_SAV.Text = "Справка";
            buttonHelp_SAV.UseVisualStyleBackColor = false;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;
            // 
            // buttonStart_SAV
            // 
            buttonStart_SAV.BackColor = Color.Green;
            buttonStart_SAV.Location = new Point(336, 297);
            buttonStart_SAV.Name = "buttonStart_SAV";
            buttonStart_SAV.Size = new Size(77, 57);
            buttonStart_SAV.TabIndex = 4;
            buttonStart_SAV.Text = "Выполнить";
            buttonStart_SAV.UseVisualStyleBackColor = false;
            buttonStart_SAV.Click += buttonStart_SAV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 381);
            Controls.Add(buttonStart_SAV);
            Controls.Add(buttonHelp_SAV);
            Controls.Add(groupBoxInput_SAV);
            Controls.Add(groupBoxOutput_SAV);
            Controls.Add(groupBoxCondition_SAV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 22 | Шмелев А. В.";
            groupBoxCondition_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.PerformLayout();
            groupBoxOutput_SAV.ResumeLayout(false);
            groupBoxOutput_SAV.PerformLayout();
            groupBoxInput_SAV.ResumeLayout(false);
            groupBoxInput_SAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_SAV;
        private GroupBox groupBoxOutput_SAV;
        private Label labelConditionText_SAV;
        private GroupBox groupBoxInput_SAV;
        private TextBox textBoxResult_SAV;
        private TextBox textBoxInputStop_SAV;
        private TextBox textBoxInputStart_SAV;
        private Label labelStop_SAV;
        private Label labelStart_SAV;
        private Label labelResult_SAV;
        private Button buttonHelp_SAV;
        private Button buttonStart_SAV;
    }
}
