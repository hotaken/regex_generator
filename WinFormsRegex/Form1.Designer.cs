using System.Windows.Forms;
namespace WinFormsRegex
{
    public partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvExamples = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьРазметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРазметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разметкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разметитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericCountEpochs = new System.Windows.Forms.NumericUpDown();
            this.numericCountPopulation = new System.Windows.Forms.NumericUpDown();
            this.numericCountElitism = new System.Windows.Forms.NumericUpDown();
            this.numericCountRandom = new System.Windows.Forms.NumericUpDown();
            this.btnStartAlgo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarAlgo = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRegularExpression = new System.Windows.Forms.Label();
            this.labelFscore = new System.Windows.Forms.Label();
            this.labelPrecision = new System.Windows.Forms.Label();
            this.labelEpoch = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьДокументToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРазметкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.разметкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.разметитьДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьРазметкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamples)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountElitism)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountRandom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvExamples);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные примеров";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvExamples
            // 
            this.dgvExamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExamples.Location = new System.Drawing.Point(3, 27);
            this.dgvExamples.Name = "dgvExamples";
            this.dgvExamples.RowTemplate.Height = 25;
            this.dgvExamples.Size = new System.Drawing.Size(524, 420);
            this.dgvExamples.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.разметкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.открытьРазметкуToolStripMenuItem,
            this.сохранитьРазметкуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // открытьРазметкуToolStripMenuItem
            // 
            this.открытьРазметкуToolStripMenuItem.Name = "открытьРазметкуToolStripMenuItem";
            this.открытьРазметкуToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.открытьРазметкуToolStripMenuItem.Text = "Открыть разметку (JSON)";
            this.открытьРазметкуToolStripMenuItem.Click += new System.EventHandler(this.открытьРазметкуToolStripMenuItem_Click);
            // 
            // сохранитьРазметкуToolStripMenuItem
            // 
            this.сохранитьРазметкуToolStripMenuItem.Name = "сохранитьРазметкуToolStripMenuItem";
            this.сохранитьРазметкуToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.сохранитьРазметкуToolStripMenuItem.Text = "Сохранить разметку";
            this.сохранитьРазметкуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРазметкуToolStripMenuItem_Click);
            // 
            // разметкаToolStripMenuItem
            // 
            this.разметкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разметитьToolStripMenuItem});
            this.разметкаToolStripMenuItem.Name = "разметкаToolStripMenuItem";
            this.разметкаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.разметкаToolStripMenuItem.Text = "Разметка";
            // 
            // разметитьToolStripMenuItem
            // 
            this.разметитьToolStripMenuItem.Name = "разметитьToolStripMenuItem";
            this.разметитьToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.разметитьToolStripMenuItem.Text = "Разметить/Убрать разметку (Ctrl+B)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генерация регулярного выражения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генетический алгоритм";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericCountEpochs, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericCountPopulation, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericCountElitism, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericCountRandom, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnStartAlgo, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 197);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 39);
            this.label7.TabIndex = 6;
            this.label7.Text = "Количество особей для рандома";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество особей для элитизма";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Размер популяции";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество поколений";
            // 
            // numericCountEpochs
            // 
            this.numericCountEpochs.Location = new System.Drawing.Point(217, 3);
            this.numericCountEpochs.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericCountEpochs.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericCountEpochs.Name = "numericCountEpochs";
            this.numericCountEpochs.Size = new System.Drawing.Size(103, 20);
            this.numericCountEpochs.TabIndex = 7;
            this.numericCountEpochs.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericCountPopulation
            // 
            this.numericCountPopulation.Location = new System.Drawing.Point(217, 42);
            this.numericCountPopulation.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericCountPopulation.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericCountPopulation.Name = "numericCountPopulation";
            this.numericCountPopulation.Size = new System.Drawing.Size(103, 20);
            this.numericCountPopulation.TabIndex = 7;
            this.numericCountPopulation.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericCountElitism
            // 
            this.numericCountElitism.Location = new System.Drawing.Point(217, 81);
            this.numericCountElitism.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericCountElitism.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCountElitism.Name = "numericCountElitism";
            this.numericCountElitism.Size = new System.Drawing.Size(103, 20);
            this.numericCountElitism.TabIndex = 7;
            this.numericCountElitism.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericCountRandom
            // 
            this.numericCountRandom.Location = new System.Drawing.Point(217, 120);
            this.numericCountRandom.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericCountRandom.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCountRandom.Name = "numericCountRandom";
            this.numericCountRandom.Size = new System.Drawing.Size(103, 20);
            this.numericCountRandom.TabIndex = 7;
            this.numericCountRandom.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnStartAlgo
            // 
            this.btnStartAlgo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartAlgo.AutoSize = true;
            this.btnStartAlgo.Location = new System.Drawing.Point(217, 159);
            this.btnStartAlgo.Name = "btnStartAlgo";
            this.btnStartAlgo.Size = new System.Drawing.Size(147, 35);
            this.btnStartAlgo.TabIndex = 8;
            this.btnStartAlgo.Text = "Начать обучение";
            this.btnStartAlgo.UseVisualStyleBackColor = true;
            this.btnStartAlgo.Click += new System.EventHandler(this.btnStartAlgo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Прогресс обучения";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.progressBarAlgo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(512, 197);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // progressBarAlgo
            // 
            this.progressBarAlgo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarAlgo.Location = new System.Drawing.Point(142, 3);
            this.progressBarAlgo.Name = "progressBarAlgo";
            this.progressBarAlgo.Size = new System.Drawing.Size(227, 34);
            this.progressBarAlgo.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelRegularExpression, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.labelFscore, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelPrecision, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelEpoch, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(506, 151);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // labelRegularExpression
            // 
            this.labelRegularExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRegularExpression.Location = new System.Drawing.Point(132, 111);
            this.labelRegularExpression.Name = "labelRegularExpression";
            this.labelRegularExpression.Size = new System.Drawing.Size(371, 40);
            this.labelRegularExpression.TabIndex = 17;
            this.labelRegularExpression.Text = "0";
            // 
            // labelFscore
            // 
            this.labelFscore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFscore.Location = new System.Drawing.Point(132, 74);
            this.labelFscore.Name = "labelFscore";
            this.labelFscore.Size = new System.Drawing.Size(371, 37);
            this.labelFscore.TabIndex = 16;
            this.labelFscore.Text = "0";
            // 
            // labelPrecision
            // 
            this.labelPrecision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrecision.Location = new System.Drawing.Point(132, 37);
            this.labelPrecision.Name = "labelPrecision";
            this.labelPrecision.Size = new System.Drawing.Size(371, 37);
            this.labelPrecision.TabIndex = 15;
            this.labelPrecision.Text = "0";
            // 
            // labelEpoch
            // 
            this.labelEpoch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEpoch.Location = new System.Drawing.Point(132, 0);
            this.labelEpoch.Name = "labelEpoch";
            this.labelEpoch.Size = new System.Drawing.Size(371, 37);
            this.labelEpoch.TabIndex = 14;
            this.labelEpoch.Text = "0";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 40);
            this.label11.TabIndex = 13;
            this.label11.Text = "Регулярное выражение";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "F-score";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Точность";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поколение";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel5);
            this.tabPage3.Controls.Add(this.menuStrip2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(530, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Извлечение данных";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dgvTest, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(530, 426);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.0566F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.9434F));
            this.tableLayoutPanel6.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBoxRegex, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(524, 43);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 43);
            this.label13.TabIndex = 0;
            this.label13.Text = "Регулярное выражение";
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRegex.Location = new System.Drawing.Point(129, 3);
            this.textBoxRegex.Multiline = true;
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(392, 37);
            this.textBoxRegex.TabIndex = 1;
            // 
            // dgvTest
            // 
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTest.Location = new System.Drawing.Point(3, 52);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.RowTemplate.Height = 25;
            this.dgvTest.Size = new System.Drawing.Size(524, 371);
            this.dgvTest.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.разметкаToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(530, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьДокументToolStripMenuItem1,
            this.сохранитьРазметкуToolStripMenuItem1,
            this.открытьРазметкуToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // открытьДокументToolStripMenuItem1
            // 
            this.открытьДокументToolStripMenuItem1.Name = "открытьДокументToolStripMenuItem1";
            this.открытьДокументToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.открытьДокументToolStripMenuItem1.Text = "Открыть документ";
            this.открытьДокументToolStripMenuItem1.Click += new System.EventHandler(this.открытьДокументToolStripMenuItem1_Click);
            // 
            // сохранитьРазметкуToolStripMenuItem1
            // 
            this.сохранитьРазметкуToolStripMenuItem1.Name = "сохранитьРазметкуToolStripMenuItem1";
            this.сохранитьРазметкуToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.сохранитьРазметкуToolStripMenuItem1.Text = "Сохранить разметку";
            this.сохранитьРазметкуToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьРазметкуToolStripMenuItem1_Click);
            // 
            // разметкаToolStripMenuItem1
            // 
            this.разметкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разметитьДокументToolStripMenuItem});
            this.разметкаToolStripMenuItem1.Name = "разметкаToolStripMenuItem1";
            this.разметкаToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.разметкаToolStripMenuItem1.Text = "Разметка";
            // 
            // разметитьДокументToolStripMenuItem
            // 
            this.разметитьДокументToolStripMenuItem.Name = "разметитьДокументToolStripMenuItem";
            this.разметитьДокументToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.разметитьДокументToolStripMenuItem.Text = "Разметить документ по регулярному выражению";
            this.разметитьДокументToolStripMenuItem.Click += new System.EventHandler(this.разметитьДокументToolStripMenuItem_Click);
            // 
            // открытьРазметкуToolStripMenuItem1
            // 
            this.открытьРазметкуToolStripMenuItem1.Name = "открытьРазметкуToolStripMenuItem1";
            this.открытьРазметкуToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.открытьРазметкуToolStripMenuItem1.Text = "Открыть разметку";
            this.открытьРазметкуToolStripMenuItem1.Click += new System.EventHandler(this.открытьРазметкуToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 476);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Инструмент автоматического извлечения данных из текста";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamples)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountElitism)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountRandom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        public DataGridView dgvExamples;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem открытьРазметкуToolStripMenuItem;
        private ToolStripMenuItem сохранитьРазметкуToolStripMenuItem;
        private ToolStripMenuItem разметкаToolStripMenuItem;
        private ToolStripMenuItem разметитьToolStripMenuItem;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label1;
        private NumericUpDown numericCountEpochs;
        private NumericUpDown numericCountPopulation;
        private NumericUpDown numericCountElitism;
        private NumericUpDown numericCountRandom;
        private Button btnStartAlgo;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private ProgressBar progressBarAlgo;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label11;
        private Label label9;
        private Label label6;
        private Label label2;
        private Label labelRegularExpression;
        private Label labelFscore;
        private Label labelPrecision;
        private Label labelEpoch;
        private TabPage tabPage3;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private ToolStripMenuItem открытьДокументToolStripMenuItem1;
        private ToolStripMenuItem сохранитьРазметкуToolStripMenuItem1;
        private ToolStripMenuItem разметкаToolStripMenuItem1;
        private ToolStripMenuItem разметитьДокументToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label13;
        private TextBox textBoxRegex;
        private DataGridView dgvTest;
        private ToolStripMenuItem открытьРазметкуToolStripMenuItem1;
    }
}