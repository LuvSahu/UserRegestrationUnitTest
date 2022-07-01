namespace UserRegestrationWithUTestException
{
    public class Tests
    {
        RegistrationDetails user;
        [SetUp]
        public void Setup()
        {
            user = new RegistrationDetails();
        }

        [Test]
        public void FirstName()
        {
            // Arrange 
            bool expected = true;
            string name = "Luv";
            RegistrationDetails user = new RegistrationDetails();

            // Act
            bool result = user.ValidateFirstName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }
        //[Test]
        //public void LastName()
        //{
        //    // Arrange 
        //    bool expected = true;
        //    string name = "Sahu";
        //    RegistrationDetails user = new RegistrationDetails();

        //    // Act
        //    bool result = user.ValidateLastName(name);

        //    // Assert
        //    Assert.AreEqual(expected, result);
        //}
        //[Test]
        //public void Email()
        //{
        //    // Arrange 
        //    bool expected = true;
        //    string email = "lksahu303@gmail.com";
        //    RegistrationDetails user = new RegistrationDetails();

        //    // Act
        //    bool result = user.ValidateEmail(email);

        //    // Assert
        //    Assert.AreEqual(expected, result);
        //}
        //[Test]
        //public void MobileNumber()
        //{
        //    // Arrange 
        //    bool expected = true;
        //    string mobile = "91 8502012867";
        //    RegistrationDetails user = new RegistrationDetails();

        //    // Act
        //    bool result = user.ValidateMobileNumber(mobile);

        //    // Assert
        //    Assert.AreEqual(expected, result);
        //}
        ////[Test]
        ////public void Password()
        ////{
        ////    // Arrange 
        ////    bool expected = true;
        ////    string password = "luvkumarsahu@123";
        ////    RegistrationDetails user = new RegistrationDetails();

        ////    // Act
        ////    bool result = user.ValidatePassword(password);

        ////    // Assert
        ////    Assert.AreEqual(expected, result);
        ////}

    }


}

