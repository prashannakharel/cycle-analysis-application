namespace CycleApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHighlight = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnselectedinfo = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnaddprojects = new System.Windows.Forms.Button();
            this.btndataview = new System.Windows.Forms.Button();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedMetric1 = new CycleApplication.AdvancedMetric();
            this.datA_VIEW1 = new CycleApplication.DATA_VIEW();
            this.summary1 = new CycleApplication.summary();
            this.graph1 = new CycleApplication.Graph();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelHighlight);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnselectedinfo);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnaddprojects);
            this.panel1.Controls.Add(this.btndataview);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 774);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panelHighlight
            // 
            this.panelHighlight.BackColor = System.Drawing.Color.ForestGreen;
            this.panelHighlight.Location = new System.Drawing.Point(0, 184);
            this.panelHighlight.Name = "panelHighlight";
            this.panelHighlight.Size = new System.Drawing.Size(10, 53);
            this.panelHighlight.TabIndex = 11;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(32, 470);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 49);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "EXIT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(32, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "INTERVAL DETECTION";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnselectedinfo
            // 
            this.btnselectedinfo.BackColor = System.Drawing.Color.Transparent;
            this.btnselectedinfo.FlatAppearance.BorderSize = 0;
            this.btnselectedinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselectedinfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectedinfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnselectedinfo.Image = ((System.Drawing.Image)(resources.GetObject("btnselectedinfo.Image")));
            this.btnselectedinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnselectedinfo.Location = new System.Drawing.Point(32, 354);
            this.btnselectedinfo.Name = "btnselectedinfo";
            this.btnselectedinfo.Size = new System.Drawing.Size(186, 52);
            this.btnselectedinfo.TabIndex = 7;
            this.btnselectedinfo.Text = "ADVANCED METRIC";
            this.btnselectedinfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnselectedinfo.UseVisualStyleBackColor = false;
            this.btnselectedinfo.Click += new System.EventHandler(this.btnselectedinfo_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(32, 296);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(186, 52);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnaddprojects
            // 
            this.btnaddprojects.BackColor = System.Drawing.Color.Transparent;
            this.btnaddprojects.FlatAppearance.BorderSize = 0;
            this.btnaddprojects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddprojects.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddprojects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddprojects.Image = ((System.Drawing.Image)(resources.GetObject("btnaddprojects.Image")));
            this.btnaddprojects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddprojects.Location = new System.Drawing.Point(32, 238);
            this.btnaddprojects.Name = "btnaddprojects";
            this.btnaddprojects.Size = new System.Drawing.Size(186, 53);
            this.btnaddprojects.TabIndex = 9;
            this.btnaddprojects.Text = "SUMMARY";
            this.btnaddprojects.UseVisualStyleBackColor = false;
            this.btnaddprojects.Click += new System.EventHandler(this.btnaddprojects_Click);
            // 
            // btndataview
            // 
            this.btndataview.BackColor = System.Drawing.Color.Transparent;
            this.btndataview.FlatAppearance.BorderSize = 0;
            this.btndataview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndataview.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndataview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndataview.Image = ((System.Drawing.Image)(resources.GetObject("btndataview.Image")));
            this.btndataview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndataview.Location = new System.Drawing.Point(32, 184);
            this.btndataview.Name = "btndataview";
            this.btndataview.Size = new System.Drawing.Size(186, 53);
            this.btndataview.TabIndex = 10;
            this.btndataview.Text = "VIEW FILE";
            this.btndataview.UseVisualStyleBackColor = false;
            this.btndataview.Click += new System.EventHandler(this.btndataview_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1607, 1);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuImageButton2.TabIndex = 4;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1644, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(873, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "POLAR CYCLE ANALYSIS";
            // 
            // advancedMetric1
            // 
            this.advancedMetric1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.advancedMetric1.Location = new System.Drawing.Point(294, 80);
            this.advancedMetric1.Name = "advancedMetric1";
            this.advancedMetric1.Size = new System.Drawing.Size(1209, 640);
            this.advancedMetric1.TabIndex = 10;
            // 
            // datA_VIEW1
            // 
            this.datA_VIEW1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.datA_VIEW1.Location = new System.Drawing.Point(294, 94);
            this.datA_VIEW1.Name = "datA_VIEW1";
            this.datA_VIEW1.Size = new System.Drawing.Size(1312, 648);
            this.datA_VIEW1.TabIndex = 9;
            // 
            // summary1
            // 
            this.summary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.summary1.Location = new System.Drawing.Point(284, 80);
            this.summary1.Name = "summary1";
            this.summary1.Size = new System.Drawing.Size(1345, 662);
            this.summary1.TabIndex = 8;
            // 
            // graph1
            // 
            this.graph1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.graph1.Location = new System.Drawing.Point(294, 93);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(1375, 635);
            this.graph1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1681, 776);
            this.Controls.Add(this.advancedMetric1);
            this.Controls.Add(this.datA_VIEW1);
            this.Controls.Add(this.summary1);
            this.Controls.Add(this.graph1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHighlight;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnaddprojects;
        private System.Windows.Forms.Button btndataview;
        private summary summary1;
        private Graph graph1;
        private DATA_VIEW datA_VIEW1;
        private System.Windows.Forms.Button btnselectedinfo;
        private AdvancedMetric advancedMetric1;
        private System.Windows.Forms.Button button1;
    }
}

