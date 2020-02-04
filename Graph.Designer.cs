namespace CycleApplication
{
    partial class Graph
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.btnload = new System.Windows.Forms.Button();
            this.checkBoxPower = new System.Windows.Forms.CheckBox();
            this.checkBoxAltitude = new System.Windows.Forms.CheckBox();
            this.checkBoxCadence = new System.Windows.Forms.CheckBox();
            this.checkBoxSpeed = new System.Windows.Forms.CheckBox();
            this.checkBoxHR = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(974, 573);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(1005, 3);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(96, 45);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "LOAD";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // checkBoxPower
            // 
            this.checkBoxPower.AutoSize = true;
            this.checkBoxPower.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxPower.Location = new System.Drawing.Point(1005, 271);
            this.checkBoxPower.Name = "checkBoxPower";
            this.checkBoxPower.Size = new System.Drawing.Size(68, 24);
            this.checkBoxPower.TabIndex = 55;
            this.checkBoxPower.Text = "Power";
            this.checkBoxPower.UseVisualStyleBackColor = true;
            this.checkBoxPower.CheckedChanged += new System.EventHandler(this.checkBoxPower_CheckedChanged);
            // 
            // checkBoxAltitude
            // 
            this.checkBoxAltitude.AutoSize = true;
            this.checkBoxAltitude.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAltitude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxAltitude.Location = new System.Drawing.Point(1005, 219);
            this.checkBoxAltitude.Name = "checkBoxAltitude";
            this.checkBoxAltitude.Size = new System.Drawing.Size(81, 24);
            this.checkBoxAltitude.TabIndex = 54;
            this.checkBoxAltitude.Text = "Altitude";
            this.checkBoxAltitude.UseVisualStyleBackColor = true;
            this.checkBoxAltitude.CheckedChanged += new System.EventHandler(this.checkBoxAltitude_CheckedChanged);
            // 
            // checkBoxCadence
            // 
            this.checkBoxCadence.AutoSize = true;
            this.checkBoxCadence.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCadence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxCadence.Location = new System.Drawing.Point(1005, 179);
            this.checkBoxCadence.Name = "checkBoxCadence";
            this.checkBoxCadence.Size = new System.Drawing.Size(85, 24);
            this.checkBoxCadence.TabIndex = 53;
            this.checkBoxCadence.Text = "Cadence";
            this.checkBoxCadence.UseVisualStyleBackColor = true;
            this.checkBoxCadence.CheckedChanged += new System.EventHandler(this.checkBoxCadence_CheckedChanged);
            // 
            // checkBoxSpeed
            // 
            this.checkBoxSpeed.AutoSize = true;
            this.checkBoxSpeed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxSpeed.Location = new System.Drawing.Point(1005, 136);
            this.checkBoxSpeed.Name = "checkBoxSpeed";
            this.checkBoxSpeed.Size = new System.Drawing.Size(70, 24);
            this.checkBoxSpeed.TabIndex = 52;
            this.checkBoxSpeed.Text = "Speed";
            this.checkBoxSpeed.UseVisualStyleBackColor = true;
            this.checkBoxSpeed.CheckedChanged += new System.EventHandler(this.checkBoxSpeed_CheckedChanged);
            // 
            // checkBoxHR
            // 
            this.checkBoxHR.AutoSize = true;
            this.checkBoxHR.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxHR.Location = new System.Drawing.Point(1005, 93);
            this.checkBoxHR.Name = "checkBoxHR";
            this.checkBoxHR.Size = new System.Drawing.Size(99, 24);
            this.checkBoxHR.TabIndex = 51;
            this.checkBoxHR.Text = "Heart Rate";
            this.checkBoxHR.UseVisualStyleBackColor = true;
            this.checkBoxHR.CheckedChanged += new System.EventHandler(this.checkBoxHR_CheckedChanged);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.checkBoxPower);
            this.Controls.Add(this.checkBoxAltitude);
            this.Controls.Add(this.checkBoxCadence);
            this.Controls.Add(this.checkBoxSpeed);
            this.Controls.Add(this.checkBoxHR);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Graph";
            this.Size = new System.Drawing.Size(1122, 596);
            this.Load += new System.EventHandler(this.Graph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.CheckBox checkBoxPower;
        private System.Windows.Forms.CheckBox checkBoxAltitude;
        private System.Windows.Forms.CheckBox checkBoxCadence;
        private System.Windows.Forms.CheckBox checkBoxSpeed;
        private System.Windows.Forms.CheckBox checkBoxHR;
    }
}
