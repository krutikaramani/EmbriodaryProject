using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;
using Ionic.Zip;
using Krishna.core;
using EmbroideryManager;

namespace EmbroideryManager
{
    public partial class FrmRegistration : DevExpress.XtraEditors.XtraForm
    {
        String Name = "";
        String Email = "";
        String Mobile = "";
        String RegistrationResult = "";

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private Boolean ValidateRegistration()
        {
            String errortxt = "";
            Boolean validFlag = true;

            if (IS.NullOrWhiteSpace(txtName.Text))
            {
                errortxt += "Please enter your name\n";
                txtName.Focus();
                validFlag = false;
            }
            else if (IS.NullOrWhiteSpace(txtEmail.Text))
            {
                errortxt += "Please enter email address\n";
                txtEmail.Focus();
                validFlag = false;
            }
            else if (IS.NullOrWhiteSpace(txtMobile.Text))
            {
                errortxt += "Please enter mobile number\n";
                txtEmail.Focus();
                validFlag = false;
            }

            if (!validFlag)
            {
                XtraMessageBox.AllowCustomLookAndFeel = true;
                XtraMessageBox.Show(errortxt, "Required Fields");
            }
            return validFlag;
        }

        #region Regirtation procees 
        //private void btnRegister_Click(object sender, EventArgs e)
        //{
        //    if ((btnRegister.Text == "&Register Now") | (btnRegister.Text == "&Registration Fail. Try Again"))
        //    {
        //        if (ValidateRegistration())
        //        {
        //            if (!bgRegistration.IsBusy)
        //            {
        //                Name = txtName.Text.Trim();
        //                Email = txtEmail.Text.Trim();
        //                Mobile = txtMobile.Text.Trim();
        //                RegistrationResult = "";
        //                wait.Visible = true;
        //                txtName.Enabled = txtEmail.Enabled = txtMobile.Enabled = btnRegister.Enabled = chkRegistred.Enabled = false;
        //                btnRegister.Text = "Please Wait! Registering...";
        //                bgRegistration.RunWorkerAsync();
        //            }
        //        }
        //    }
        //    else if (btnRegister.Text == "Restore Backup")
        //    {
        //        RestoreFileDialog.FileName = "*.zip";
        //        DialogResult dr = RestoreFileDialog.ShowDialog();
        //        if (dr == System.Windows.Forms.DialogResult.OK)
        //        {
        //            try
        //            {
        //                String path = RestoreFileDialog.FileName;
        //                File.Delete("book.db");
        //                File.Delete("templates.db");
        //                ZipFile zip = ZipFile.Read(path);
        //                zip.ExtractAll(Environment.CurrentDirectory);
        //                Application.Restart();
        //            }
        //            catch (Exception error)
        //            {
        //                XtraMessageBox.Show(error.ToString());
        //            }
        //        }
        //    }
        //}

