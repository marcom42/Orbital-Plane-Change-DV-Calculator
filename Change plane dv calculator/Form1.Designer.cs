namespace Change_plane_dv_calculator
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnResetDefault = new System.Windows.Forms.Button();
            this.cboxSel = new System.Windows.Forms.ComboBox();
            this.numRInc = new System.Windows.Forms.NumericUpDown();
            this.numPeA = new System.Windows.Forms.NumericUpDown();
            this.numApA = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt = new System.Windows.Forms.RichTextBox();
            this.txtdVApA = new System.Windows.Forms.TextBox();
            this.txtdVPeA = new System.Windows.Forms.TextBox();
            this.txtApAVel = new System.Windows.Forms.TextBox();
            this.txtPeAVel = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPrecRes = new System.Windows.Forms.ToolStripMenuItem();
            this.hicontrastModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cboxTopMost = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRInc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numApA)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select planet or moon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "RInc";
            this.toolTip1.SetToolTip(this.label2, "Relative Inclination");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periapsis (km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apoapsis (km)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Periapsis Velocity (m/s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apoapsis Velocity (m/s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "∆v to align plane at PeA";
            this.toolTip1.SetToolTip(this.label7, "∆v cost to align the plane at periapsis");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "∆v to align plane at ApA";
            this.toolTip1.SetToolTip(this.label8, "∆v cost to align the plane at apoapsis");
            // 
            // btnResetDefault
            // 
            this.btnResetDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDefault.Location = new System.Drawing.Point(12, 312);
            this.btnResetDefault.Name = "btnResetDefault";
            this.btnResetDefault.Size = new System.Drawing.Size(168, 23);
            this.btnResetDefault.TabIndex = 16;
            this.btnResetDefault.Text = "Reset to default values";
            this.btnResetDefault.UseVisualStyleBackColor = true;
            this.btnResetDefault.Click += new System.EventHandler(this.BtnResetDefault_Click);
            // 
            // cboxSel
            // 
            this.cboxSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSel.FormattingEnabled = true;
            this.cboxSel.Items.AddRange(new object[] {
            "Earth",
            "Mercury",
            "Venus",
            "Moon",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune"});
            this.cboxSel.Location = new System.Drawing.Point(195, 28);
            this.cboxSel.Name = "cboxSel";
            this.cboxSel.Size = new System.Drawing.Size(120, 26);
            this.cboxSel.TabIndex = 17;
            this.cboxSel.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            this.cboxSel.SelectedValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // numRInc
            // 
            this.numRInc.DecimalPlaces = 3;
            this.numRInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRInc.Location = new System.Drawing.Point(195, 61);
            this.numRInc.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numRInc.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numRInc.Name = "numRInc";
            this.numRInc.Size = new System.Drawing.Size(120, 24);
            this.numRInc.TabIndex = 18;
            this.numRInc.ThousandsSeparator = true;
            this.numRInc.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // numPeA
            // 
            this.numPeA.DecimalPlaces = 3;
            this.numPeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPeA.Location = new System.Drawing.Point(195, 92);
            this.numPeA.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPeA.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numPeA.Name = "numPeA";
            this.numPeA.Size = new System.Drawing.Size(120, 24);
            this.numPeA.TabIndex = 19;
            this.numPeA.ThousandsSeparator = true;
            this.numPeA.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // numApA
            // 
            this.numApA.DecimalPlaces = 3;
            this.numApA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numApA.Location = new System.Drawing.Point(195, 123);
            this.numApA.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numApA.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numApA.Name = "numApA";
            this.numApA.Size = new System.Drawing.Size(120, 24);
            this.numApA.TabIndex = 20;
            this.numApA.ThousandsSeparator = true;
            this.numApA.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(334, 21);
            this.txt.Margin = new System.Windows.Forms.Padding(2);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(332, 309);
            this.txt.TabIndex = 25;
            this.txt.Text = "";
            this.txt.Visible = false;
            // 
            // txtdVApA
            // 
            this.txtdVApA.BackColor = System.Drawing.Color.LightCoral;
            this.txtdVApA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdVApA.Location = new System.Drawing.Point(195, 242);
            this.txtdVApA.Name = "txtdVApA";
            this.txtdVApA.ReadOnly = true;
            this.txtdVApA.Size = new System.Drawing.Size(120, 24);
            this.txtdVApA.TabIndex = 26;
            this.txtdVApA.Text = "0";
            // 
            // txtdVPeA
            // 
            this.txtdVPeA.BackColor = System.Drawing.Color.LightCoral;
            this.txtdVPeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdVPeA.Location = new System.Drawing.Point(195, 211);
            this.txtdVPeA.Name = "txtdVPeA";
            this.txtdVPeA.ReadOnly = true;
            this.txtdVPeA.Size = new System.Drawing.Size(120, 24);
            this.txtdVPeA.TabIndex = 27;
            this.txtdVPeA.Text = "0";
            // 
            // txtApAVel
            // 
            this.txtApAVel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtApAVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApAVel.Location = new System.Drawing.Point(195, 180);
            this.txtApAVel.Name = "txtApAVel";
            this.txtApAVel.ReadOnly = true;
            this.txtApAVel.Size = new System.Drawing.Size(120, 24);
            this.txtApAVel.TabIndex = 28;
            this.txtApAVel.Text = "0";
            // 
            // txtPeAVel
            // 
            this.txtPeAVel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPeAVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeAVel.Location = new System.Drawing.Point(195, 149);
            this.txtPeAVel.Name = "txtPeAVel";
            this.txtPeAVel.ReadOnly = true;
            this.txtPeAVel.Size = new System.Drawing.Size(120, 24);
            this.txtPeAVel.TabIndex = 29;
            this.txtPeAVel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPrecRes,
            this.hicontrastModeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolPrecRes
            // 
            this.toolPrecRes.Name = "toolPrecRes";
            this.toolPrecRes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolPrecRes.Size = new System.Drawing.Size(217, 22);
            this.toolPrecRes.Text = "View precise results";
            this.toolPrecRes.Click += new System.EventHandler(this.ToolPrecRes_Click);
            // 
            // hicontrastModeToolStripMenuItem
            // 
            this.hicontrastModeToolStripMenuItem.Name = "hicontrastModeToolStripMenuItem";
            this.hicontrastModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.hicontrastModeToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.hicontrastModeToolStripMenuItem.Text = "Hi-contrast mode";
            this.hicontrastModeToolStripMenuItem.Click += new System.EventHandler(this.HicontrastModeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // cboxTopMost
            // 
            this.cboxTopMost.AutoSize = true;
            this.cboxTopMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTopMost.Location = new System.Drawing.Point(12, 286);
            this.cboxTopMost.Name = "cboxTopMost";
            this.cboxTopMost.Size = new System.Drawing.Size(110, 20);
            this.cboxTopMost.TabIndex = 31;
            this.cboxTopMost.Text = "Always on top";
            this.cboxTopMost.UseVisualStyleBackColor = true;
            this.cboxTopMost.CheckedChanged += new System.EventHandler(this.CboxTopMost_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(332, 345);
            this.Controls.Add(this.cboxTopMost);
            this.Controls.Add(this.txtPeAVel);
            this.Controls.Add(this.txtApAVel);
            this.Controls.Add(this.txtdVPeA);
            this.Controls.Add(this.txtdVApA);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.numApA);
            this.Controls.Add(this.numPeA);
            this.Controls.Add(this.numRInc);
            this.Controls.Add(this.cboxSel);
            this.Controls.Add(this.btnResetDefault);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2000, 384);
            this.MinimumSize = new System.Drawing.Size(348, 384);
            this.Name = "Form1";
            this.Text = "Orbital Plane Change ∆v Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numRInc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numApA)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnResetDefault;
        private System.Windows.Forms.ComboBox cboxSel;
        private System.Windows.Forms.NumericUpDown numRInc;
        private System.Windows.Forms.NumericUpDown numPeA;
        private System.Windows.Forms.NumericUpDown numApA;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.TextBox txtdVApA;
        private System.Windows.Forms.TextBox txtdVPeA;
        private System.Windows.Forms.TextBox txtApAVel;
        private System.Windows.Forms.TextBox txtPeAVel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolPrecRes;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hicontrastModeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox cboxTopMost;
    }
}

