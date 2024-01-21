using EYouthUnisco.API.ViewModels;

namespace EYouthUnisco.API.Errors
{
    public class ErrorUserEmailAlreadyExist : UniscoException
    {
        public ErrorUserEmailAlreadyExist() : base("User Email already exist", 1000) { }
    }
    public class ErrorGenerateUserToken : UniscoException
    {
        public ErrorGenerateUserToken() : base("Error Generate Usr Token", 1001) { }
    }
    public class ErrorUserEmailNotExist : UniscoException
    {
        public ErrorUserEmailNotExist() : base("User Email not exist", 1002) { }
    }
    public class ErrorIncorrectPassword : UniscoException
    {
        public ErrorIncorrectPassword() : base("Incorrect Password", 1002) { }
    }
    public class ErrorUserNotFound : UniscoException
    {
        public ErrorUserNotFound() : base("User Not Found", 1003) { }
    }
    public class ErrorNullId : UniscoException
    {
        public ErrorNullId() : base("Id Can't Be null", 1003) { }
    }

}