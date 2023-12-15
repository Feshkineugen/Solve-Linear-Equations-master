namespace  Iterative
{
    partial class MainForm
    {
      
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Код, сгенерированный разработчиком форм



        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxbLog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txbOmega = new System.Windows.Forms.TextBox();
            this.labOmega = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.txbEpsilon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIterativeTimes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxbLog);
            this.groupBox1.Location = new System.Drawing.Point(5, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 242);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rtxbLog
            // 
            this.rtxbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxbLog.Location = new System.Drawing.Point(3, 16);
            this.rtxbLog.Name = "rtxbLog";
            this.rtxbLog.ReadOnly = true;
            this.rtxbLog.Size = new System.Drawing.Size(577, 223);
            this.rtxbLog.TabIndex = 2;
            this.rtxbLog.Text = "";
            this.rtxbLog.TextChanged += new System.EventHandler(this.rtxbLog_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "          ︾          ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOutput);
            this.groupBox3.Controls.Add(this.txbOutput);
            this.groupBox3.Location = new System.Drawing.Point(308, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 62);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выход";
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOutput.Location = new System.Drawing.Point(241, 21);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(27, 24);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "...";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(6, 22);
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.ReadOnly = true;
            this.txbOutput.Size = new System.Drawing.Size(230, 20);
            this.txbOutput.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbOmega);
            this.groupBox4.Controls.Add(this.labOmega);
            this.groupBox4.Controls.Add(this.btnCalc);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cmbMethod);
            this.groupBox4.Controls.Add(this.txbEpsilon);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txbIterativeTimes);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(14, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 117);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Значения";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txbOmega
            // 
            this.txbOmega.Enabled = false;
            this.txbOmega.Location = new System.Drawing.Point(425, 55);
            this.txbOmega.Name = "txbOmega";
            this.txbOmega.Size = new System.Drawing.Size(81, 20);
            this.txbOmega.TabIndex = 8;
            this.txbOmega.Text = "1";
            this.txbOmega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbOmega_KeyPress);
            // 
            // labOmega
            // 
            this.labOmega.AutoSize = true;
            this.labOmega.Enabled = false;
            this.labOmega.Location = new System.Drawing.Point(256, 56);
            this.labOmega.Name = "labOmega";
            this.labOmega.Size = new System.Drawing.Size(163, 13);
            this.labOmega.TabIndex = 7;
            this.labOmega.Text = "Коэффициент релаксации (ω)：";
            this.labOmega.Click += new System.EventHandler(this.labOmega_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(483, 86);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 25);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Решить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Итерационный метод：";
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbMethod.Location = new System.Drawing.Point(445, 28);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(104, 21);
            this.cmbMethod.TabIndex = 4;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
            // 
            // txbEpsilon
            // 
            this.txbEpsilon.Location = new System.Drawing.Point(167, 55);
            this.txbEpsilon.Name = "txbEpsilon";
            this.txbEpsilon.Size = new System.Drawing.Size(81, 20);
            this.txbEpsilon.TabIndex = 3;
            this.txbEpsilon.Text = "0.0001";
            this.txbEpsilon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEpsilon_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Коэффицент сходимости (ε)：";
            // 
            // txbIterativeTimes
            // 
            this.txbIterativeTimes.Location = new System.Drawing.Point(213, 32);
            this.txbIterativeTimes.Name = "txbIterativeTimes";
            this.txbIterativeTimes.Size = new System.Drawing.Size(81, 20);
            this.txbIterativeTimes.TabIndex = 1;
            this.txbIterativeTimes.Text = "1000";
            this.txbIterativeTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIterativeTimes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Максимальное количество итераций：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInput);
            this.groupBox2.Controls.Add(this.txbInput);
            this.groupBox2.Location = new System.Drawing.Point(14, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 62);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод";
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInput.Location = new System.Drawing.Point(241, 21);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(27, 24);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "...";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(6, 22);
            this.txbInput.Name = "txbInput";
            this.txbInput.ReadOnly = true;
            this.txbInput.Size = new System.Drawing.Size(230, 20);
            this.txbInput.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenInputToolStripMenuItem,
            this.OpenOutputToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // OpenInputToolStripMenuItem
            // 
            this.OpenInputToolStripMenuItem.Name = "OpenInputToolStripMenuItem";
            this.OpenInputToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.OpenInputToolStripMenuItem.Text = "Открытый ввод ";
            this.OpenInputToolStripMenuItem.Click += new System.EventHandler(this.OpenInputToolStripMenuItem_Click);
            // 
            // OpenOutputToolStripMenuItem
            // 
            this.OpenOutputToolStripMenuItem.Name = "OpenOutputToolStripMenuItem";
            this.OpenOutputToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.OpenOutputToolStripMenuItem.Text = "Открытый выход ";
            this.OpenOutputToolStripMenuItem.Click += new System.EventHandler(this.OpenOutputToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ExitToolStripMenuItem.Text = "Выход из приложения";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение системы  уравнений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.TextBox txbEpsilon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIterativeTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txbOmega;
        private System.Windows.Forms.Label labOmega;
        private System.Windows.Forms.RichTextBox rtxbLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;


    }
}

