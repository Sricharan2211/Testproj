namespace SignInLib
{
    public class SignIn
    {
        public static string Authenticate(string username, string password)
        {
            string result;
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                result = "You Must Provide Username and Password";
            }
            else if(username == "sam" && password =="sam@1256")
            {
                result = "Valid user";
            }
            else
            {
                result = "invalid User credential";
            }
            return result;
        }
    }
}