namespace NearbyShops.Domain
{
    /// <summary>
    /// User interface
    /// </summary>
    public interface IUserMiddleService
    {
        /// <summary>
        /// Signs up.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        bool SignUp(string login, string password);

        /// <summary>
        /// Signs the in.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        bool SignIn(string login, string password);
        
    }
}
