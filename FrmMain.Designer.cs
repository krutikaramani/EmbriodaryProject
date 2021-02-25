namespace EmbroideryManager
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.picAds = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.picClientLogo = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnPayHistory = new DevExpress.XtraEditors.SimpleButton();
            this.btnSettings = new DevExpress.XtraEditors.SimpleButton();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpenses = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnJobWorks = new DevExpress.XtraEditors.SimpleButton();
            this.btnBank = new DevExpress.XtraEditors.SimpleButton();
            this.btnDesigns = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.bgRegistrationCheck = new System.ComponentModel.BackgroundWorker();
            this.bgAutoUpdateCheck = new System.ComponentModel.BackgroundWorker();
            this.btnCompany = new DevExpress.XtraBars.BarButtonItem();
            this.pnlPass = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.bntLogin = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.pnlM = new DevExpress.XtraEditors.PanelControl();
            this.btnCloseM = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenM = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMpass = new DevExpress.XtraEditors.TextEdit();
            this.bgSubscriptionCheck = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAds)).BeginInit();
            this.picAds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPass)).BeginInit();
            this.pnlPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlM)).BeginInit();
            this.pnlM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMpass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnCompany});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(1186, 32);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonStatusBar.ItemLinks.Add(this.btnCompany);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 726);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1186, 27);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // picAds
            // 
            this.picAds.Controls.Add(this.pictureEdit1);
            this.picAds.Controls.Add(this.picClientLogo);
            this.picAds.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAds.Location = new System.Drawing.Point(896, 32);
            this.picAds.Name = "picAds";
            this.picAds.Size = new System.Drawing.Size(290, 694);
            this.picAds.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(4, 425);
            this.pictureEdit1.MenuManager = this.ribbon;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.pictureEdit1.Size = new System.Drawing.Size(281, 258);
            this.pictureEdit1.TabIndex = 1;
            // 
            // picClientLogo
            // 
            this.picClientLogo.EditValue = global::EmbroideryManager.Properties.Resources.images__1_;
            this.picClientLogo.Location = new System.Drawing.Point(6, 5);
            this.picClientLogo.MenuManager = this.ribbon;
            this.picClientLogo.Name = "picClientLogo";
            this.picClientLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.picClientLogo.Size = new System.Drawing.Size(279, 76);
            this.picClientLogo.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.btnPayHistory);
            this.panelControl2.Controls.Add(this.btnSettings);
            this.panelControl2.Controls.Add(this.btnReport);
            this.panelControl2.Controls.Add(this.btnRegister);
            this.panelControl2.Controls.Add(this.btnExpenses);
            this.panelControl2.Controls.Add(this.btnPrint);
            this.panelControl2.Controls.Add(this.btnJobWorks);
            this.panelControl2.Controls.Add(this.btnBank);
            this.panelControl2.Controls.Add(this.btnDesigns);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 32);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(896, 82);
            this.panelControl2.TabIndex = 3;
            // 
            // btnPayHistory
            // 
            this.btnPayHistory.Appearance.BackColor = System.Drawing.Color.White;
            this.btnPayHistory.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnPayHistory.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnPayHistory.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayHistory.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPayHistory.Appearance.Options.UseBackColor = true;
            this.btnPayHistory.Appearance.Options.UseBorderColor = true;
            this.btnPayHistory.Appearance.Options.UseFont = true;
            this.btnPayHistory.Appearance.Options.UseForeColor = true;
            this.btnPayHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayHistory.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPayHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayHistory.Image = global::EmbroideryManager.Properties.Resources.search;
            this.btnPayHistory.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPayHistory.Location = new System.Drawing.Point(677, 6);
            this.btnPayHistory.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnPayHistory.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPayHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPayHistory.Name = "btnPayHistory";
            this.btnPayHistory.Size = new System.Drawing.Size(90, 69);
            this.btnPayHistory.TabIndex = 9;
            this.btnPayHistory.Text = "Pay History";
            this.btnPayHistory.ToolTip = "Print New Cheque";
            // 
            // btnSettings
            // 
            this.btnSettings.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSettings.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnSettings.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSettings.Appearance.Options.UseBackColor = true;
            this.btnSettings.Appearance.Options.UseBorderColor = true;
            this.btnSettings.Appearance.Options.UseFont = true;
            this.btnSettings.Appearance.Options.UseForeColor = true;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Image = global::EmbroideryManager.Properties.Resources.Setting;
            this.btnSettings.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(778, 8);
            this.btnSettings.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSettings.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(90, 69);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.ToolTip = "Print New Cheque";
            // 
            // btnReport
            // 
            this.btnReport.Appearance.BackColor = System.Drawing.Color.White;
            this.btnReport.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnReport.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnReport.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnReport.Appearance.Options.UseBackColor = true;
            this.btnReport.Appearance.Options.UseBorderColor = true;
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.Appearance.Options.UseForeColor = true;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Image = global::EmbroideryManager.Properties.Resources._1418905235_3d_bar_chart;
            this.btnReport.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnReport.Location = new System.Drawing.Point(581, 6);
            this.btnReport.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnReport.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(90, 69);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report";
            this.btnReport.ToolTip = "Print New Cheque";
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.BackColor = System.Drawing.Color.White;
            this.btnRegister.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnRegister.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRegister.Appearance.Options.UseBackColor = true;
            this.btnRegister.Appearance.Options.UseBorderColor = true;
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegister.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Image = global::EmbroideryManager.Properties.Resources._1418905333_group_add;
            this.btnRegister.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnRegister.Location = new System.Drawing.Point(485, 6);
            this.btnRegister.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnRegister.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 69);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Data Master";
            this.btnRegister.ToolTip = "Print New Cheque";
            // 
            // btnExpenses
            // 
            this.btnExpenses.Appearance.BackColor = System.Drawing.Color.White;
            this.btnExpenses.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnExpenses.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnExpenses.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExpenses.Appearance.Options.UseBackColor = true;
            this.btnExpenses.Appearance.Options.UseBorderColor = true;
            this.btnExpenses.Appearance.Options.UseFont = true;
            this.btnExpenses.Appearance.Options.UseForeColor = true;
            this.btnExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExpenses.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenses.Image = global::EmbroideryManager.Properties.Resources.Payment;
            this.btnExpenses.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExpenses.Location = new System.Drawing.Point(197, 6);
            this.btnExpenses.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnExpenses.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExpenses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(90, 69);
            this.btnExpenses.TabIndex = 5;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.ToolTip = "Print New Cheque";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.BackColor = System.Drawing.Color.White;
            this.btnPrint.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnPrint.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrint.Appearance.Options.UseBackColor = true;
            this.btnPrint.Appearance.Options.UseBorderColor = true;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = global::EmbroideryManager.Properties.Resources.printer;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(293, 6);
            this.btnPrint.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnPrint.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 69);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.ToolTip = "Print New Cheque";
            // 
            // btnJobWorks
            // 
            this.btnJobWorks.Appearance.BackColor = System.Drawing.Color.White;
            this.btnJobWorks.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnJobWorks.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnJobWorks.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobWorks.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnJobWorks.Appearance.Options.UseBackColor = true;
            this.btnJobWorks.Appearance.Options.UseBorderColor = true;
            this.btnJobWorks.Appearance.Options.UseFont = true;
            this.btnJobWorks.Appearance.Options.UseForeColor = true;
            this.btnJobWorks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJobWorks.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnJobWorks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJobWorks.Image = global::EmbroideryManager.Properties.Resources.chack;
            this.btnJobWorks.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnJobWorks.Location = new System.Drawing.Point(101, 6);
            this.btnJobWorks.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnJobWorks.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnJobWorks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJobWorks.Name = "btnJobWorks";
            this.btnJobWorks.Size = new System.Drawing.Size(90, 69);
            this.btnJobWorks.TabIndex = 3;
            this.btnJobWorks.Text = "Job Works";
            this.btnJobWorks.ToolTip = "Print New Cheque";
            // 
            // btnBank
            // 
            this.btnBank.Appearance.BackColor = System.Drawing.Color.White;
            this.btnBank.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnBank.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnBank.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBank.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBank.Appearance.Options.UseBackColor = true;
            this.btnBank.Appearance.Options.UseBorderColor = true;
            this.btnBank.Appearance.Options.UseFont = true;
            this.btnBank.Appearance.Options.UseForeColor = true;
            this.btnBank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBank.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBank.Image = global::EmbroideryManager.Properties.Resources.coin12;
            this.btnBank.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnBank.Location = new System.Drawing.Point(389, 6);
            this.btnBank.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnBank.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(90, 69);
            this.btnBank.TabIndex = 2;
            this.btnBank.Text = "Bank";
            this.btnBank.ToolTip = "Print New Cheque";
            // 
            // btnDesigns
            // 
            this.btnDesigns.Appearance.BackColor = System.Drawing.Color.White;
            this.btnDesigns.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnDesigns.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnDesigns.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesigns.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDesigns.Appearance.Options.UseBackColor = true;
            this.btnDesigns.Appearance.Options.UseBorderColor = true;
            this.btnDesigns.Appearance.Options.UseFont = true;
            this.btnDesigns.Appearance.Options.UseForeColor = true;
            this.btnDesigns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDesigns.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDesigns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesigns.Image = global::EmbroideryManager.Properties.Resources.christmas126;
            this.btnDesigns.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDesigns.Location = new System.Drawing.Point(5, 6);
            this.btnDesigns.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnDesigns.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDesigns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesigns.Name = "btnDesigns";
            this.btnDesigns.Size = new System.Drawing.Size(90, 69);
            this.btnDesigns.TabIndex = 1;
            this.btnDesigns.Text = "Designs";
            this.btnDesigns.ToolTip = "Print New Cheque";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager.Appearance.Options.UseFont = true;
            this.xtraTabbedMdiManager.AppearancePage.Header.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabbedMdiManager.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabbedMdiManager.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager.MdiParent = this;
            this.xtraTabbedMdiManager.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.True;
            // 
            // bgRegistrationCheck
            // 
            this.bgRegistrationCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgRegistrationCheck_DoWork);
            this.bgRegistrationCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgRegistrationCheck_RunWorkerCompleted);
            // 
            // btnCompany
            // 
            this.btnCompany.Caption = "By Krishna Infotech";
            this.btnCompany.Id = 1;
            this.btnCompany.ItemAppearance.Normal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCompany.Name = "btnCompany";
            //this.btnCompany.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompany_ItemClick);
            // 
            // pnlPass
            // 
            this.pnlPass.Controls.Add(this.btnExit);
            this.pnlPass.Controls.Add(this.bntLogin);
            this.pnlPass.Controls.Add(this.panelControl4);
            this.pnlPass.Controls.Add(this.txtPass);
            this.pnlPass.Location = new System.Drawing.Point(56, 148);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(249, 126);
            this.pnlPass.TabIndex = 12;
            this.pnlPass.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(126, 83);
            this.btnExit.LookAndFeel.SkinName = "Office 2013";
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 24);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bntLogin
            // 
            this.bntLogin.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bntLogin.Appearance.Options.UseFont = true;
            this.bntLogin.Appearance.Options.UseForeColor = true;
            this.bntLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bntLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLogin.Location = new System.Drawing.Point(18, 83);
            this.bntLogin.LookAndFeel.SkinName = "Office 2013";
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(103, 24);
            this.bntLogin.TabIndex = 4;
            this.bntLogin.Text = "&Login";
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.labelControl11);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(245, 30);
            this.panelControl4.TabIndex = 3;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl11.Location = new System.Drawing.Point(70, 5);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(100, 19);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Enter Password";
            // 
            // txtPass
            // 
            this.txtPass.EditValue = "";
            this.txtPass.Location = new System.Drawing.Point(18, 52);
            this.txtPass.MenuManager = this.ribbon;
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(212, 24);
            this.txtPass.TabIndex = 0;
            // 
            // pnlM
            // 
            this.pnlM.Controls.Add(this.btnCloseM);
            this.pnlM.Controls.Add(this.btnOpenM);
            this.pnlM.Controls.Add(this.panelControl1);
            this.pnlM.Controls.Add(this.txtMpass);
            this.pnlM.Location = new System.Drawing.Point(58, 297);
            this.pnlM.Name = "pnlM";
            this.pnlM.Size = new System.Drawing.Size(211, 113);
            this.pnlM.TabIndex = 15;
            this.pnlM.Visible = false;
            // 
            // btnCloseM
            // 
            this.btnCloseM.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseM.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseM.Appearance.Options.UseFont = true;
            this.btnCloseM.Appearance.Options.UseForeColor = true;
            this.btnCloseM.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCloseM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseM.Location = new System.Drawing.Point(108, 74);
            this.btnCloseM.LookAndFeel.SkinName = "Office 2013";
            this.btnCloseM.Name = "btnCloseM";
            this.btnCloseM.Size = new System.Drawing.Size(88, 24);
            this.btnCloseM.TabIndex = 5;
            this.btnCloseM.Text = "Close";
            // 
            // btnOpenM
            // 
            this.btnOpenM.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenM.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenM.Appearance.Options.UseFont = true;
            this.btnOpenM.Appearance.Options.UseForeColor = true;
            this.btnOpenM.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOpenM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenM.Location = new System.Drawing.Point(14, 74);
            this.btnOpenM.LookAndFeel.SkinName = "Office 2013";
            this.btnOpenM.Name = "btnOpenM";
            this.btnOpenM.Size = new System.Drawing.Size(88, 24);
            this.btnOpenM.TabIndex = 4;
            this.btnOpenM.Text = "&Open";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(207, 30);
            this.panelControl1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(11, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(182, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ChequePrinter Management";
            // 
            // txtMpass
            // 
            this.txtMpass.EditValue = "";
            this.txtMpass.Location = new System.Drawing.Point(14, 44);
            this.txtMpass.MenuManager = this.ribbon;
            this.txtMpass.Name = "txtMpass";
            this.txtMpass.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMpass.Properties.Appearance.Options.UseFont = true;
            this.txtMpass.Properties.PasswordChar = '*';
            this.txtMpass.Size = new System.Drawing.Size(182, 24);
            this.txtMpass.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AllowDisplayRibbon = false;
            this.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 753);
            this.Controls.Add(this.pnlM);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.picAds);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAds)).EndInit();
            this.picAds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPass)).EndInit();
            this.pnlPass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlM)).EndInit();
            this.pnlM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMpass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.PanelControl picAds;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSettings;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.SimpleButton btnExpenses;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnJobWorks;
        private DevExpress.XtraEditors.SimpleButton btnBank;
        private DevExpress.XtraEditors.SimpleButton btnDesigns;
        private DevExpress.XtraEditors.SimpleButton btnPayHistory;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit picClientLogo;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private System.ComponentModel.BackgroundWorker bgRegistrationCheck;
        private System.ComponentModel.BackgroundWorker bgAutoUpdateCheck;
        private DevExpress.XtraBars.BarButtonItem btnCompany;
        private DevExpress.XtraEditors.PanelControl pnlM;
        private DevExpress.XtraEditors.SimpleButton btnCloseM;
        private DevExpress.XtraEditors.SimpleButton btnOpenM;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMpass;
        private DevExpress.XtraEditors.PanelControl pnlPass;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton bntLogin;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private System.ComponentModel.BackgroundWorker bgSubscriptionCheck;
    }
}