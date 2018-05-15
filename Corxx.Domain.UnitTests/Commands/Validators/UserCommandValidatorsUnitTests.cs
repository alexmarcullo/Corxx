using Corxx.Domain.Commands.Inputs.UserCommandInputs;
using Corxx.Domain.Commands.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace Corxx.Domain.UnitTests
{
    [TestClass]
    public class UserCommandValidatorsUnitTests
    {
        private const string FIRSTNAME = "FirstName";
        private const string LASTNAME = "LastName";
        private const string EMAIL = "Email";

        private readonly Mock<UserCommandInputsFields> _fields;


        public UserCommandValidatorsUnitTests()
        {
            _fields = new Mock<UserCommandInputsFields>();
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_FirstName_ShouldReturnNotificationWhenIsEmpty()
        {
            _fields.Object.FirstName = "";
            _fields.Object.ValidateFirstName();
            Assert.IsTrue(_fields.Object.Notifications.Where(x => x.Property == FIRSTNAME).Any());
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_FirstName_ShouldReturnNotificationWhenLessThanTwoCharacters()
        {
            _fields.Object.FirstName = "A";
            _fields.Object.ValidateFirstName();
            Assert.IsTrue(_fields.Object.Notifications.Where(x => x.Property == FIRSTNAME).Any());
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_FirstName_ShouldReturnNotificationWhenGreatherThanSixteenCharacters()
        {
            _fields.Object.FirstName = "ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ";
            _fields.Object.ValidateFirstName();
            Assert.IsTrue(_fields.Object.Notifications.Where(x => x.Property == FIRSTNAME).Any());
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_LastName_ShouldReturnNotificationWhenIsEmpty()
        {
            _fields.Object.LastName = "";
            _fields.Object.ValidateLastName();
            Assert.IsTrue(_fields.Object.Notifications.Where(x => x.Property == LASTNAME).Any());
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_LastName_ShouldReturnNotificationWhenLessThanTwoCharacters()
        {
            _fields.Object.LastName = "A";
            _fields.Object.ValidateLastName();
            Assert.IsTrue(_fields.Object.Notifications.Where(x => x.Property == LASTNAME).Any());
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_LastName_ShouldReturnNotificationWhenGreatherThanSixteenCharacters()
        {
            _fields.Object.LastName = "ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ";
            _fields.Object.ValidateLastName();
            Assert.IsTrue(_fields.Object.Notifications.Where(x => x.Property == LASTNAME).Any());
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_Email_ShouldReturnNotificationWhenIsEmpty()
        {
            _fields.Object.Email = "";
            _fields.Object.ValidateEmail();
            Assert.IsTrue(_fields.Object.Notifications.Where(x => x.Property == EMAIL).Any());
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_Email_ShouldReturnNotificationWhenIsInvalid()
        {
            _fields.Object.Email = "email@invalid";
            _fields.Object.ValidateEmail();
            Assert.IsTrue(_fields.Object.Notifications.Where(x => x.Property == EMAIL).Any());
        }
    }
}
