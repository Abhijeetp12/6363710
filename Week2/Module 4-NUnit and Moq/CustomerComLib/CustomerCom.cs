namespace CustomerComLib
{
    public class CustomerCom
    {
        private readonly IMailSender _mailSender;
        public CustomerCom(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }
        public bool SendMailToCustomer()
        {
            string toAddress = "cust987@g.com";
            string message = "Hello Customer, this is a test mail from CustomerComLib.";
            return _mailSender.SendMail(toAddress, message);
        }

    }
}
