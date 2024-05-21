namespace WH40K_GUI_UAT_MS539_ML
{
    partial class UnitF
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
            this.unitNameTxt = new System.Windows.Forms.TextBox();
            this.moveLbl = new System.Windows.Forms.Label();
            this.toughnessLbl = new System.Windows.Forms.Label();
            this.saveLbl = new System.Windows.Forms.Label();
            this.woundsLbl = new System.Windows.Forms.Label();
            this.leadershipLbl = new System.Windows.Forms.Label();
            this.objectiveControlLlb = new System.Windows.Forms.Label();
            this.invulnerableSaveLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unitNameTxt
            // 
            this.unitNameTxt.Location = new System.Drawing.Point(12, 12);
            this.unitNameTxt.Name = "unitNameTxt";
            this.unitNameTxt.Size = new System.Drawing.Size(100, 26);
            this.unitNameTxt.TabIndex = 0;
            this.unitNameTxt.Text = "Unit Name";
            // 
            // moveLbl
            // 
            this.moveLbl.AutoSize = true;
            this.moveLbl.Location = new System.Drawing.Point(12, 54);
            this.moveLbl.Name = "moveLbl";
            this.moveLbl.Size = new System.Drawing.Size(22, 20);
            this.moveLbl.TabIndex = 1;
            this.moveLbl.Text = "M";
            // 
            // toughnessLbl
            // 
            this.toughnessLbl.AutoSize = true;
            this.toughnessLbl.Location = new System.Drawing.Point(40, 54);
            this.toughnessLbl.Name = "toughnessLbl";
            this.toughnessLbl.Size = new System.Drawing.Size(18, 20);
            this.toughnessLbl.TabIndex = 2;
            this.toughnessLbl.Text = "T";
            // 
            // saveLbl
            // 
            this.saveLbl.AutoSize = true;
            this.saveLbl.Location = new System.Drawing.Point(65, 53);
            this.saveLbl.Name = "saveLbl";
            this.saveLbl.Size = new System.Drawing.Size(31, 20);
            this.saveLbl.TabIndex = 3;
            this.saveLbl.Text = "SV";
            // 
            // woundsLbl
            // 
            this.woundsLbl.AutoSize = true;
            this.woundsLbl.Location = new System.Drawing.Point(103, 52);
            this.woundsLbl.Name = "woundsLbl";
            this.woundsLbl.Size = new System.Drawing.Size(24, 20);
            this.woundsLbl.TabIndex = 4;
            this.woundsLbl.Text = "W";
            // 
            // leadershipLbl
            // 
            this.leadershipLbl.AutoSize = true;
            this.leadershipLbl.Location = new System.Drawing.Point(134, 53);
            this.leadershipLbl.Name = "leadershipLbl";
            this.leadershipLbl.Size = new System.Drawing.Size(30, 20);
            this.leadershipLbl.TabIndex = 5;
            this.leadershipLbl.Text = "LD";
            // 
            // objectiveControlLlb
            // 
            this.objectiveControlLlb.AutoSize = true;
            this.objectiveControlLlb.Location = new System.Drawing.Point(171, 53);
            this.objectiveControlLlb.Name = "objectiveControlLlb";
            this.objectiveControlLlb.Size = new System.Drawing.Size(32, 20);
            this.objectiveControlLlb.TabIndex = 6;
            this.objectiveControlLlb.Text = "OC";
            // 
            // invulnerableSaveLbl
            // 
            this.invulnerableSaveLbl.AutoSize = true;
            this.invulnerableSaveLbl.Location = new System.Drawing.Point(210, 53);
            this.invulnerableSaveLbl.Name = "invulnerableSaveLbl";
            this.invulnerableSaveLbl.Size = new System.Drawing.Size(36, 20);
            this.invulnerableSaveLbl.TabIndex = 7;
            this.invulnerableSaveLbl.Text = "INV";
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invulnerableSaveLbl);
            this.Controls.Add(this.objectiveControlLlb);
            this.Controls.Add(this.leadershipLbl);
            this.Controls.Add(this.woundsLbl);
            this.Controls.Add(this.saveLbl);
            this.Controls.Add(this.toughnessLbl);
            this.Controls.Add(this.moveLbl);
            this.Controls.Add(this.unitNameTxt);
            this.Name = "Unit";
            this.Text = "Unit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unitNameTxt;
        private System.Windows.Forms.Label moveLbl;
        private System.Windows.Forms.Label toughnessLbl;
        private System.Windows.Forms.Label saveLbl;
        private System.Windows.Forms.Label woundsLbl;
        private System.Windows.Forms.Label leadershipLbl;
        private System.Windows.Forms.Label objectiveControlLlb;
        private System.Windows.Forms.Label invulnerableSaveLbl;
    }
}