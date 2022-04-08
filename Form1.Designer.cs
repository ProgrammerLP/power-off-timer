namespace PowerOff_Timer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_h = new System.Windows.Forms.TextBox();
            this.TB_min = new System.Windows.Forms.TextBox();
            this.TB_sec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_sp = new System.Windows.Forms.RadioButton();
            this.RB_rs = new System.Windows.Forms.RadioButton();
            this.RB_sd = new System.Windows.Forms.RadioButton();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_timer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(7, 53);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(49, 13);
            this.lbl_timer.TabIndex = 0;
            this.lbl_timer.Text = "00:00:00";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(22, 156);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 48);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(134, 156);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 48);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_h);
            this.groupBox2.Controls.Add(this.TB_min);
            this.groupBox2.Controls.Add(this.TB_sec);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(235, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Timer";
            // 
            // TB_h
            // 
            this.TB_h.Location = new System.Drawing.Point(79, 39);
            this.TB_h.Name = "TB_h";
            this.TB_h.Size = new System.Drawing.Size(100, 20);
            this.TB_h.TabIndex = 5;
            // 
            // TB_min
            // 
            this.TB_min.Location = new System.Drawing.Point(79, 88);
            this.TB_min.Name = "TB_min";
            this.TB_min.Size = new System.Drawing.Size(100, 20);
            this.TB_min.TabIndex = 4;
            // 
            // TB_sec
            // 
            this.TB_sec.Location = new System.Drawing.Point(79, 141);
            this.TB_sec.Name = "TB_sec";
            this.TB_sec.Size = new System.Drawing.Size(100, 20);
            this.TB_sec.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_sp);
            this.groupBox3.Controls.Add(this.RB_rs);
            this.groupBox3.Controls.Add(this.RB_sd);
            this.groupBox3.Location = new System.Drawing.Point(443, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 192);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // RB_sp
            // 
            this.RB_sp.AutoSize = true;
            this.RB_sp.Location = new System.Drawing.Point(25, 144);
            this.RB_sp.Name = "RB_sp";
            this.RB_sp.Size = new System.Drawing.Size(83, 17);
            this.RB_sp.TabIndex = 2;
            this.RB_sp.Text = "Save Power";
            this.RB_sp.UseVisualStyleBackColor = true;
            // 
            // RB_rs
            // 
            this.RB_rs.AutoSize = true;
            this.RB_rs.Location = new System.Drawing.Point(25, 91);
            this.RB_rs.Name = "RB_rs";
            this.RB_rs.Size = new System.Drawing.Size(59, 17);
            this.RB_rs.TabIndex = 1;
            this.RB_rs.Text = "Restart";
            this.RB_rs.UseVisualStyleBackColor = true;
            // 
            // RB_sd
            // 
            this.RB_sd.AutoSize = true;
            this.RB_sd.Checked = true;
            this.RB_sd.Location = new System.Drawing.Point(25, 42);
            this.RB_sd.Name = "RB_sd";
            this.RB_sd.Size = new System.Drawing.Size(73, 17);
            this.RB_sd.TabIndex = 0;
            this.RB_sd.TabStop = true;
            this.RB_sd.Text = "Shutdown";
            this.RB_sd.UseVisualStyleBackColor = true;
            // 
            // t1
            // 
            this.t1.Interval = 1000;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 229);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shutdown Timer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_h;
        private System.Windows.Forms.TextBox TB_min;
        private System.Windows.Forms.TextBox TB_sec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RB_sp;
        private System.Windows.Forms.RadioButton RB_rs;
        private System.Windows.Forms.RadioButton RB_sd;
        private System.Windows.Forms.Timer t1;
    }
}

