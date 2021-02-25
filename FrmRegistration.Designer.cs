namespace EmbroideryManager
{
    partial class FrmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistration));
            this.pnlRegister = new DevExpress.XtraEditors.PanelControl();
            this.logo = new DevExpress.XtraEditors.PictureEdit();
            this.chkRegistred = new DevExpress.XtraEditors.CheckEdit();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblPass = new DevExpress.XtraEditors.LabelControl();
            this.wait = new DevExpress.XtraEditors.PictureEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.bgRegistration = new System.ComponentModel.BackgroundWorker();
            this.RestoreFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRegister)).BeginInit();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRegistred.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wait.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlRegister.Appearance.Options.UseBackColor = true;
            this.pnlRegister.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRegister.Controls.Add(this.logo);
            this.pnlRegister.Controls.Add(this.chkRegistred);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.txtMobile);
            this.pnlRegister.Controls.Add(this.labelControl4);
            this.pnlRegister.Controls.Add(this.txtEmail);
            this.pnlRegister.Controls.Add(this.labelControl3);
            this.pnlRegister.Controls.Add(this.panelControl1);
            this.pnlRegister.Controls.Add(this.txtName);
            this.pnlRegister.Controls.Add(this.labelControl2);
            this.pnlRegister.Controls.Add(this.lblPass);
            this.pnlRegister.Controls.Add(this.wait);
            this.pnlRegister.Controls.Add(this.btnClose);
            this.pnlRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(305, 327);
            this.pnlRegister.TabIndex = 4;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logo.EditValue = ((object)(resources.GetObject("logo.EditValue")));
            this.logo.Location = new System.Drawing.Point(0, 292);
            this.logo.Name = "logo";
            this.logo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.logo.Size = new System.Drawing.Size(305, 35);
            this.logo.TabIndex = 12;
            // 
            // chkRegistred
            // 
            this.chkRegistred.Location = new System.Drawing.Point(10, 209);
            this.chkRegistred.Name = "chkRegistred";
            this.chkRegistred.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRegistred.Properties.Appearance.Options.UseFont = true;
            this.chkRegistred.Properties.Caption = "Already Registered";
            this.chkRegistred.Size = new System.Drawing.Size(147, 23);
            this.chkRegistred.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Location = new System.Drawing.Point(12, 240);
            this.btnRegister.LookAndFeel.SkinName = "Office 2013";
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(279, 25);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "&Register Now";
            // 
            // txtMobile
            // 
            this.txtMobile.EditValue = "";
            this.txtMobile.Location = new System.Drawing.Point(12, 176);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Properties.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMobile.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Properties.Appearance.Options.UseBorderColor = true;
            this.txtMobile.Properties.Appearance.Options.UseFont = true;
            this.txtMobile.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtMobile.Properties.Mask.EditMask = "\\d{10}";
            this.txtMobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMobile.Size = new System.Drawing.Size(279, 24);
            this.txtMobile.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Mobile No.";
            // 
            // txtEmail
            // 
            this.txtEmail.EditValue = "";
            this.txtEmail.Location = new System.Drawing.Point(12, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseBorderColor = true;
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEmail.Properties.Mask.EditMask = "(\\w|-|\\.)+@((\\w|-)+\\.)+(\\w|-){2,4}";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Size = new System.Drawing.Size(279, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Email Id";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(305, 30);
            this.panelControl1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(92, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "User Registration";
            // 
            // txtName
            // 
            this.txtName.EditValue = "";
            this.txtName.Location = new System.Drawing.Point(12, 65);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseBorderColor = true;
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtName.Size = new System.Drawing.Size(279, 24);
            this.txtName.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Your Name";
            // 
            // lblPass
            // 
            this.lblPass.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblPass.Location = new System.Drawing.Point(59, 270);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(180, 15);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Please enter valid contact detail.";
            // 
            // wait
            // 
            this.wait.EditValue = ((object)(resources.GetObject("wait.EditValue")));
            this.wait.Location = new System.Drawing.Point(220, 210);
            this.wait.Name = "wait";
            this.wait.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.wait.Size = new System.Drawing.Size(19, 20);
            this.wait.TabIndex = 10;
            this.wait.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(33, 314);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 13);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            // 
            // RestoreFileDialog
            // 
            this.RestoreFileDialog.FileName = "openFileDialog1";
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(305, 327);
            this.Controls.Add(this.pnlRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRegistration";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embriodery Manager";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlRegister)).EndInit();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRegistred.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wait.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlRegister;
        private DevExpress.XtraEditors.CheckEdit chkRegistred;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.TextEdit txtMobile;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblPass;
        private DevExpress.XtraEditors.PictureEdit wait;
        private DevExpress.XtraEditors.PictureEdit logo;
        private System.ComponentModel.BackgroundWorker bgRegistration;
        private System.Windows.Forms.OpenFileDialog RestoreFileDialog;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}