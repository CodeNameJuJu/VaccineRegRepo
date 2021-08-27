
namespace Vaccine_Regestration
{
    partial class Registration
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
            this.IDLbl = new System.Windows.Forms.Label();
            this.srnlbl = new System.Windows.Forms.Label();
            this.Firstlbl = new System.Windows.Forms.Label();
            this.Gndrlbl = new System.Windows.Forms.Label();
            this.prvnclbl = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.surtxt = new System.Windows.Forms.TextBox();
            this.firsttxt = new System.Windows.Forms.TextBox();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.ProvinceCombo = new System.Windows.Forms.ComboBox();
            this.Regbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(46, 30);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(47, 17);
            this.IDLbl.TabIndex = 0;
            this.IDLbl.Text = "ID No.";
            // 
            // srnlbl
            // 
            this.srnlbl.AutoSize = true;
            this.srnlbl.Location = new System.Drawing.Point(28, 58);
            this.srnlbl.Name = "srnlbl";
            this.srnlbl.Size = new System.Drawing.Size(65, 17);
            this.srnlbl.TabIndex = 1;
            this.srnlbl.Text = "Surname";
            // 
            // Firstlbl
            // 
            this.Firstlbl.AutoSize = true;
            this.Firstlbl.Location = new System.Drawing.Point(28, 87);
            this.Firstlbl.Name = "Firstlbl";
            this.Firstlbl.Size = new System.Drawing.Size(70, 17);
            this.Firstlbl.TabIndex = 2;
            this.Firstlbl.Text = "Firstname";
            // 
            // Gndrlbl
            // 
            this.Gndrlbl.AutoSize = true;
            this.Gndrlbl.Location = new System.Drawing.Point(47, 114);
            this.Gndrlbl.Name = "Gndrlbl";
            this.Gndrlbl.Size = new System.Drawing.Size(56, 17);
            this.Gndrlbl.TabIndex = 3;
            this.Gndrlbl.Text = "Gender";
            // 
            // prvnclbl
            // 
            this.prvnclbl.AutoSize = true;
            this.prvnclbl.Location = new System.Drawing.Point(47, 144);
            this.prvnclbl.Name = "prvnclbl";
            this.prvnclbl.Size = new System.Drawing.Size(43, 17);
            this.prvnclbl.TabIndex = 4;
            this.prvnclbl.Text = "Label";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(104, 25);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(121, 22);
            this.idtxt.TabIndex = 5;
            // 
            // surtxt
            // 
            this.surtxt.Location = new System.Drawing.Point(104, 55);
            this.surtxt.Name = "surtxt";
            this.surtxt.Size = new System.Drawing.Size(121, 22);
            this.surtxt.TabIndex = 6;
            // 
            // firsttxt
            // 
            this.firsttxt.Location = new System.Drawing.Point(104, 83);
            this.firsttxt.Name = "firsttxt";
            this.firsttxt.Size = new System.Drawing.Size(121, 22);
            this.firsttxt.TabIndex = 7;
            // 
            // genderCombo
            // 
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderCombo.Location = new System.Drawing.Point(104, 111);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(121, 24);
            this.genderCombo.TabIndex = 8;
            // 
            // ProvinceCombo
            // 
            this.ProvinceCombo.FormattingEnabled = true;
            this.ProvinceCombo.Items.AddRange(new object[] {
            "Gauteng",
            "Limpopo",
            "Freestate",
            "North west",
            "Northern Cape",
            "Western Cape",
            "Eastern Cape",
            "Mpumalanga",
            "Kwa-Zulu Natal"});
            this.ProvinceCombo.Location = new System.Drawing.Point(104, 141);
            this.ProvinceCombo.Name = "ProvinceCombo";
            this.ProvinceCombo.Size = new System.Drawing.Size(121, 24);
            this.ProvinceCombo.TabIndex = 9;
            // 
            // Regbtn
            // 
            this.Regbtn.Location = new System.Drawing.Point(104, 187);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.Size = new System.Drawing.Size(121, 30);
            this.Regbtn.TabIndex = 10;
            this.Regbtn.Text = "Register";
            this.Regbtn.UseVisualStyleBackColor = true;
            this.Regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 243);
            this.Controls.Add(this.Regbtn);
            this.Controls.Add(this.ProvinceCombo);
            this.Controls.Add(this.genderCombo);
            this.Controls.Add(this.firsttxt);
            this.Controls.Add(this.surtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.prvnclbl);
            this.Controls.Add(this.Gndrlbl);
            this.Controls.Add(this.Firstlbl);
            this.Controls.Add(this.srnlbl);
            this.Controls.Add(this.IDLbl);
            this.Name = "Registration";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.Label srnlbl;
        private System.Windows.Forms.Label Firstlbl;
        private System.Windows.Forms.Label Gndrlbl;
        private System.Windows.Forms.Label prvnclbl;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox surtxt;
        private System.Windows.Forms.TextBox firsttxt;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.ComboBox ProvinceCombo;
        private System.Windows.Forms.Button Regbtn;
    }
}

