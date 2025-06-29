using CustomerComLib;
using Moq;
using NUnit.Framework;

namespace CustomerCom.Tests
{
    [TestFixture]
    public class CustomerComTests
    {
        private Mock<IMailSender> _mockMailSender;
        private CustomerComLib.CustomerCom _customerCom; 

        [OneTimeSetUp]
        public void Init()
        {
            _mockMailSender = new Mock<IMailSender>();
            _mockMailSender.Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            _customerCom = new CustomerComLib.CustomerCom(_mockMailSender.Object); 
        }

        [TestCase]
        public void SendMailToCustomer_ShouldReturnTrue_WhenMailIsSentSuccessfully()
        {
            var result = _customerCom.SendMailToCustomer();

            Assert.That(result, Is.True);
        }
    }
 }
