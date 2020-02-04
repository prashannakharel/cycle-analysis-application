namespace CycleApplication
{
    partial class DATA_VIEW
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblvo2max = new System.Windows.Forms.Label();
            this.lblresthr = new System.Windows.Forms.Label();
            this.lblmaxhr = new System.Windows.Forms.Label();
            this.lblinterval = new System.Windows.Forms.Label();
            this.lbllength = new System.Windows.Forms.Label();
            this.lblstarttime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblsmode = new System.Windows.Forms.Label();
            this.lblmonitor = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblspeed = new System.Windows.Forms.Label();
            this.lblcadence = new System.Windows.Forms.Label();
            this.lblaltitude = new System.Windows.Forms.Label();
            this.lblpower = new System.Windows.Forms.Label();
            this.lblpb = new System.Windows.Forms.Label();
            this.lblpi = new System.Windows.Forms.Label();
            this.lblhrcc = new System.Windows.Forms.Label();
            this.lblairpressure = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblus = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lsthrmfiles = new System.Windows.Forms.ListBox();
            this.btnbrowsefolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.Column6,
            this.No,
            this.Interval});
            this.dataGridView1.Location = new System.Drawing.Point(291, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 384);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
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
            // No
            // 
            this.No.HeaderText = "POWER BAL";
            this.No.Name = "No";
            // 
            // Interval
            // 
            this.Interval.HeaderText = "Interval";
            this.Interval.Name = "Interval";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(1076, 517);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(109, 39);
            this.btnbrowse.TabIndex = 58;
            this.btnbrowse.Text = "BROWSE FILE";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(73, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 56;
            this.label11.Text = "Weight :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(73, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 55;
            this.label10.Text = "VO2max :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(73, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "RestHR :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(73, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "MaxHR :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(73, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "Interval :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(73, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Length :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(73, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "StartTime :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(73, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(73, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "SMODE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Monitor :";
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblweight.Location = new System.Drawing.Point(180, 531);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(0, 25);
            this.lblweight.TabIndex = 46;
            // 
            // lblvo2max
            // 
            this.lblvo2max.AutoSize = true;
            this.lblvo2max.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvo2max.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblvo2max.Location = new System.Drawing.Point(180, 481);
            this.lblvo2max.Name = "lblvo2max";
            this.lblvo2max.Size = new System.Drawing.Size(0, 25);
            this.lblvo2max.TabIndex = 45;
            // 
            // lblresthr
            // 
            this.lblresthr.AutoSize = true;
            this.lblresthr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresthr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblresthr.Location = new System.Drawing.Point(180, 433);
            this.lblresthr.Name = "lblresthr";
            this.lblresthr.Size = new System.Drawing.Size(0, 25);
            this.lblresthr.TabIndex = 44;
            // 
            // lblmaxhr
            // 
            this.lblmaxhr.AutoSize = true;
            this.lblmaxhr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxhr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmaxhr.Location = new System.Drawing.Point(180, 384);
            this.lblmaxhr.Name = "lblmaxhr";
            this.lblmaxhr.Size = new System.Drawing.Size(0, 25);
            this.lblmaxhr.TabIndex = 43;
            // 
            // lblinterval
            // 
            this.lblinterval.AutoSize = true;
            this.lblinterval.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinterval.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblinterval.Location = new System.Drawing.Point(180, 338);
            this.lblinterval.Name = "lblinterval";
            this.lblinterval.Size = new System.Drawing.Size(0, 25);
            this.lblinterval.TabIndex = 42;
            // 
            // lbllength
            // 
            this.lbllength.AutoSize = true;
            this.lbllength.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllength.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllength.Location = new System.Drawing.Point(180, 292);
            this.lbllength.Name = "lbllength";
            this.lbllength.Size = new System.Drawing.Size(0, 25);
            this.lbllength.TabIndex = 41;
            // 
            // lblstarttime
            // 
            this.lblstarttime.AutoSize = true;
            this.lblstarttime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstarttime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstarttime.Location = new System.Drawing.Point(180, 247);
            this.lblstarttime.Name = "lblstarttime";
            this.lblstarttime.Size = new System.Drawing.Size(0, 25);
            this.lblstarttime.TabIndex = 40;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldate.Location = new System.Drawing.Point(180, 200);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 25);
            this.lbldate.TabIndex = 39;
            // 
            // lblsmode
            // 
            this.lblsmode.AutoSize = true;
            this.lblsmode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsmode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsmode.Location = new System.Drawing.Point(180, 154);
            this.lblsmode.Name = "lblsmode";
            this.lblsmode.Size = new System.Drawing.Size(0, 25);
            this.lblsmode.TabIndex = 38;
            // 
            // lblmonitor
            // 
            this.lblmonitor.AutoSize = true;
            this.lblmonitor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonitor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmonitor.Location = new System.Drawing.Point(180, 112);
            this.lblmonitor.Name = "lblmonitor";
            this.lblmonitor.Size = new System.Drawing.Size(0, 25);
            this.lblmonitor.TabIndex = 37;
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblversion.Location = new System.Drawing.Point(180, 72);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(0, 25);
            this.lblversion.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(73, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Version :";
            // 
            // lblspeed
            // 
            this.lblspeed.AutoSize = true;
            this.lblspeed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblspeed.Location = new System.Drawing.Point(1204, 82);
            this.lblspeed.Name = "lblspeed";
            this.lblspeed.Size = new System.Drawing.Size(0, 25);
            this.lblspeed.TabIndex = 57;
            // 
            // lblcadence
            // 
            this.lblcadence.AutoSize = true;
            this.lblcadence.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcadence.Location = new System.Drawing.Point(1204, 137);
            this.lblcadence.Name = "lblcadence";
            this.lblcadence.Size = new System.Drawing.Size(0, 25);
            this.lblcadence.TabIndex = 37;
            // 
            // lblaltitude
            // 
            this.lblaltitude.AutoSize = true;
            this.lblaltitude.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltitude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblaltitude.Location = new System.Drawing.Point(1204, 183);
            this.lblaltitude.Name = "lblaltitude";
            this.lblaltitude.Size = new System.Drawing.Size(0, 25);
            this.lblaltitude.TabIndex = 38;
            // 
            // lblpower
            // 
            this.lblpower.AutoSize = true;
            this.lblpower.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpower.Location = new System.Drawing.Point(1204, 232);
            this.lblpower.Name = "lblpower";
            this.lblpower.Size = new System.Drawing.Size(0, 25);
            this.lblpower.TabIndex = 39;
            // 
            // lblpb
            // 
            this.lblpb.AutoSize = true;
            this.lblpb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpb.Location = new System.Drawing.Point(1204, 282);
            this.lblpb.Name = "lblpb";
            this.lblpb.Size = new System.Drawing.Size(0, 25);
            this.lblpb.TabIndex = 40;
            // 
            // lblpi
            // 
            this.lblpi.AutoSize = true;
            this.lblpi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpi.Location = new System.Drawing.Point(1204, 328);
            this.lblpi.Name = "lblpi";
            this.lblpi.Size = new System.Drawing.Size(0, 25);
            this.lblpi.TabIndex = 41;
            // 
            // lblhrcc
            // 
            this.lblhrcc.AutoSize = true;
            this.lblhrcc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblhrcc.Location = new System.Drawing.Point(1204, 376);
            this.lblhrcc.Name = "lblhrcc";
            this.lblhrcc.Size = new System.Drawing.Size(0, 25);
            this.lblhrcc.TabIndex = 42;
            this.lblhrcc.Click += new System.EventHandler(this.label19_Click);
            // 
            // lblairpressure
            // 
            this.lblairpressure.AutoSize = true;
            this.lblairpressure.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblairpressure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblairpressure.Location = new System.Drawing.Point(1204, 481);
            this.lblairpressure.Name = "lblairpressure";
            this.lblairpressure.Size = new System.Drawing.Size(0, 25);
            this.lblairpressure.TabIndex = 43;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label34.Location = new System.Drawing.Point(1088, 33);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(76, 25);
            this.label34.TabIndex = 47;
            this.label34.Text = "SMODE";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label35.Location = new System.Drawing.Point(74, 33);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 25);
            this.label35.TabIndex = 47;
            this.label35.Text = "HEADER";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(1072, 481);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(113, 25);
            this.label24.TabIndex = 68;
            this.label24.Text = "Air Pressure";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(1072, 376);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 25);
            this.label25.TabIndex = 67;
            this.label25.Text = "HR/CC";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Location = new System.Drawing.Point(1072, 423);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 25);
            this.label26.TabIndex = 66;
            this.label26.Text = "US/ Euro";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label27.Location = new System.Drawing.Point(1072, 328);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(115, 25);
            this.label27.TabIndex = 65;
            this.label27.Text = "Power Index";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Location = new System.Drawing.Point(1072, 282);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(135, 25);
            this.label28.TabIndex = 64;
            this.label28.Text = "Power Balance";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label29.Location = new System.Drawing.Point(1072, 232);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 25);
            this.label29.TabIndex = 63;
            this.label29.Text = "Power";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label30.Location = new System.Drawing.Point(1072, 183);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(78, 25);
            this.label30.TabIndex = 62;
            this.label30.Text = "Altitude";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label31.Location = new System.Drawing.Point(1072, 137);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(85, 25);
            this.label31.TabIndex = 61;
            this.label31.Text = "Cadence";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label32.Location = new System.Drawing.Point(1074, 82);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 25);
            this.label32.TabIndex = 60;
            this.label32.Text = "Speed";
            // 
            // lblus
            // 
            this.lblus.AutoSize = true;
            this.lblus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblus.Location = new System.Drawing.Point(1204, 423);
            this.lblus.Name = "lblus";
            this.lblus.Size = new System.Drawing.Size(0, 25);
            this.lblus.TabIndex = 43;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(291, 433);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 69;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lsthrmfiles
            // 
            this.lsthrmfiles.FormattingEnabled = true;
            this.lsthrmfiles.Items.AddRange(new object[] {
            "FILE1 123456\t",
            "FILE2 134566"});
            this.lsthrmfiles.Location = new System.Drawing.Point(761, 433);
            this.lsthrmfiles.Name = "lsthrmfiles";
            this.lsthrmfiles.Size = new System.Drawing.Size(278, 160);
            this.lsthrmfiles.TabIndex = 70;
            this.lsthrmfiles.SelectedIndexChanged += new System.EventHandler(this.lsthrmfiles_SelectedIndexChanged);
            // 
            // btnbrowsefolder
            // 
            this.btnbrowsefolder.Location = new System.Drawing.Point(1076, 562);
            this.btnbrowsefolder.Name = "btnbrowsefolder";
            this.btnbrowsefolder.Size = new System.Drawing.Size(109, 39);
            this.btnbrowsefolder.TabIndex = 58;
            this.btnbrowsefolder.Text = "BROWSE FOLDER";
            this.btnbrowsefolder.UseVisualStyleBackColor = true;
            this.btnbrowsefolder.Click += new System.EventHandler(this.btnbrowsefolder_Click);
            // 
            // DATA_VIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.lsthrmfiles);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbrowsefolder);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.lblvo2max);
            this.Controls.Add(this.lblus);
            this.Controls.Add(this.lblairpressure);
            this.Controls.Add(this.lblresthr);
            this.Controls.Add(this.lblhrcc);
            this.Controls.Add(this.lblmaxhr);
            this.Controls.Add(this.lblpi);
            this.Controls.Add(this.lblinterval);
            this.Controls.Add(this.lblpb);
            this.Controls.Add(this.lbllength);
            this.Controls.Add(this.lblpower);
            this.Controls.Add(this.lblstarttime);
            this.Controls.Add(this.lblaltitude);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblcadence);
            this.Controls.Add(this.lblsmode);
            this.Controls.Add(this.lblspeed);
            this.Controls.Add(this.lblmonitor);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.label2);
            this.Name = "DATA_VIEW";
            this.Size = new System.Drawing.Size(1312, 662);
            this.Load += new System.EventHandler(this.DATA_VIEW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblvo2max;
        private System.Windows.Forms.Label lblresthr;
        private System.Windows.Forms.Label lblmaxhr;
        private System.Windows.Forms.Label lblinterval;
        private System.Windows.Forms.Label lbllength;
        private System.Windows.Forms.Label lblstarttime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblsmode;
        private System.Windows.Forms.Label lblmonitor;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblspeed;
        private System.Windows.Forms.Label lblcadence;
        private System.Windows.Forms.Label lblaltitude;
        private System.Windows.Forms.Label lblpower;
        private System.Windows.Forms.Label lblpb;
        private System.Windows.Forms.Label lblpi;
        private System.Windows.Forms.Label lblhrcc;
        private System.Windows.Forms.Label lblairpressure;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox lsthrmfiles;
        private System.Windows.Forms.Button btnbrowsefolder;
    }
}