        //private void bgRegistration_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    try
        //    {

//                //DataTable dt = DB.GetDataTable("select * from cheque_users where mobile = '" + Mobile + "'");
//                if (dt.Rows.Count >= 1)
//                {
//                    RegistrationResult = "Mobile Number already registered. Use other number.";
//                }
//                else
//                {
//                    SmtpClient smstp = new SmtpClient();
//                    smstp.Port = 25;
//                    smstp.Host = "mail.krishnainfoways.com";
//                    smstp.Timeout = 30000;
//                    smstp.DeliveryMethod = SmtpDeliveryMethod.Network;
//                    smstp.UseDefaultCredentials = false;
//                    smstp.EnableSsl = false;
//                    smstp.Credentials = new System.Net.NetworkCredential("product@krishnainfoways.com", "123!@#");

//                    MailMessage mail = new MailMessage();
//                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
//                    mail.BodyEncoding = UTF8Encoding.UTF8;
//                    mail.From = new MailAddress("product@krishnainfoways.com", "Krishna Infoways");
//                    mail.To.Add(Email);
//                    mail.Subject = "Thank you!! Your free licence activated successfully.!";
//                    mail.IsBodyHtml = true;
//                    mail.Body = @"Hi! " + Name + @",<br/><br/> Thank you for using our application ChequePrinter. <br/><br/>
//                                                We are a waiting for your valuable feedback.<br/><br/>
//                                                You can call us on +91 8286818281 for feedback or any help.<br/><br/>
//                                                Thanks again,<br/><br/>
//                                                Krishna Infoways Team ";
//                    smstp.Send(mail);


//                    String PCID = "";
//                    try
//                    {
//                        PCID = Get.SystemUID();
//                    }
//                    catch
//                    {
//                        if (PCID == "")
//                        {
//                            PCID = Get.DriveUID();
//                        }
//                    }

//                    String ClientIP = "";
//                    try
//                    {
//                        String externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
//                        ClientIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches(externalIP)[0].ToString();
//                    }
//                    catch
//                    {
//                    }

//                    DateTime ServerDate = Convert.ToDateTime(DB.GetSingleString("SELECT CURDATE()"));
//                    String PCName = System.Environment.MachineName;

//                    MySqlCommand cmd = new MySqlCommand();
//                    cmd.CommandText = @"INSERT INTO `cheque_users` (`client_ip`, `pc_name`,`name`, `emailid`, `mobile`, `drive_id`, `registration_date`) 
//                                                        VALUES (@client_ip, @pc_name, @name, @emailid, @mobile, @drive_id, @registration_date);";
//                    cmd.Parameters.AddWithValue("@client_ip", ClientIP);
//                    cmd.Parameters.AddWithValue("@pc_name", PCName);
//                    cmd.Parameters.AddWithValue("@name", Name);
//                    cmd.Parameters.AddWithValue("@emailid", Email);
//                    cmd.Parameters.AddWithValue("@mobile", Mobile);
//                    cmd.Parameters.AddWithValue("@drive_id", PCID);
//                    cmd.Parameters.AddWithValue("@registration_date", ServerDate.ToString("yyyy-MM-dd"));

//                    if (DB.ExecuteQuery(cmd) > 0)
//                    {
//                        DataTable info = new DataTable("info");
//                        info.Columns.Add("ID", typeof(Int32));
//                        info.Columns.Add("name", typeof(String));
//                        info.Columns.Add("mobile", typeof(String));
//                        info.Columns.Add("email", typeof(String));
//                        info.Columns.Add("password", typeof(String));
//                        info.Columns.Add("registration_date", typeof(String));
//                        info.Columns.Add("subscription", typeof(String));
//                        info.Columns.Add("backup_day", typeof(Int32));
//                        info.Columns.Add("version", typeof(Int32));


//                        info.Rows.Add(1, Name, Mobile, Email, "", ServerDate.ToString("dd-MM-yyyy"), "01-01-0001", 0, Global.MainVersion);
                        
                        
        //            }
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        RegistrationResult = err.ToString();
        //    }
        //}
                        
        

        //private void bgRegistration_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    wait.Visible = false;
        //    if (RegistrationResult == "")
        //    {
        //        this.DialogResult = System.Windows.Forms.DialogResult.OK;
        //    }
        //    else
        //    {
        //        XtraMessageBox.Show(RegistrationResult);
        //        txtName.Enabled = txtEmail.Enabled = txtMobile.Enabled = btnRegister.Enabled = chkRegistred.Enabled = true;
        //        btnRegister.Text = "&Registration Fail. Try Again";
        //    }
        //}
        #endregion


