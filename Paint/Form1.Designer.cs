﻿
namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.aboutProgramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btcRect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.UpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.UpDownY = new System.Windows.Forms.NumericUpDown();
            this.UpDownX = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblLeftUpDot = new System.Windows.Forms.Label();
            this.btnBrushColor = new System.Windows.Forms.Button();
            this.btnPenColor = new System.Windows.Forms.Button();
            this.penWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPenWidth = new System.Windows.Forms.Label();
            this.clrDlgPen = new System.Windows.Forms.ColorDialog();
            this.clrDlgBrush = new System.Windows.Forms.ColorDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Location = new System.Drawing.Point(81, 1);
            this.picBox1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(1006, 566);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            this.picBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox1_MouseDown);
            this.picBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox1_MouseMove);
            this.picBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.nToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redoToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFigureToolStripMenuItem,
            this.aboutProgramToolStripMenuItem,
            this.aboutProgramToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // addFigureToolStripMenuItem
            // 
            this.addFigureToolStripMenuItem.Name = "addFigureToolStripMenuItem";
            this.addFigureToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addFigureToolStripMenuItem.Text = "Add figure";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(153, 6);
            // 
            // aboutProgramToolStripMenuItem1
            // 
            this.aboutProgramToolStripMenuItem1.Name = "aboutProgramToolStripMenuItem1";
            this.aboutProgramToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.aboutProgramToolStripMenuItem1.Text = "About program";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btcRect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 565);
            this.panel1.TabIndex = 3;
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(4, 58);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(70, 40);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btcRect
            // 
            this.btcRect.Location = new System.Drawing.Point(4, 12);
            this.btcRect.Name = "btcRect";
            this.btcRect.Size = new System.Drawing.Size(70, 40);
            this.btcRect.TabIndex = 0;
            this.btcRect.Text = "Rectangle";
            this.btcRect.UseVisualStyleBackColor = true;
            this.btcRect.Click += new System.EventHandler(this.btcRect_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnBrushColor);
            this.panel2.Controls.Add(this.btnPenColor);
            this.panel2.Controls.Add(this.penWidth);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblPenWidth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 72);
            this.panel2.TabIndex = 4;
            // 
            // UpDownHeight
            // 
            this.UpDownHeight.Location = new System.Drawing.Point(264, 36);
            this.UpDownHeight.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.UpDownHeight.Name = "UpDownHeight";
            this.UpDownHeight.Size = new System.Drawing.Size(68, 20);
            this.UpDownHeight.TabIndex = 20;
            this.UpDownHeight.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // UpDownWidth
            // 
            this.UpDownWidth.Location = new System.Drawing.Point(264, 9);
            this.UpDownWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.UpDownWidth.Name = "UpDownWidth";
            this.UpDownWidth.Size = new System.Drawing.Size(68, 20);
            this.UpDownWidth.TabIndex = 19;
            this.UpDownWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeight.Location = new System.Drawing.Point(212, 36);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 17);
            this.lblHeight.TabIndex = 18;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWidth.Location = new System.Drawing.Point(214, 12);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 17);
            this.lblWidth.TabIndex = 17;
            this.lblWidth.Text = "Width";
            // 
            // UpDownY
            // 
            this.UpDownY.Location = new System.Drawing.Point(128, 37);
            this.UpDownY.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.UpDownY.Name = "UpDownY";
            this.UpDownY.Size = new System.Drawing.Size(68, 20);
            this.UpDownY.TabIndex = 16;
            this.UpDownY.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // UpDownX
            // 
            this.UpDownX.Location = new System.Drawing.Point(32, 36);
            this.UpDownX.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.UpDownX.Name = "UpDownX";
            this.UpDownX.Size = new System.Drawing.Size(68, 20);
            this.UpDownX.TabIndex = 15;
            this.UpDownX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY.Location = new System.Drawing.Point(110, 37);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 17);
            this.lblY.TabIndex = 14;
            this.lblY.Text = "Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.Location = new System.Drawing.Point(12, 37);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 13;
            this.lblX.Text = "X";
            // 
            // lblLeftUpDot
            // 
            this.lblLeftUpDot.AutoSize = true;
            this.lblLeftUpDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLeftUpDot.Location = new System.Drawing.Point(74, 12);
            this.lblLeftUpDot.Name = "lblLeftUpDot";
            this.lblLeftUpDot.Size = new System.Drawing.Size(78, 17);
            this.lblLeftUpDot.TabIndex = 12;
            this.lblLeftUpDot.Text = "Left Up dot";
            // 
            // btnBrushColor
            // 
            this.btnBrushColor.BackColor = System.Drawing.Color.Black;
            this.btnBrushColor.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBrushColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrushColor.Location = new System.Drawing.Point(280, 34);
            this.btnBrushColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrushColor.Name = "btnBrushColor";
            this.btnBrushColor.Size = new System.Drawing.Size(23, 23);
            this.btnBrushColor.TabIndex = 11;
            this.btnBrushColor.UseVisualStyleBackColor = false;
            this.btnBrushColor.Click += new System.EventHandler(this.btnBrushColor_Click);
            // 
            // btnPenColor
            // 
            this.btnPenColor.BackColor = System.Drawing.Color.Red;
            this.btnPenColor.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPenColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenColor.Location = new System.Drawing.Point(280, 8);
            this.btnPenColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(23, 23);
            this.btnPenColor.TabIndex = 10;
            this.btnPenColor.UseVisualStyleBackColor = false;
            this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
            // 
            // penWidth
            // 
            this.penWidth.Location = new System.Drawing.Point(138, 36);
            this.penWidth.Name = "penWidth";
            this.penWidth.Size = new System.Drawing.Size(48, 20);
            this.penWidth.TabIndex = 9;
            this.penWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(192, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Brush Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(204, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pen Color";
            // 
            // lblPenWidth
            // 
            this.lblPenWidth.AutoSize = true;
            this.lblPenWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPenWidth.Location = new System.Drawing.Point(59, 37);
            this.lblPenWidth.Name = "lblPenWidth";
            this.lblPenWidth.Size = new System.Drawing.Size(73, 17);
            this.lblPenWidth.TabIndex = 6;
            this.lblPenWidth.Text = "Pen Width";
            // 
            // clrDlgPen
            // 
            this.clrDlgPen.Color = System.Drawing.Color.Red;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.picBox1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panel3.Size = new System.Drawing.Size(1088, 568);
            this.panel3.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(359, 9);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 49);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.UpDownX);
            this.panel4.Controls.Add(this.btnCreate);
            this.panel4.Controls.Add(this.lblLeftUpDot);
            this.panel4.Controls.Add(this.UpDownHeight);
            this.panel4.Controls.Add(this.lblX);
            this.panel4.Controls.Add(this.UpDownWidth);
            this.panel4.Controls.Add(this.lblY);
            this.panel4.Controls.Add(this.lblHeight);
            this.panel4.Controls.Add(this.UpDownY);
            this.panel4.Controls.Add(this.lblWidth);
            this.panel4.Location = new System.Drawing.Point(643, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(444, 72);
            this.panel4.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btcRect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPenWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown penWidth;
        private System.Windows.Forms.ColorDialog clrDlgPen;
        private System.Windows.Forms.Button btnPenColor;
        private System.Windows.Forms.Button btnBrushColor;
        private System.Windows.Forms.ColorDialog clrDlgBrush;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem1;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblLeftUpDot;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown UpDownY;
        private System.Windows.Forms.NumericUpDown UpDownX;
        private System.Windows.Forms.NumericUpDown UpDownHeight;
        private System.Windows.Forms.NumericUpDown UpDownWidth;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel4;
    }
}

