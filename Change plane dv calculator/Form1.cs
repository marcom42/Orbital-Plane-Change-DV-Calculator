using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_plane_dv_calculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes the component and resets all numeric values to default
        /// </summary>
        public Form1() {
            InitializeComponent();
            ResetToDefault();
        }

        private void BtnResetDefault_Click(object sender, EventArgs e) {
            ResetToDefault();
        }

        /// <summary>
        /// Resets to default all numeric values to default values to create an example of usage
        /// </summary>
        private void ResetToDefault() {
            cboxSel.SelectedIndex = 0;
            numRInc.Value = Convert.ToDecimal(9.44);
            numPeA.Value = 200;
            numApA.Value = 200;
            txtPeAVel.Text = "" + 7785;
            txtApAVel.Text = "" + 7785;
            txtdVPeA.Text = "" + 1282;
            txtdVApA.Text = "" + 1282;

            Calculate();
        }

        /// <summary>
        /// Calculates all the values and updates all fields
        /// </summary>
        private void Calculate() {
            double peaVel, apaVel, dvPea, dvApa;

            Calculator calculator = new Calculator();
            calculator.Body = cboxSel.SelectedItem.ToString();

            peaVel = calculator.CalcPeAVelocity((double)numApA.Value, (double)numPeA.Value);
            apaVel = calculator.CalcApAVelocity((double)numApA.Value, (double)numPeA.Value);
            dvPea = calculator.CalcDvPeA((double)numRInc.Value, Convert.ToDouble(txtPeAVel.Text));
            dvApa = calculator.CalcDvApA((double)numRInc.Value, Convert.ToDouble(txtApAVel.Text));

            // Results are converted to Int32 to eliminate decimal places and simplify reading
            txtPeAVel.Text = Convert.ToInt32(peaVel).ToString();
            txtApAVel.Text = Convert.ToInt32(apaVel).ToString();
            txtdVPeA.Text = Convert.ToInt32(dvPea).ToString();
            txtdVApA.Text = Convert.ToInt32(dvApa).ToString();

            // High precision results
            txt.Text = "RInc " + numRInc.Value + "\n";
            txt.Text += "ApA " + numApA.Value + "\nPeA " + numPeA.Value + "\n";
            txt.Text += "PeA Vel " + peaVel + "\n";
            txt.Text += "ApA Vel " + apaVel + "\n";
            txt.Text += "ΔV PeA " + dvPea + "\n";
            txt.Text += "ΔV ApA " + dvApa + "\n";
        }

        private void ValueChanged(object sender, EventArgs e) {
            Calculate();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1 = new SaveFileDialog {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(saveFileDialog1.FileName, txt.Text);
            }
        }

        /// <summary>
        /// Shows and hides the precision result view
        /// </summary>
        private void ToolPrecRes_Click(object sender, EventArgs e) {
            if (!toolPrecRes.Checked) {
                txt.Visible = true;
                this.Size = new Size(662, 384);
                toolPrecRes.Checked = true;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            } else {
                txt.Visible = false;
                this.Size = new Size(348, 384);
                toolPrecRes.Checked = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }

        private void CboxTopMost_CheckedChanged(object sender, EventArgs e) {
            this.TopMost = false;
            if (cboxTopMost.Checked)
                this.TopMost = true;
        }

        /// <summary>
        /// Enables a Hi-Contrast mode for the calculator
        /// </summary>
        private void HiContrast() {
            // Form & precise result view
            this.BackColor = Color.Black;
            this.ForeColor = Color.Green;
            txt.BackColor = Color.MidnightBlue;
            txt.ForeColor = Color.LightGreen;
            // Numeric up downs
            numRInc.BackColor = Color.MidnightBlue;
            numRInc.ForeColor = Color.LightGreen;
            numPeA.BackColor = Color.MidnightBlue;
            numPeA.ForeColor = Color.LightGreen;
            numApA.BackColor = Color.MidnightBlue;
            numApA.ForeColor = Color.LightGreen;
            // Comboboxes
            cboxSel.BackColor = Color.MidnightBlue;
            cboxSel.ForeColor = Color.LightGreen;
            // Button and Menu strip
            btnResetDefault.BackColor = Color.MidnightBlue;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.Green;
        }

        /// <summary>
        /// Changes colors back to default
        /// </summary>
        private void LowContrast() {
            this.BackColor = default;
            this.ForeColor = default;
            
            foreach (Control c in this.Controls) {
                c.BackColor = default;
                c.ForeColor = default;
            }
        }

        private void HicontrastModeToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!hicontrastModeToolStripMenuItem.Checked) {
                HiContrast();
                hicontrastModeToolStripMenuItem.Checked = true;
            } else {
                LowContrast();
                hicontrastModeToolStripMenuItem.Checked = false;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.Show();
        }
    }
}
