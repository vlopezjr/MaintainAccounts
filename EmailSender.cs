using System;

namespace MaintainAccount
{
    static public class EmailSender
    {
        public static void EmailError(Exception ex)
        {
            var mail = new CPMail.ServiceSoapClient();
            var subject = string.Format("Error has occured in MaintainAccounts form");
            var summary = string.Format(@"Error has occured. Exception details:   

                                          {0} 
                                            STACK TRACE:

                                          {1}
                                            INNER EXCEPTION:

                                          {2}", ex.Message, ex.StackTrace, ex.InnerException);

            mail.Email("operations@caseparts.com", "domingog@caseparts.com", subject, summary, false, "", "");
        }
    }
}
