namespace Lab_1_3_1_stopwatch
{
    /// <summary>
    /// Реализует программный секундомер в виде окна WinForms
    /// </summary>
    partial class Stopwatch4Win
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
            this.startButton = new System.Windows.Forms.Button();
            this.mainCounter_label = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopwatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStopwatch4WinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textCounter_label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightGreen;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(11, 329);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(85, 45);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // mainCounter_label
            // 
            this.mainCounter_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainCounter_label.AutoSize = true;
            this.mainCounter_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainCounter_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainCounter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainCounter_label.Location = new System.Drawing.Point(32, 64);
            this.mainCounter_label.Name = "mainCounter_label";
            this.mainCounter_label.Size = new System.Drawing.Size(148, 31);
            this.mainCounter_label.TabIndex = 1;
            this.mainCounter_label.Text = "00:00:00:00\r\n";
            this.mainCounter_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.Color.Coral;
            this.finishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.finishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.finishButton.Location = new System.Drawing.Point(112, 329);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(85, 45);
            this.finishButton.TabIndex = 0;
            this.finishButton.Text = "Stop";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(234, 22);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(234, 22);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopwatchToolStripMenuItem,
            this.timeConverterToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // stopwatchToolStripMenuItem
            // 
            this.stopwatchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.stopwatchToolStripMenuItem.Name = "stopwatchToolStripMenuItem";
            this.stopwatchToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.stopwatchToolStripMenuItem.Text = "Stopwatch";
            this.stopwatchToolStripMenuItem.Click += new System.EventHandler(this.stopwatchToolStripMenuItem_Click);
            // 
            // timeConverterToolStripMenuItem
            // 
            this.timeConverterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.timeConverterToolStripMenuItem.Name = "timeConverterToolStripMenuItem";
            this.timeConverterToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.timeConverterToolStripMenuItem.Text = "Time converter";
            this.timeConverterToolStripMenuItem.Click += new System.EventHandler(this.timeConverterToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentToolStripMenuItem,
            this.aboutStopwatch4WinToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpContentToolStripMenuItem
            // 
            this.helpContentToolStripMenuItem.Name = "helpContentToolStripMenuItem";
            this.helpContentToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.helpContentToolStripMenuItem.Text = "Help contents";
            // 
            // aboutStopwatch4WinToolStripMenuItem
            // 
            this.aboutStopwatch4WinToolStripMenuItem.Name = "aboutStopwatch4WinToolStripMenuItem";
            this.aboutStopwatch4WinToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aboutStopwatch4WinToolStripMenuItem.Text = "About Stopwatch4Win...";
            // 
            // textCounter_label
            // 
            this.textCounter_label.AutoSize = true;
            this.textCounter_label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textCounter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCounter_label.Location = new System.Drawing.Point(26, 42);
            this.textCounter_label.Name = "textCounter_label";
            this.textCounter_label.Padding = new System.Windows.Forms.Padding(12, 0, 22, 3);
            this.textCounter_label.Size = new System.Drawing.Size(168, 21);
            this.textCounter_label.TabIndex = 4;
            this.textCounter_label.Text = "HH : MM : SS  : FF";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 150);
            this.listBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pick up time format to convert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Set value to convert";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 100;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(12, 108);
            this.comboBox1.MaxDropDownItems = 7;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 153);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(189, 179);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Stopwatch4Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(209, 386);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textCounter_label);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.mainCounter_label);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(225, 425);
            this.MinimumSize = new System.Drawing.Size(225, 425);
            this.Name = "Stopwatch4Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch4Win";
            this.Load += new System.EventHandler(this.Stopwatch4Win_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label mainCounter_label;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopwatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStopwatch4WinToolStripMenuItem;
        private System.Windows.Forms.Label textCounter_label;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
    }
}