namespace WH40K_GUI_UAT_MS539_ML
{
    partial class RosterF
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
            this.rosterNameTxt = new System.Windows.Forms.TextBox();
            this.rosterCharactersLbl = new System.Windows.Forms.Label();
            this.rosterBattleLineLbl = new System.Windows.Forms.Label();
            this.dedicatedTransportLbl = new System.Windows.Forms.Label();
            this.otherDatasheetsLbl = new System.Windows.Forms.Label();
            this.alliedUnitsLbl = new System.Windows.Forms.Label();
            this.addUnitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rosterNameTxt
            // 
            this.rosterNameTxt.Location = new System.Drawing.Point(8, 8);
            this.rosterNameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rosterNameTxt.Name = "rosterNameTxt";
            this.rosterNameTxt.Size = new System.Drawing.Size(68, 20);
            this.rosterNameTxt.TabIndex = 0;
            this.rosterNameTxt.Text = "RosterName";
            // 
            // rosterCharactersLbl
            // 
            this.rosterCharactersLbl.AutoSize = true;
            this.rosterCharactersLbl.Location = new System.Drawing.Point(5, 29);
            this.rosterCharactersLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rosterCharactersLbl.Name = "rosterCharactersLbl";
            this.rosterCharactersLbl.Size = new System.Drawing.Size(58, 13);
            this.rosterCharactersLbl.TabIndex = 1;
            this.rosterCharactersLbl.Text = "Characters";
            // 
            // rosterBattleLineLbl
            // 
            this.rosterBattleLineLbl.AutoSize = true;
            this.rosterBattleLineLbl.Location = new System.Drawing.Point(5, 42);
            this.rosterBattleLineLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rosterBattleLineLbl.Name = "rosterBattleLineLbl";
            this.rosterBattleLineLbl.Size = new System.Drawing.Size(54, 13);
            this.rosterBattleLineLbl.TabIndex = 2;
            this.rosterBattleLineLbl.Text = "BattleLine";
            // 
            // dedicatedTransportLbl
            // 
            this.dedicatedTransportLbl.AutoSize = true;
            this.dedicatedTransportLbl.Location = new System.Drawing.Point(5, 55);
            this.dedicatedTransportLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dedicatedTransportLbl.Name = "dedicatedTransportLbl";
            this.dedicatedTransportLbl.Size = new System.Drawing.Size(104, 13);
            this.dedicatedTransportLbl.TabIndex = 3;
            this.dedicatedTransportLbl.Text = "Dedicated Transport";
            // 
            // otherDatasheetsLbl
            // 
            this.otherDatasheetsLbl.AutoSize = true;
            this.otherDatasheetsLbl.Location = new System.Drawing.Point(5, 68);
            this.otherDatasheetsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otherDatasheetsLbl.Name = "otherDatasheetsLbl";
            this.otherDatasheetsLbl.Size = new System.Drawing.Size(90, 13);
            this.otherDatasheetsLbl.TabIndex = 4;
            this.otherDatasheetsLbl.Text = "Other Datasheets";
            // 
            // alliedUnitsLbl
            // 
            this.alliedUnitsLbl.AutoSize = true;
            this.alliedUnitsLbl.Location = new System.Drawing.Point(5, 81);
            this.alliedUnitsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alliedUnitsLbl.Name = "alliedUnitsLbl";
            this.alliedUnitsLbl.Size = new System.Drawing.Size(59, 13);
            this.alliedUnitsLbl.TabIndex = 5;
            this.alliedUnitsLbl.Text = "Allied Units";
            // 
            // addUnitBtn
            // 
            this.addUnitBtn.Location = new System.Drawing.Point(446, 4);
            this.addUnitBtn.Name = "addUnitBtn";
            this.addUnitBtn.Size = new System.Drawing.Size(75, 23);
            this.addUnitBtn.TabIndex = 6;
            this.addUnitBtn.Text = "Add Unit";
            this.addUnitBtn.UseVisualStyleBackColor = true;
            this.addUnitBtn.Click += new System.EventHandler(this.addUnitBtn_Click);
            // 
            // RosterF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.addUnitBtn);
            this.Controls.Add(this.alliedUnitsLbl);
            this.Controls.Add(this.otherDatasheetsLbl);
            this.Controls.Add(this.dedicatedTransportLbl);
            this.Controls.Add(this.rosterBattleLineLbl);
            this.Controls.Add(this.rosterCharactersLbl);
            this.Controls.Add(this.rosterNameTxt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RosterF";
            this.Text = "RosterF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rosterNameTxt;
        private System.Windows.Forms.Label rosterCharactersLbl;
        private System.Windows.Forms.Label rosterBattleLineLbl;
        private System.Windows.Forms.Label dedicatedTransportLbl;
        private System.Windows.Forms.Label otherDatasheetsLbl;
        private System.Windows.Forms.Label alliedUnitsLbl;
        private System.Windows.Forms.Button addUnitBtn;
    }
}