        private void FrmRegistration_Load(object sender, EventArgs e)
        {

            if (Global.ConfigRow != null)
            {
                MemoryStream ms = new MemoryStream((Byte[])Global.ConfigRow["logo_small"]);
                logo.Image = Image.FromStream(ms);
            }
            //Add Marchant
            DataTable AddMerchant = new DataTable();
            AddMerchant.Columns.Add("ID", typeof(Int32));
            AddMerchant.Columns.Add("Company_name", typeof(string));
            AddMerchant.Columns.Add("Contact_no", typeof(Int32));
            AddMerchant.Columns.Add("Address", typeof(string));
            AddMerchant.Columns.Add("Whatsapp_no", typeof(Int32));
            AddMerchant.Columns.Add("Contact_person", typeof(string));
            AddMerchant.Columns.Add("Date_of_Registration", typeof(DateTime));
            AddMerchant.Columns.Add("Broker_name", typeof(string));
            AddMerchant.Columns.Add("Broker_contact_no", typeof(Int32));
            AddMerchant.Columns.Add("Brokage", typeof(Int32));
            AddMerchant.Columns.Add("TermsAndCondition", typeof(String));
            Global.dsAddMerchant.Tables.Add(AddMerchant);
            Enc.SetDataSet(Global.dsAddMerchant, Global.fileAddMerchant);

            //Job Work
            DataTable JobWork = new DataTable("JobWork");
            JobWork.Columns.Add("ID", typeof(Int32));
            JobWork.Columns.Add("Delivery_chalan_no", typeof(Int32));
            JobWork.Columns.Add("merchant_chalan_no", typeof(Int32));
            JobWork.Columns.Add("merchant_name", typeof(String));
            JobWork.Columns.Add("Date_on_chalan", typeof(DateTime));
            JobWork.Columns.Add("Design_no", typeof(Int32));
            JobWork.Columns.Add("Design_name", typeof(String));
            JobWork.Columns.Add("Delivery_date", typeof(Int32));
            JobWork.Columns.Add("Quantity", typeof(Int32));
            JobWork.Columns.Add("Amount", typeof(Int32));
            JobWork.Columns.Add("Broker_name", typeof(String));
            JobWork.Columns.Add("Brokage", typeof(Int32));
            Global.dsJobWork.Tables.Add(JobWork);
            Enc.SetDataSet(Global.dsJobWork, Global.fileJobWork);

            //Add Broker
            DataTable Add_Broker = new DataTable("Add_Broker");
            Add_Broker.Columns.Add("ID", typeof(Int32));
            Add_Broker.Columns.Add("name", typeof(String));
            Add_Broker.Columns.Add("contact", typeof(String));
            Global.dsAddBroker.Tables.Add(Add_Broker);
            Enc.SetDataSet(Global.dsAddBroker, Global.fileAddBroker);


            //Add Worker
            DataTable Add_Worker = new DataTable("Add_Worker");
            Add_Worker.Columns.Add("ID", typeof(Int32));
            Add_Worker.Columns.Add("name", typeof(String));
            Add_Worker.Columns.Add("address", typeof(String));
            Add_Worker.Columns.Add("contact", typeof(String));
            Add_Worker.Columns.Add("salary", typeof(Int32));
            Global.dsAddWorker.Tables.Add(Add_Worker);
            Enc.SetDataSet(Global.dsAddWorker, Global.fileAddWorker);

            //Add Expense
            DataTable Add_Expense = new DataTable("Add_Expense");
            Add_Expense.Columns.Add("ID", typeof(Int32));
            Add_Expense.Columns.Add("Bill_no", typeof(Int32));
            Add_Expense.Columns.Add("date", typeof(DateTime));
            Add_Expense.Columns.Add("merchant_name", typeof(String));
            Add_Expense.Columns.Add("expense_type", typeof(RadioButton));
            Add_Expense.Columns.Add("status", typeof(RadioButton));
            Add_Expense.Columns.Add("amount", typeof(Int32));
            Add_Expense.Columns.Add("pay_mode", typeof(RadioButton));
            //Cheque details columans yet to be insert
            Global.dsAddExpense.Tables.Add(Add_Expense);
            Enc.SetDataSet(Global.dsAddExpense, Global.fileAddExpense);



            //Add_Payment

            DataTable Add_payment = new DataTable("Add_payment");
            Add_payment.Columns.Add("ID", typeof(Int32));
            Add_payment.Columns.Add("date", typeof(DateTime));
            Add_payment.Columns.Add("merchant_name", typeof(String));
            Add_payment.Columns.Add("pay_mode", typeof(RadioButton));
            Add_payment.Columns.Add("amount", typeof(Int32));
            Add_payment.Columns.Add("unclear_amount", typeof(Int32));
            Add_payment.Columns.Add("paid_amount", typeof(Int32));
            Add_payment.Columns.Add("unpaid_amount", typeof(Int32));
            //Cheque details columans yet to be insert
            Global.dsAddPayment.Tables.Add(Add_payment);
            Enc.SetDataSet(Global.dsAddPayment, Global.fileAddPayment);


            //Worker task
            DataTable Worker_task = new DataTable("Worker_task");
            Worker_task.Columns.Add("ID", typeof(Int32));
            Worker_task.Columns.Add("worker_name", typeof(String));
            Worker_task.Columns.Add("date", typeof(DateTime));
            Worker_task.Columns.Add("merchant_name", typeof(String));
            Worker_task.Columns.Add("stitches", typeof(Int32));
            Worker_task.Columns.Add("head", typeof(Int32));
            Worker_task.Columns.Add("thread_color", typeof(Int32));
            Global.dsWorkerTask.Tables.Add(Worker_task);
            Enc.SetDataSet(Global.dsWorkerTask, Global.fileWorkerTask);




            RegistrationResult = "";

        }

        void SetControl(Boolean flag)
        {
            txtName.Enabled = flag;
            txtMobile.Enabled = flag;
            txtEmail.Enabled = flag;
            lblPass.Visible = flag;
        }

        private void chkRegistred_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegistred.Checked)
            {
                SetControl(false);
                btnRegister.Text = "Restore Backup";
            }
            else
            {
                SetControl(true);
                btnRegister.Text = "&Register Now";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}