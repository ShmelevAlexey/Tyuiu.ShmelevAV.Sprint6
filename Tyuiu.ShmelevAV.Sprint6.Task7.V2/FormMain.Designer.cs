namespace Tyuiu.ShmelevAV.Sprint6.Task7.V2
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
            panelTopOne_SAV = new Panel();
            buttonHelp_SAV = new Button();
            buttonSave_SAV = new Button();
            buttonStart_SAV = new Button();
            buttonOpen_SAV = new Button();
            dataGridViewOutput_SAV = new DataGridView();
            panelTopTwo_SAV = new Panel();
            groupBoxCondition_SAV = new GroupBox();
            labelConditionText_SAV = new Label();
            panelLeft_SAV = new Panel();
            groupInput_SAV = new GroupBox();
            dataGridViewInput_SAV = new DataGridView();
            panelRight_SAV = new Panel();
            groupBoxOutput_SAV = new GroupBox();
            splitter1 = new Splitter();
            openFileDialogTask_SAV = new OpenFileDialog();
            toolTipButton_SAV = new ToolTip(components);
            saveFileDialogMatrix_SAV = new SaveFileDialog();
            panelTopOne_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_SAV).BeginInit();
            panelTopTwo_SAV.SuspendLayout();
            groupBoxCondition_SAV.SuspendLayout();
            panelLeft_SAV.SuspendLayout();
            groupInput_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_SAV).BeginInit();
            panelRight_SAV.SuspendLayout();
            groupBoxOutput_SAV.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopOne_SAV
            // 
            panelTopOne_SAV.Controls.Add(buttonHelp_SAV);
            panelTopOne_SAV.Controls.Add(buttonSave_SAV);
            panelTopOne_SAV.Controls.Add(buttonStart_SAV);
            panelTopOne_SAV.Controls.Add(buttonOpen_SAV);
            panelTopOne_SAV.Dock = DockStyle.Top;
            panelTopOne_SAV.Location = new Point(0, 0);
            panelTopOne_SAV.Name = "panelTopOne_SAV";
            panelTopOne_SAV.Size = new Size(800, 100);
            panelTopOne_SAV.TabIndex = 0;
            // 
            // buttonHelp_SAV
            // 
            buttonHelp_SAV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SAV.FlatStyle = FlatStyle.Flat;
            buttonHelp_SAV.Image = Properties.Resources.help;
            buttonHelp_SAV.Location = new Point(731, 22);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(57, 57);
            buttonHelp_SAV.TabIndex = 3;
            toolTipButton_SAV.SetToolTip(buttonHelp_SAV, "Сведение о программе");
            buttonHelp_SAV.UseVisualStyleBackColor = true;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;
            buttonHelp_SAV.MouseEnter += buttonHelp_SAV_MouseEnter;
            // 
            // buttonSave_SAV
            // 
            buttonSave_SAV.FlatStyle = FlatStyle.Flat;
            buttonSave_SAV.Image = Properties.Resources.page_save;
            buttonSave_SAV.Location = new Point(138, 22);
            buttonSave_SAV.Name = "buttonSave_SAV";
            buttonSave_SAV.Size = new Size(57, 57);
            buttonSave_SAV.TabIndex = 2;
            toolTipButton_SAV.SetToolTip(buttonSave_SAV, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_SAV.UseVisualStyleBackColor = true;
            buttonSave_SAV.Click += buttonSave_SAV_Click;
            buttonSave_SAV.MouseEnter += buttonSave_SAV_MouseEnter;
            // 
            // buttonStart_SAV
            // 
            buttonStart_SAV.FlatStyle = FlatStyle.Flat;
            buttonStart_SAV.Image = Properties.Resources.page_white_go;
            buttonStart_SAV.Location = new Point(75, 22);
            buttonStart_SAV.Name = "buttonStart_SAV";
            buttonStart_SAV.Size = new Size(57, 57);
            buttonStart_SAV.TabIndex = 1;
            toolTipButton_SAV.SetToolTip(buttonStart_SAV, "Выполнить обработку данных");
            buttonStart_SAV.UseVisualStyleBackColor = true;
            buttonStart_SAV.Click += buttonStart_SAV_Click;
            buttonStart_SAV.MouseEnter += buttonStart_SAV_MouseEnter;
            // 
            // buttonOpen_SAV
            // 
            buttonOpen_SAV.FlatStyle = FlatStyle.Flat;
            buttonOpen_SAV.Image = Properties.Resources.folder_page;
            buttonOpen_SAV.Location = new Point(12, 22);
            buttonOpen_SAV.Name = "buttonOpen_SAV";
            buttonOpen_SAV.Size = new Size(57, 57);
            buttonOpen_SAV.TabIndex = 0;
            toolTipButton_SAV.SetToolTip(buttonOpen_SAV, "Открыть файл для обработки данных в формате CSV");
            buttonOpen_SAV.UseVisualStyleBackColor = true;
            buttonOpen_SAV.Click += buttonOpen_SAV_Click;
            buttonOpen_SAV.MouseEnter += buttonOpen_SAV_MouseEnter;
            // 
            // dataGridViewOutput_SAV
            // 
            dataGridViewOutput_SAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_SAV.Dock = DockStyle.Fill;
            dataGridViewOutput_SAV.Location = new Point(3, 19);
            dataGridViewOutput_SAV.Name = "dataGridViewOutput_SAV";
            dataGridViewOutput_SAV.Size = new Size(389, 273);
            dataGridViewOutput_SAV.TabIndex = 0;
            // 
            // panelTopTwo_SAV
            // 
            panelTopTwo_SAV.Controls.Add(groupBoxCondition_SAV);
            panelTopTwo_SAV.Dock = DockStyle.Top;
            panelTopTwo_SAV.Location = new Point(0, 100);
            panelTopTwo_SAV.Name = "panelTopTwo_SAV";
            panelTopTwo_SAV.Size = new Size(800, 100);
            panelTopTwo_SAV.TabIndex = 1;
            // 
            // groupBoxCondition_SAV
            // 
            groupBoxCondition_SAV.Controls.Add(labelConditionText_SAV);
            groupBoxCondition_SAV.Dock = DockStyle.Fill;
            groupBoxCondition_SAV.Location = new Point(0, 0);
            groupBoxCondition_SAV.Name = "groupBoxCondition_SAV";
            groupBoxCondition_SAV.Size = new Size(800, 100);
            groupBoxCondition_SAV.TabIndex = 0;
            groupBoxCondition_SAV.TabStop = false;
            groupBoxCondition_SAV.Text = "Условие:";
            // 
            // labelConditionText_SAV
            // 
            labelConditionText_SAV.AutoSize = true;
            labelConditionText_SAV.Location = new Point(3, 19);
            labelConditionText_SAV.Name = "labelConditionText_SAV";
            labelConditionText_SAV.Size = new Size(486, 75);
            labelConditionText_SAV.TabIndex = 0;
            labelConditionText_SAV.Text = resources.GetString("labelConditionText_SAV.Text");
            // 
            // panelLeft_SAV
            // 
            panelLeft_SAV.Controls.Add(groupInput_SAV);
            panelLeft_SAV.Dock = DockStyle.Left;
            panelLeft_SAV.Location = new Point(0, 200);
            panelLeft_SAV.Name = "panelLeft_SAV";
            panelLeft_SAV.Size = new Size(402, 295);
            panelLeft_SAV.TabIndex = 2;
            // 
            // groupInput_SAV
            // 
            groupInput_SAV.Controls.Add(dataGridViewInput_SAV);
            groupInput_SAV.Dock = DockStyle.Fill;
            groupInput_SAV.Location = new Point(0, 0);
            groupInput_SAV.Name = "groupInput_SAV";
            groupInput_SAV.Size = new Size(402, 295);
            groupInput_SAV.TabIndex = 0;
            groupInput_SAV.TabStop = false;
            groupInput_SAV.Text = "Ввод:";
            // 
            // dataGridViewInput_SAV
            // 
            dataGridViewInput_SAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_SAV.Dock = DockStyle.Fill;
            dataGridViewInput_SAV.Location = new Point(3, 19);
            dataGridViewInput_SAV.Name = "dataGridViewInput_SAV";
            dataGridViewInput_SAV.Size = new Size(396, 273);
            dataGridViewInput_SAV.TabIndex = 0;
            // 
            // panelRight_SAV
            // 
            panelRight_SAV.Controls.Add(groupBoxOutput_SAV);
            panelRight_SAV.Dock = DockStyle.Fill;
            panelRight_SAV.Location = new Point(405, 200);
            panelRight_SAV.Name = "panelRight_SAV";
            panelRight_SAV.Size = new Size(395, 295);
            panelRight_SAV.TabIndex = 3;
            // 
            // groupBoxOutput_SAV
            // 
            groupBoxOutput_SAV.Controls.Add(dataGridViewOutput_SAV);
            groupBoxOutput_SAV.Dock = DockStyle.Fill;
            groupBoxOutput_SAV.Location = new Point(0, 0);
            groupBoxOutput_SAV.Name = "groupBoxOutput_SAV";
            groupBoxOutput_SAV.Size = new Size(395, 295);
            groupBoxOutput_SAV.TabIndex = 0;
            groupBoxOutput_SAV.TabStop = false;
            groupBoxOutput_SAV.Text = "Вывод:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(402, 200);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 295);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_SAV
            // 
            openFileDialogTask_SAV.FileName = "openFileDialog1";
            // 
            // toolTipButton_SAV
            // 
            toolTipButton_SAV.IsBalloon = true;
            toolTipButton_SAV.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_SAV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(panelRight_SAV);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_SAV);
            Controls.Add(panelTopTwo_SAV);
            Controls.Add(panelTopOne_SAV);
            MinimumSize = new Size(816, 534);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 2 | Шмелев А. В.";
            WindowState = FormWindowState.Maximized;
            panelTopOne_SAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_SAV).EndInit();
            panelTopTwo_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.PerformLayout();
            panelLeft_SAV.ResumeLayout(false);
            groupInput_SAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_SAV).EndInit();
            panelRight_SAV.ResumeLayout(false);
            groupBoxOutput_SAV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopOne_SAV;
        private Panel panelTopTwo_SAV;
        private Panel panelLeft_SAV;
        private Panel panelRight_SAV;
        private GroupBox groupBoxCondition_SAV;
        private Label labelConditionText_SAV;
        private GroupBox groupInput_SAV;
        private GroupBox groupBoxOutput_SAV;
        private DataGridView dataGridViewInput_SAV;
        private DataGridView dataGridViewOutput_SAV;
        private Splitter splitter1;
        private Button buttonHelp_SAV;
        private Button buttonSave_SAV;
        private Button buttonStart_SAV;
        private Button buttonOpen_SAV;
        private OpenFileDialog openFileDialogTask_SAV;
        private ToolTip toolTipButton_SAV;
        private SaveFileDialog saveFileDialogMatrix_SAV;
    }
}
