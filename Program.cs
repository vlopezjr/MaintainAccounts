using MaintainAccount;
using MaintainCustomer;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CreateAccountWizard.TestForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = MaintainAccountsForm.Instance();

            try
            {
                Application.Run(mainForm);
            }
            catch(Exception ex)
            {
                if (Debugger.IsAttached) throw ex;

                EmailSender.EmailError(ex);
                MessageBox.Show("An error has occured. An email has been set to IT with the error information. Application will now close down..");
                mainForm.Close();
            }
        }
    }
}
