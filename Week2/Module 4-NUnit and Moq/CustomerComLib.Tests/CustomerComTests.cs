using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerComLib;
using Moq;
using NUnit.Framework;


namespace CustomerComLib.Tests
{
    public class CustomerComTests
    {
        [Test] 
        public void SendMailToCustomer_ShouldReturnTrue_WhenMailIsSentSuccessfully()
        {
            
            var mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var customerCom = new CustomerCom(mockMailSender.Object);

           
            var result = customerCom.SendMailToCustomer();

            
            Assert.That(result, Is.True); 

            mockMailSender.Verify(m => m.SendMail("cust987@g.com", "Hello Customer, this is a test mail from CustomerComLib."), Times.Once);
        }
    }
}
