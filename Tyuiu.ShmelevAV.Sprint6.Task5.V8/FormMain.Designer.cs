namespace Tyuiu.ShmelevAV.Sprint6.Task5.V8
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
            panelUp_SAV = new Panel();
            buttonHelp_SAV = new Button();
            buttonOpen_SAV = new Button();
            buttonStart_SAV = new Button();
            groupBoxCondition_SAV = new GroupBox();
            labelConditionText_SAV = new Label();
            panelLeft_SAV = new Panel();
            groupBoxOutput_SAV = new GroupBox();
            dataGridViewOutput_SAV = new DataGridView();
            splitterSplit_SAV = new Splitter();
            panelFill_SAV = new Panel();
            chartDiagram_SAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUp_SAV.SuspendLayout();
            groupBoxCondition_SAV.SuspendLayout();
            panelLeft_SAV.SuspendLayout();
            groupBoxOutput_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_SAV).BeginInit();
            panelFill_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagram_SAV).BeginInit();
            SuspendLayout();
            // 
            // panelUp_SAV
            // 
            panelUp_SAV.BackColor = SystemColors.Control;
            panelUp_SAV.Controls.Add(buttonHelp_SAV);
            panelUp_SAV.Controls.Add(buttonOpen_SAV);
            panelUp_SAV.Controls.Add(buttonStart_SAV);
            panelUp_SAV.Controls.Add(groupBoxCondition_SAV);
            panelUp_SAV.Dock = DockStyle.Top;
            panelUp_SAV.Location = new Point(0, 0);
            panelUp_SAV.Name = "panelUp_SAV";
            panelUp_SAV.Size = new Size(800, 100);
            panelUp_SAV.TabIndex = 0;
            // 
            // buttonHelp_SAV
            // 
            buttonHelp_SAV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SAV.BackColor = SystemColors.Highlight;
            buttonHelp_SAV.Location = new Point(711, 22);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(77, 57);
            buttonHelp_SAV.TabIndex = 3;
            buttonHelp_SAV.Text = "Справка";
            buttonHelp_SAV.UseVisualStyleBackColor = false;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;
            // 
            // buttonOpen_SAV
            // 
            buttonOpen_SAV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_SAV.BackColor = SystemColors.HotTrack;
            buttonOpen_SAV.Location = new Point(628, 22);
            buttonOpen_SAV.Name = "buttonOpen_SAV";
            buttonOpen_SAV.Size = new Size(77, 57);
            buttonOpen_SAV.TabIndex = 2;
            buttonOpen_SAV.Text = "Открыть файл";
            buttonOpen_SAV.UseVisualStyleBackColor = false;
            buttonOpen_SAV.Click += buttonOpen_SAV_Click;
            // 
            // buttonStart_SAV
            // 
            buttonStart_SAV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonStart_SAV.BackColor = Color.Green;
            buttonStart_SAV.Location = new Point(545, 22);
            buttonStart_SAV.Name = "buttonStart_SAV";
            buttonStart_SAV.Size = new Size(77, 57);
            buttonStart_SAV.TabIndex = 1;
            buttonStart_SAV.Text = "Выполнить";
            buttonStart_SAV.UseVisualStyleBackColor = false;
            buttonStart_SAV.Click += buttonStart_SAV_Click;
            // 
            // groupBoxCondition_SAV
            // 
            groupBoxCondition_SAV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCondition_SAV.Controls.Add(labelConditionText_SAV);
            groupBoxCondition_SAV.Location = new Point(12, 12);
            groupBoxCondition_SAV.Name = "groupBoxCondition_SAV";
            groupBoxCondition_SAV.Size = new Size(527, 82);
            groupBoxCondition_SAV.TabIndex = 0;
            groupBoxCondition_SAV.TabStop = false;
            groupBoxCondition_SAV.Text = "Условие:";
            // 
            // labelConditionText_SAV
            // 
            labelConditionText_SAV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelConditionText_SAV.AutoSize = true;
            labelConditionText_SAV.Location = new Point(6, 19);
            labelConditionText_SAV.Name = "labelConditionText_SAV";
            labelConditionText_SAV.Size = new Size(404, 30);
            labelConditionText_SAV.TabIndex = 0;
            labelConditionText_SAV.Text = "Прочитать данные из файла InPutFileTask5V8.txt. Вывести в dataGridView\r\nвсе числа, меньше 0. Построить диаграмму по этим значениям.";
            // 
            // panelLeft_SAV
            // 
            panelLeft_SAV.BackColor = SystemColors.Control;
            panelLeft_SAV.Controls.Add(groupBoxOutput_SAV);
            panelLeft_SAV.Dock = DockStyle.Left;
            panelLeft_SAV.Location = new Point(0, 100);
            panelLeft_SAV.Name = "panelLeft_SAV";
            panelLeft_SAV.Size = new Size(139, 350);
            panelLeft_SAV.TabIndex = 1;
            // 
            // groupBoxOutput_SAV
            // 
            groupBoxOutput_SAV.Controls.Add(dataGridViewOutput_SAV);
            groupBoxOutput_SAV.Dock = DockStyle.Fill;
            groupBoxOutput_SAV.Location = new Point(0, 0);
            groupBoxOutput_SAV.Name = "groupBoxOutput_SAV";
            groupBoxOutput_SAV.Size = new Size(139, 350);
            groupBoxOutput_SAV.TabIndex = 1;
            groupBoxOutput_SAV.TabStop = false;
            groupBoxOutput_SAV.Text = "Вывод данных:";
            // 
            // dataGridViewOutput_SAV
            // 
            dataGridViewOutput_SAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_SAV.ColumnHeadersVisible = false;
            dataGridViewOutput_SAV.Dock = DockStyle.Fill;
            dataGridViewOutput_SAV.Location = new Point(3, 19);
            dataGridViewOutput_SAV.Name = "dataGridViewOutput_SAV";
            dataGridViewOutput_SAV.RowHeadersVisible = false;
            dataGridViewOutput_SAV.Size = new Size(133, 328);
            dataGridViewOutput_SAV.TabIndex = 1;
            // 
            // splitterSplit_SAV
            // 
            splitterSplit_SAV.Location = new Point(139, 100);
            splitterSplit_SAV.Name = "splitterSplit_SAV";
            splitterSplit_SAV.Size = new Size(8, 350);
            splitterSplit_SAV.TabIndex = 2;
            splitterSplit_SAV.TabStop = false;
            // 
            // panelFill_SAV
            // 
            panelFill_SAV.Controls.Add(chartDiagram_SAV);
            panelFill_SAV.Dock = DockStyle.Fill;
            panelFill_SAV.Location = new Point(147, 100);
            panelFill_SAV.Name = "panelFill_SAV";
            panelFill_SAV.Size = new Size(653, 350);
            panelFill_SAV.TabIndex = 3;
            // 
            // chartDiagram_SAV
            // 
            chartArea1.Name = "ChartArea1";
            chartDiagram_SAV.ChartAreas.Add(chartArea1);
            chartDiagram_SAV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiagram_SAV.Legends.Add(legend1);
            chartDiagram_SAV.Location = new Point(0, 0);
            chartDiagram_SAV.Name = "chartDiagram_SAV";
            chartDiagram_SAV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiagram_SAV.Series.Add(series1);
            chartDiagram_SAV.Size = new Size(653, 350);
            chartDiagram_SAV.TabIndex = 0;
            chartDiagram_SAV.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill_SAV);
            Controls.Add(splitterSplit_SAV);
            Controls.Add(panelLeft_SAV);
            Controls.Add(panelUp_SAV);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 8 | Шмелев А. В.";
            panelUp_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.PerformLayout();
            panelLeft_SAV.ResumeLayout(false);
            groupBoxOutput_SAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_SAV).EndInit();
            panelFill_SAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiagram_SAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_SAV;
        private Panel panelLeft_SAV;
        private GroupBox groupBoxOutput_SAV;
        private DataGridView dataGridViewOutput_SAV;
        private Splitter splitterSplit_SAV;
        private Panel panelFill_SAV;
        private GroupBox groupBoxCondition_SAV;
        private Label labelConditionText_SAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_SAV;
        private Button buttonHelp_SAV;
        private Button buttonOpen_SAV;
        private Button buttonStart_SAV;
    }
}
