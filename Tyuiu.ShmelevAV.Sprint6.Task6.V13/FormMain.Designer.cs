namespace Tyuiu.ShmelevAV.Sprint6.Task6.V13
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
            panelUp_SAV = new Panel();
            buttonHelp_SAV = new Button();
            buttonStart_SAV = new Button();
            buttonOpen_SAV = new Button();
            groupBoxCondition_SAV = new GroupBox();
            labelConditionText_SAV = new Label();
            panelLeft_SAV = new Panel();
            groupInput_SAV = new GroupBox();
            textBoxInput_SAV = new TextBox();
            panelRight_SAV = new Panel();
            groupBoxOutput_SAV = new GroupBox();
            textBoxOutput_SAV = new TextBox();
            openFileDialogTask_SAV = new OpenFileDialog();
            toolTipHelp_SAV = new ToolTip(components);
            panelUp_SAV.SuspendLayout();
            groupBoxCondition_SAV.SuspendLayout();
            panelLeft_SAV.SuspendLayout();
            groupInput_SAV.SuspendLayout();
            panelRight_SAV.SuspendLayout();
            groupBoxOutput_SAV.SuspendLayout();
            SuspendLayout();
            // 
            // panelUp_SAV
            // 
            panelUp_SAV.Controls.Add(buttonHelp_SAV);
            panelUp_SAV.Controls.Add(buttonStart_SAV);
            panelUp_SAV.Controls.Add(buttonOpen_SAV);
            panelUp_SAV.Controls.Add(groupBoxCondition_SAV);
            panelUp_SAV.Dock = DockStyle.Top;
            panelUp_SAV.Location = new Point(0, 0);
            panelUp_SAV.Name = "panelUp_SAV";
            panelUp_SAV.Size = new Size(800, 149);
            panelUp_SAV.TabIndex = 0;
            // 
            // buttonHelp_SAV
            // 
            buttonHelp_SAV.Image = Properties.Resources.question__1_;
            buttonHelp_SAV.Location = new Point(740, 3);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(57, 57);
            buttonHelp_SAV.TabIndex = 3;
            toolTipHelp_SAV.SetToolTip(buttonHelp_SAV, "Открывает окно разработчика");
            buttonHelp_SAV.UseVisualStyleBackColor = true;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;
            // 
            // buttonStart_SAV
            // 
            buttonStart_SAV.Enabled = false;
            buttonStart_SAV.Image = Properties.Resources.file__1_;
            buttonStart_SAV.Location = new Point(66, 3);
            buttonStart_SAV.Name = "buttonStart_SAV";
            buttonStart_SAV.Size = new Size(57, 57);
            buttonStart_SAV.TabIndex = 2;
            toolTipHelp_SAV.SetToolTip(buttonStart_SAV, "Выводит предпоследнее слово каждой строки");
            buttonStart_SAV.UseVisualStyleBackColor = true;
            buttonStart_SAV.Click += buttonStart_SAV_Click;
            // 
            // buttonOpen_SAV
            // 
            buttonOpen_SAV.Image = Properties.Resources.folder__1_;
            buttonOpen_SAV.Location = new Point(3, 3);
            buttonOpen_SAV.Name = "buttonOpen_SAV";
            buttonOpen_SAV.Size = new Size(57, 57);
            buttonOpen_SAV.TabIndex = 1;
            toolTipHelp_SAV.SetToolTip(buttonOpen_SAV, "Открыть файл");
            buttonOpen_SAV.UseVisualStyleBackColor = true;
            buttonOpen_SAV.Click += buttonOpen_SAV_Click;
            // 
            // groupBoxCondition_SAV
            // 
            groupBoxCondition_SAV.Controls.Add(labelConditionText_SAV);
            groupBoxCondition_SAV.Location = new Point(3, 65);
            groupBoxCondition_SAV.Name = "groupBoxCondition_SAV";
            groupBoxCondition_SAV.Size = new Size(794, 81);
            groupBoxCondition_SAV.TabIndex = 0;
            groupBoxCondition_SAV.TabStop = false;
            groupBoxCondition_SAV.Text = "Условие:";
            // 
            // labelConditionText_SAV
            // 
            labelConditionText_SAV.AutoSize = true;
            labelConditionText_SAV.Location = new Point(6, 19);
            labelConditionText_SAV.Name = "labelConditionText_SAV";
            labelConditionText_SAV.Size = new Size(560, 45);
            labelConditionText_SAV.TabIndex = 0;
            labelConditionText_SAV.Text = resources.GetString("labelConditionText_SAV.Text");
            // 
            // panelLeft_SAV
            // 
            panelLeft_SAV.Controls.Add(groupInput_SAV);
            panelLeft_SAV.Dock = DockStyle.Left;
            panelLeft_SAV.Location = new Point(0, 149);
            panelLeft_SAV.Name = "panelLeft_SAV";
            panelLeft_SAV.Size = new Size(394, 346);
            panelLeft_SAV.TabIndex = 1;
            // 
            // groupInput_SAV
            // 
            groupInput_SAV.Controls.Add(textBoxInput_SAV);
            groupInput_SAV.Dock = DockStyle.Fill;
            groupInput_SAV.Location = new Point(0, 0);
            groupInput_SAV.Name = "groupInput_SAV";
            groupInput_SAV.Size = new Size(394, 346);
            groupInput_SAV.TabIndex = 0;
            groupInput_SAV.TabStop = false;
            groupInput_SAV.Text = "Ввод:";
            // 
            // textBoxInput_SAV
            // 
            textBoxInput_SAV.Dock = DockStyle.Fill;
            textBoxInput_SAV.Location = new Point(3, 19);
            textBoxInput_SAV.Multiline = true;
            textBoxInput_SAV.Name = "textBoxInput_SAV";
            textBoxInput_SAV.ScrollBars = ScrollBars.Vertical;
            textBoxInput_SAV.Size = new Size(388, 324);
            textBoxInput_SAV.TabIndex = 0;
            // 
            // panelRight_SAV
            // 
            panelRight_SAV.Controls.Add(groupBoxOutput_SAV);
            panelRight_SAV.Dock = DockStyle.Fill;
            panelRight_SAV.Location = new Point(394, 149);
            panelRight_SAV.Name = "panelRight_SAV";
            panelRight_SAV.Size = new Size(406, 346);
            panelRight_SAV.TabIndex = 2;
            // 
            // groupBoxOutput_SAV
            // 
            groupBoxOutput_SAV.Controls.Add(textBoxOutput_SAV);
            groupBoxOutput_SAV.Dock = DockStyle.Fill;
            groupBoxOutput_SAV.Location = new Point(0, 0);
            groupBoxOutput_SAV.Name = "groupBoxOutput_SAV";
            groupBoxOutput_SAV.Size = new Size(406, 346);
            groupBoxOutput_SAV.TabIndex = 0;
            groupBoxOutput_SAV.TabStop = false;
            groupBoxOutput_SAV.Text = "Вывод:";
            // 
            // textBoxOutput_SAV
            // 
            textBoxOutput_SAV.Dock = DockStyle.Fill;
            textBoxOutput_SAV.Location = new Point(3, 19);
            textBoxOutput_SAV.Multiline = true;
            textBoxOutput_SAV.Name = "textBoxOutput_SAV";
            textBoxOutput_SAV.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_SAV.Size = new Size(400, 324);
            textBoxOutput_SAV.TabIndex = 0;
            // 
            // openFileDialogTask_SAV
            // 
            openFileDialogTask_SAV.FileName = "openFileDialog1";
            // 
            // toolTipHelp_SAV
            // 
            toolTipHelp_SAV.ToolTipIcon = ToolTipIcon.Info;
            toolTipHelp_SAV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(panelRight_SAV);
            Controls.Add(panelLeft_SAV);
            Controls.Add(panelUp_SAV);
            MinimumSize = new Size(816, 534);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 13 | Шмелев А. В.";
            panelUp_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.ResumeLayout(false);
            groupBoxCondition_SAV.PerformLayout();
            panelLeft_SAV.ResumeLayout(false);
            groupInput_SAV.ResumeLayout(false);
            groupInput_SAV.PerformLayout();
            panelRight_SAV.ResumeLayout(false);
            groupBoxOutput_SAV.ResumeLayout(false);
            groupBoxOutput_SAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_SAV;
        private GroupBox groupBoxCondition_SAV;
        private Panel panelLeft_SAV;
        private Panel panelRight_SAV;
        private Label labelConditionText_SAV;
        private GroupBox groupInput_SAV;
        private TextBox textBoxInput_SAV;
        private GroupBox groupBoxOutput_SAV;
        private TextBox textBoxOutput_SAV;
        private Button buttonHelp_SAV;
        private Button buttonStart_SAV;
        private Button buttonOpen_SAV;
        private OpenFileDialog openFileDialogTask_SAV;
        private ToolTip toolTipHelp_SAV;
    }
}
