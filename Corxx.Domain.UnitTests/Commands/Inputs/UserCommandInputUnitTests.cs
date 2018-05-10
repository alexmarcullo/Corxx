using Corxx.Domain.UnitTests.Commands.Inputs.Validators;
using FluentValidation.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Corxx.Domain.UnitTests.Commands.Inputs
{
    [TestClass]
    public class UserCommandInputUnitTests
    {
        private readonly UserCommandInputValidator validator;

        public UserCommandInputUnitTests()
        {
            validator = new UserCommandInputValidator();
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_FirstName_ShouldReturnNotificationWhenIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(x => x.FirstName, string.Empty);
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_FirstName_ShouldReturnNotificationWhenLessThanTwoCharacters()
        {
            validator.ShouldHaveValidationErrorFor(x => x.FirstName, "A");
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_FirstName_ShouldReturnNotificationWhenGreatherThanSixteenCharacters()
        {
            validator.ShouldHaveValidationErrorFor(x => x.FirstName, "ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ");
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_LastName_ShouldReturnNotificationWhenIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(x => x.LastName, string.Empty);
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_LastName_ShouldReturnNotificationWhenLessThanTwoCharacters()
        {
            validator.ShouldHaveValidationErrorFor(x => x.LastName, "A");
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_LastName_ShouldReturnNotificationWhenGreatherThanSixteenCharacters()
        {
            validator.ShouldHaveValidationErrorFor(x => x.LastName, "ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ ABCDEFGHIJ");
        }

        [TestMethod]
        [TestCategory("UserCommandsInputs")]
        public void UserCommandsInputs_Email_ShouldNotReturnNotificationWhenIsValid()
        {
            validator.ShouldNotHaveValidationErrorFor(x => x.Email, "email@is.valid");
        }
    }
}
