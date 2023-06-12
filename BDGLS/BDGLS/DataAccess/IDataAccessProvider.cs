using BDGLS.Models;

namespace BDGLS.DataAccess
{
    public interface IDataAccessProvider
    {
        /// <summary>
        /// Registration of a new user account
        /// </summary>
        /// <param name="user"></param>
        void        CreateUserRecord(UserModel user);

        /// <summary>
        /// Login and returning of necessary user account data when login is validated
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        UserModel   ReadUserRecord(UserModel user);

        /// <summary>
        /// Checking the username before creating a new user account or updating of an existing one.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool        CheckDataAvailability(UserModel user);

        /// <summary>
        /// Verification of the rule set for a valid password.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string      CheckPasswordPolicy(UserModel user);

        /// <summary>
        /// Login verification
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string      LoginVerification(UserModel user);

        /// <summary>
        /// Saving the score of a player
        /// </summary>
        /// <param name="saveGameRequest"></param>
        /// <returns></returns>
        bool        StoreUserGameData(SaveGameRequest saveGameRequest);

        /// <summary>
        /// Reading the score of a player
        /// </summary>
        /// <param name="saveGameRequest"></param>
        /// <returns></returns>
        byte[]      ReadUserGameData(SaveGameRequest saveGameRequest);
    }
}