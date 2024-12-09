namespace Tyuiu.ShmelevAV.Sprint6.Task4.V26
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxCondition_SAV = new GroupBox();
            labelConditionText_SAV = new Label();
            groupBoxInput_SAV = new GroupBox();
            textBoxInputStart_SAV = new TextBox();
            labelStop_SAV = new Label();
            textBoxInputStop_SAV = new TextBox();
            labelStart_SAV = new Label();
            groupBoxOutput_SAV = new GroupBox();
            textBoxOutput_SAV = new TextBox();
            buttonStart_SAV = new Button();
            buttonHelp_SAV = new Button();
            buttonSave_SAV = new Button();
            chartDiagram_SAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_SAV.SuspendLayout();
            groupBoxInput_SAV.SuspendLayout();
            groupBoxOutput_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagram_SAV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_SAV
            // 
            groupBoxCondition_SAV.Controls.Add(labelConditionText_SAV);
            groupBoxCondition_SAV.Location = new Point(12, 12);
            groupBoxCondition_SAV.Name = "groupBoxCondition_SAV";
            groupBoxCondition_SAV.Size = new Size(444, 85);
            groupBoxCondition_SAV.TabIndex = 0;
            groupBoxCondition_SAV.TabStop = false;
            groupBoxCondition_SAV.Text = "Условие:";
            // 
            // labelConditionText_SAV
            // 
            labelConditionText_SAV.AutoSize = true;
            labelConditionText_SAV.Location = new Point(6, 19);
            labelConditionText_SAV.Name = "labelConditionText_SAV";
            labelConditionText_SAV.Size = new Size(429, 45);
            labelConditionText_SAV.TabIndex = 3;
            labelConditionText_SAV.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5. \r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V26.txt по нажатию кнопки.";
            // 
            // groupBoxInput_SAV
            // 
            groupBoxInput_SAV.Controls.Add(textBoxInputStart_SAV);
            groupBoxInput_SAV.Controls.Add(labelStop_SAV);
            groupBoxInput_SAV.Controls.Add(textBoxInputStop_SAV);
            groupBoxInput_SAV.Controls.Add(labelStart_SAV);
            groupBoxInput_SAV.Location = new Point(462, 12);
            groupBoxInput_SAV.Name = "groupBoxInput_SAV";
            groupBoxInput_SAV.Size = new Size(218, 85);
            groupBoxInput_SAV.TabIndex = 1;
            groupBoxInput_SAV.TabStop = false;
            groupBoxInput_SAV.Text = "Ввод данных:";
            // 
            // textBoxInputStart_SAV
            // 
            textBoxInputStart_SAV.Location = new Point(6, 41);
            textBoxInputStart_SAV.Name = "textBoxInputStart_SAV";
            textBoxInputStart_SAV.Size = new Size(100, 23);
            textBoxInputStart_SAV.TabIndex = 5;
            textBoxInputStart_SAV.Text = "-5";
            // 
            // labelStop_SAV
            // 
            labelStop_SAV.AutoSize = true;
            labelStop_SAV.Location = new Point(112, 23);
            labelStop_SAV.Name = "labelStop_SAV";
            labelStop_SAV.Size = new Size(75, 15);
            labelStop_SAV.TabIndex = 4;
            labelStop_SAV.Text = "Конец шага:";
            // 
            // textBoxInputStop_SAV
            // 
            textBoxInputStop_SAV.Location = new Point(112, 41);
            textBoxInputStop_SAV.Name = "textBoxInputStop_SAV";
            textBoxInputStop_SAV.Size = new Size(100, 23);
            textBoxInputStop_SAV.TabIndex = 6;
            textBoxInputStop_SAV.Text = "5";
            // 
            // labelStart_SAV
            // 
            labelStart_SAV.AutoSize = true;
            labelStart_SAV.Location = new Point(6, 23);
            labelStart_SAV.Name = "labelStart_SAV";
            labelStart_SAV.Size = new Size(72, 15);
            labelStart_SAV.TabIndex = 3;
            labelStart_SAV.Text = "Старт шага:";
            // 
            // groupBoxOutput_SAV
            // 
            groupBoxOutput_SAV.Controls.Add(textBoxOutput_SAV);
            groupBoxOutput_SAV.Location = new Point(12, 103);
            groupBoxOutput_SAV.Name = "groupBoxOutput_SAV";
            groupBoxOutput_SAV.Size = new Size(240, 346);
            groupBoxOutput_SAV.TabIndex = 2;
            groupBoxOutput_SAV.TabStop = false;
            groupBoxOutput_SAV.Text = "Вывод данных:";
            // 
            // textBoxOutput_SAV
            // 
            textBoxOutput_SAV.BackColor = SystemColors.Window;
            textBoxOutput_SAV.Location = new Point(6, 22);
            textBoxOutput_SAV.Multiline = true;
            textBoxOutput_SAV.Name = "textBoxOutput_SAV";
            textBoxOutput_SAV.ReadOnly = true;
            textBoxOutput_SAV.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_SAV.Size = new Size(228, 318);
            textBoxOutput_SAV.TabIndex = 7;
            // 
            // buttonStart_SAV
            // 
            buttonStart_SAV.BackColor = Color.Green;
            buttonStart_SAV.Cursor = Cursors.Hand;
            buttonStart_SAV.Location = new Point(686, 31);
            buttonStart_SAV.Name = "buttonStart_SAV";
            buttonStart_SAV.Size = new Size(77, 57);
            buttonStart_SAV.TabIndex = 3;
            buttonStart_SAV.Text = "Выполнить";
            buttonStart_SAV.UseVisualStyleBackColor = false;
            buttonStart_SAV.Click += buttonStart_SAV_Click;
            // 
            // buttonHelp_SAV
            // 
            buttonHelp_SAV.BackColor = SystemColors.MenuHighlight;
            buttonHelp_SAV.Cursor = Cursors.Hand;
            buttonHelp_SAV.Location = new Point(850, 31);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(75, 57);
            buttonHelp_SAV.TabIndex = 4;
            buttonHelp_SAV.Text = "Справка";
            buttonHelp_SAV.UseVisualStyleBackColor = false;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;
            // 
            // buttonSave_SAV
            // 
            buttonSave_SAV.BackColor = SystemColors.HotTrack;
            buttonSave_SAV.Cursor = Cursors.Hand;
            buttonSave_SAV.Location = new Point(769, 31);
            buttonSave_SAV.Name = "buttonSave_SAV";
            buttonSave_SAV.Size = new Size(75, 57);
            buttonSave_SAV.TabIndex = 5;
            buttonSave_SAV.Text = "Сохранить";
            buttonSave_SAV.UseVisualStyleBackColor = false;
            buttonSave_SAV.Click += buttonSave_SAV_Click;
            // 
            // chartDiagram_SAV
            // 
            chartArea1.Name = "ChartArea1";
            chartDiagram_SAV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiagram_SAV.Legends.Add(legend1);
            chartDiagram_SAV.Location = new Point(258, 103);
            chartDiagram_SAV.Name = "chartDiagram_SAV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiagram_SAV.Series.Add(series1);
            chartDiagram_SAV.Size = new Size(664, 346);
            chartDiagram_SAV.TabIndex = 6;
            chartDiagram_SAV.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.Blue;
            title1.Name = "График функции";
            title1.Text = "График функции";
            chartDiagram_SAV.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 461);
            Controls.Add(chartDiagram_SAV);
            Controls.Add(buttonSave_SAV);
            Controls.Add(buttonHelp_SAV);
            Controls.Add(buttonStart_SAV);
            Controls.Add(groupBoxOutput_SAV);
            Controls.Add(groupBoxInput_SAV);
            Controls.Add(groupBoxCondition_SAV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(950, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 26 | Шмелев А. В.";
            groupBoxCondition_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.PerformLayout();
            groupBoxInput_SAV.ResumeLayout(false);
            groupBoxInput_SAV.PerformLayout();
            groupBoxOutput_SAV.ResumeLayout(false);
            groupBoxOutput_SAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagram_SAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_SAV;
        private GroupBox groupBoxInput_SAV;
        private GroupBox groupBoxOutput_SAV;
        private Label labelConditionText_SAV;
        private Label labelStart_SAV;
        private Label labelStop_SAV;
        private TextBox textBoxInputStart_SAV;
        private TextBox textBoxInputStop_SAV;
        private TextBox textBoxOutput_SAV;
        private Button buttonStart_SAV;
        private Button buttonHelp_SAV;
        private Button buttonSave_SAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_SAV;
    }
}
