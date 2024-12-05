namespace Tyuiu.ShmelevAV.Sprint6.Task2.V20
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_SAV = new GroupBox();
            labelConditionText_SAV = new Label();
            groupBoxInput_SAV = new GroupBox();
            textBoxInputStop_SAV = new TextBox();
            labelStart_SAV = new Label();
            textBoxInputStart_SAV = new TextBox();
            labelStop_SAV = new Label();
            groupBoxOutput_SAV = new GroupBox();
            chartDiagram_SAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewTable_SAV = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            labelResult_SAV = new Label();
            buttonHelp_SAV = new Button();
            buttonStart_SAV = new Button();
            groupBoxCondition_SAV.SuspendLayout();
            groupBoxInput_SAV.SuspendLayout();
            groupBoxOutput_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagram_SAV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_SAV).BeginInit();
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
            labelConditionText_SAV.Size = new Size(359, 30);
            labelConditionText_SAV.TabIndex = 0;
            labelConditionText_SAV.Text = "Протабулировать функцию на заданном диапазоне. \r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInput_SAV
            // 
            groupBoxInput_SAV.Controls.Add(textBoxInputStop_SAV);
            groupBoxInput_SAV.Controls.Add(labelStart_SAV);
            groupBoxInput_SAV.Controls.Add(textBoxInputStart_SAV);
            groupBoxInput_SAV.Controls.Add(labelStop_SAV);
            groupBoxInput_SAV.Location = new Point(12, 272);
            groupBoxInput_SAV.Name = "groupBoxInput_SAV";
            groupBoxInput_SAV.Size = new Size(216, 97);
            groupBoxInput_SAV.TabIndex = 1;
            groupBoxInput_SAV.TabStop = false;
            groupBoxInput_SAV.Text = "Ввод данных";
            // 
            // textBoxInputStop_SAV
            // 
            textBoxInputStop_SAV.Location = new Point(112, 52);
            textBoxInputStop_SAV.Name = "textBoxInputStop_SAV";
            textBoxInputStop_SAV.Size = new Size(100, 23);
            textBoxInputStop_SAV.TabIndex = 0;
            textBoxInputStop_SAV.Text = "5";
            // 
            // labelStart_SAV
            // 
            labelStart_SAV.AutoSize = true;
            labelStart_SAV.Location = new Point(6, 34);
            labelStart_SAV.Name = "labelStart_SAV";
            labelStart_SAV.Size = new Size(72, 15);
            labelStart_SAV.TabIndex = 0;
            labelStart_SAV.Text = "Старт шага:";
            // 
            // textBoxInputStart_SAV
            // 
            textBoxInputStart_SAV.Location = new Point(6, 52);
            textBoxInputStart_SAV.Name = "textBoxInputStart_SAV";
            textBoxInputStart_SAV.Size = new Size(100, 23);
            textBoxInputStart_SAV.TabIndex = 0;
            textBoxInputStart_SAV.Text = "-5";
            // 
            // labelStop_SAV
            // 
            labelStop_SAV.AutoSize = true;
            labelStop_SAV.Location = new Point(112, 34);
            labelStop_SAV.Name = "labelStop_SAV";
            labelStop_SAV.Size = new Size(75, 15);
            labelStop_SAV.TabIndex = 1;
            labelStop_SAV.Text = "Конец шага:";
            // 
            // groupBoxOutput_SAV
            // 
            groupBoxOutput_SAV.Controls.Add(chartDiagram_SAV);
            groupBoxOutput_SAV.Controls.Add(dataGridViewTable_SAV);
            groupBoxOutput_SAV.Controls.Add(labelResult_SAV);
            groupBoxOutput_SAV.Location = new Point(436, 12);
            groupBoxOutput_SAV.Name = "groupBoxOutput_SAV";
            groupBoxOutput_SAV.Size = new Size(536, 357);
            groupBoxOutput_SAV.TabIndex = 2;
            groupBoxOutput_SAV.TabStop = false;
            groupBoxOutput_SAV.Text = "Вывод данных";
            // 
            // chartDiagram_SAV
            // 
            chartArea2.Name = "ChartArea1";
            chartDiagram_SAV.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartDiagram_SAV.Legends.Add(legend2);
            chartDiagram_SAV.Location = new Point(115, 39);
            chartDiagram_SAV.Name = "chartDiagram_SAV";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartDiagram_SAV.Series.Add(series2);
            chartDiagram_SAV.Size = new Size(415, 312);
            chartDiagram_SAV.TabIndex = 4;
            chartDiagram_SAV.Text = "chart1";
            // 
            // dataGridViewTable_SAV
            // 
            dataGridViewTable_SAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_SAV.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewTable_SAV.Location = new Point(6, 39);
            dataGridViewTable_SAV.Name = "dataGridViewTable_SAV";
            dataGridViewTable_SAV.RowHeadersVisible = false;
            dataGridViewTable_SAV.Size = new Size(103, 312);
            dataGridViewTable_SAV.TabIndex = 3;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // labelResult_SAV
            // 
            labelResult_SAV.AutoSize = true;
            labelResult_SAV.Location = new Point(6, 21);
            labelResult_SAV.Name = "labelResult_SAV";
            labelResult_SAV.Size = new Size(63, 15);
            labelResult_SAV.TabIndex = 2;
            labelResult_SAV.Text = "Результат:";
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
            buttonStart_SAV.MouseDown += buttonStart_SAV_MouseDown;
            buttonStart_SAV.MouseEnter += buttonStart_SAV_MouseEnter;
            buttonStart_SAV.MouseLeave += buttonStart_SAV_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 381);
            Controls.Add(buttonStart_SAV);
            Controls.Add(buttonHelp_SAV);
            Controls.Add(groupBoxOutput_SAV);
            Controls.Add(groupBoxInput_SAV);
            Controls.Add(groupBoxCondition_SAV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 20 | Шмелев А. В.";
            groupBoxCondition_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.PerformLayout();
            groupBoxInput_SAV.ResumeLayout(false);
            groupBoxInput_SAV.PerformLayout();
            groupBoxOutput_SAV.ResumeLayout(false);
            groupBoxOutput_SAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagram_SAV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_SAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_SAV;
        private GroupBox groupBoxInput_SAV;
        private GroupBox groupBoxOutput_SAV;
        private Label labelConditionText_SAV;
        private Label labelResult_SAV;
        private Label labelStop_SAV;
        private Label labelStart_SAV;
        private TextBox textBoxInputStop_SAV;
        private TextBox textBoxInputStart_SAV;
        private Button buttonHelp_SAV;
        private Button buttonStart_SAV;
        private DataGridView dataGridViewTable_SAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_SAV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
