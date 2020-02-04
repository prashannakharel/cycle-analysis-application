namespace CycleApplication
{
    partial class SelectedData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedData));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblavghr = new System.Windows.Forms.Label();
            this.lblmaxpower = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblminhr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblmaxaltitude = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblavgaltitude = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblavgspeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblaveragepower = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmaxhr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmaxspeed = new System.Windows.Forms.Label();
            this.lbltotaldistance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblftp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IF = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tss = new System.Windows.Forms.Label(); 
            this.label13 = new System.Windows.Forms.Label();
            this.lblnormalizedpower = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1127, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 309);
            this.dataGridView1.TabIndex = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DATE TIME";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HEART RATE";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SPEED";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CADENCE";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ALTITUDE";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "POWER";
            this.Column6.Name = "Column6";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 358);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(677, 365);
            this.zedGraphControl1.TabIndex = 61;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(723, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 680);
            this.tabControl1.TabIndex = 62;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tabPage1.Controls.Add(this.lblavghr);
            this.tabPage1.Controls.Add(this.lblmaxpower);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lblminhr);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lblmaxaltitude);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lblavgaltitude);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblavgspeed);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblaveragepower);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblmaxhr);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblmaxspeed);
            this.tabPage1.Controls.Add(this.lbltotaldistance);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SUMMARY DATA";
            // 
            // lblavghr
            // 
            this.lblavghr.AutoSize = true;
            this.lblavghr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavghr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblavghr.Location = new System.Drawing.Point(192, 611);
            this.lblavghr.Name = "lblavghr";
            this.lblavghr.Size = new System.Drawing.Size(0, 21);
            this.lblavghr.TabIndex = 11;
            // 
            // lblmaxpower
            // 
            this.lblmaxpower.AutoSize = true;
            this.lblmaxpower.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxpower.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmaxpower.Location = new System.Drawing.Point(195, 549);
            this.lblmaxpower.Name = "lblmaxpower";
            this.lblmaxpower.Size = new System.Drawing.Size(0, 21);
            this.lblmaxpower.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "AVERAGE HR :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(32, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "MAX POWER :";
            // 
            // lblminhr
            // 
            this.lblminhr.AutoSize = true;
            this.lblminhr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminhr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblminhr.Location = new System.Drawing.Point(195, 488);
            this.lblminhr.Name = "lblminhr";
            this.lblminhr.Size = new System.Drawing.Size(0, 21);
            this.lblminhr.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(32, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "MIN HR :";
            // 
            // lblmaxaltitude
            // 
            this.lblmaxaltitude.AutoSize = true;
            this.lblmaxaltitude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxaltitude.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmaxaltitude.Location = new System.Drawing.Point(195, 418);
            this.lblmaxaltitude.Name = "lblmaxaltitude";
            this.lblmaxaltitude.Size = new System.Drawing.Size(0, 21);
            this.lblmaxaltitude.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(32, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "MAX ALTITUDE";
            // 
            // lblavgaltitude
            // 
            this.lblavgaltitude.AutoSize = true;
            this.lblavgaltitude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavgaltitude.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblavgaltitude.Location = new System.Drawing.Point(192, 351);
            this.lblavgaltitude.Name = "lblavgaltitude";
            this.lblavgaltitude.Size = new System.Drawing.Size(0, 21);
            this.lblavgaltitude.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(29, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "AVEGARE ALTITUDE :";
            // 
            // lblavgspeed
            // 
            this.lblavgspeed.AutoSize = true;
            this.lblavgspeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavgspeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblavgspeed.Location = new System.Drawing.Point(167, 300);
            this.lblavgspeed.Name = "lblavgspeed";
            this.lblavgspeed.Size = new System.Drawing.Size(0, 21);
            this.lblavgspeed.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "AVERAGE SPEED :";
            // 
            // lblaveragepower
            // 
            this.lblaveragepower.AutoSize = true;
            this.lblaveragepower.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaveragepower.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblaveragepower.Location = new System.Drawing.Point(167, 238);
            this.lblaveragepower.Name = "lblaveragepower";
            this.lblaveragepower.Size = new System.Drawing.Size(0, 21);
            this.lblaveragepower.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "AVERAGE POWER :";
            // 
            // lblmaxhr
            // 
            this.lblmaxhr.AutoSize = true;
            this.lblmaxhr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxhr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmaxhr.Location = new System.Drawing.Point(167, 177);
            this.lblmaxhr.Name = "lblmaxhr";
            this.lblmaxhr.Size = new System.Drawing.Size(0, 21);
            this.lblmaxhr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "MAX HR :";
            // 
            // lblmaxspeed
            // 
            this.lblmaxspeed.AutoSize = true;
            this.lblmaxspeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxspeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmaxspeed.Location = new System.Drawing.Point(167, 107);
            this.lblmaxspeed.Name = "lblmaxspeed";
            this.lblmaxspeed.Size = new System.Drawing.Size(0, 21);
            this.lblmaxspeed.TabIndex = 7;
            // 
            // lbltotaldistance
            // 
            this.lbltotaldistance.AutoSize = true;
            this.lbltotaldistance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldistance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltotaldistance.Location = new System.Drawing.Point(164, 40);
            this.lbltotaldistance.Name = "lbltotaldistance";
            this.lbltotaldistance.Size = new System.Drawing.Size(0, 21);
            this.lbltotaldistance.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "MAX SPEED :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(26, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(135, 21);
            this.label.TabIndex = 10;
            this.label.Text = "TOTAL DISTANCE :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tabPage2.Controls.Add(this.lblftp);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.IF);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tss);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.lblnormalizedpower);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADVANCED METRICS";
            // 
            // lblftp
            // 
            this.lblftp.AutoSize = true;
            this.lblftp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblftp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblftp.Location = new System.Drawing.Point(292, 227);
            this.lblftp.Name = "lblftp";
            this.lblftp.Size = new System.Drawing.Size(52, 21);
            this.lblftp.TabIndex = 12;
            this.lblftp.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(24, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 21);
            this.label11.TabIndex = 13;
            this.label11.Text = "FUNCTIONAL THRESHOLD";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IF
            // 
            this.IF.AutoSize = true;
            this.IF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IF.Location = new System.Drawing.Point(292, 162);
            this.IF.Name = "IF";
            this.IF.Size = new System.Drawing.Size(52, 21);
            this.IF.TabIndex = 14;
            this.IF.Text = "label1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(24, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "INTENSITY FACTOR (IF)";
            // 
            // tss
            // 
            this.tss.AutoSize = true;
            this.tss.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tss.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tss.Location = new System.Drawing.Point(292, 106);
            this.tss.Name = "tss";
            this.tss.Size = new System.Drawing.Size(52, 21);
            this.tss.TabIndex = 16;
            this.tss.Text = "label1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(24, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "TOTAL STRESS SCORE (TSS)";
            // 
            // lblnormalizedpower
            // 
            this.lblnormalizedpower.AutoSize = true;
            this.lblnormalizedpower.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnormalizedpower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnormalizedpower.Location = new System.Drawing.Point(292, 57);
            this.lblnormalizedpower.Name = "lblnormalizedpower";
            this.lblnormalizedpower.Size = new System.Drawing.Size(52, 21);
            this.lblnormalizedpower.TabIndex = 18;
            this.lblnormalizedpower.Text = "label1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(24, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 21);
            this.label14.TabIndex = 19;
            this.label14.Text = "NORMALIZED POWER";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SelectedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1161, 735);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectedData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectedData";
            this.Load += new System.EventHandler(this.SelectedData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblavgspeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblaveragepower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmaxhr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmaxspeed;
        private System.Windows.Forms.Label lbltotaldistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblavghr;
        private System.Windows.Forms.Label lblmaxpower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblminhr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblmaxaltitude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblavgaltitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblftp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label IF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label tss;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblnormalizedpower;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}