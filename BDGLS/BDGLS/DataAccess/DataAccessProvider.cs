using BDGLS.Models;
using System.Linq;

namespace BDGLS.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        public DataAccessProvider() { }

        private readonly BDGLContext _context;
        public DataAccessProvider(BDGLContext context)
        {
            _context = context;
        }

        public void CreateUserRecord(UserModel user)
        {
            user.Password = Utils.HashPassword(user.Password);
            _context.User.Add(user);
            _context.SaveChanges();
        }

        /// Receive data as encoded 
        //public UserModel ReadUserRecord(UserModel user)
        //{
        //    return _context.User.FirstOrDefault(u => u.Username == Utils.Decode(user.Username));
        //}

        public UserModel ReadUserRecord(UserModel user)
        {
            return _context.User.FirstOrDefault(u => u.Username == user.Username);
        }
        public bool CheckDataAvailability(UserModel user)
        {            
            return _context.User.FirstOrDefault(u => u.Username == user.Username) != null;
        }
        public string CheckPasswordPolicy(UserModel user)
        {
            // RequireLength
            if(user.Password.Length < 8)
                return "Password too short";

            // RequireLowercase
            if (!user.Password.Any(c => char.IsLower(c)))
                return "No Lowercase";

            // RequireLowercase
            if (!user.Password.Any(c => char.IsUpper(c)))
                return "No Uppercase";

            // RequireLowercase
            if (!user.Password.Any(c => char.IsDigit(c)))
                return "No Digit";

            // RequireUniqueChars
            if (user.Password.IndexOfAny("\\|¬¦`!\"£$%^&*()_+-=[]{};:'@#~<>,./? ".ToCharArray()) <= 0)
                return "No Unique Chars";

            return "OK";
        }

        // With encoding
        //public string LoginVerification(UserModel user)
        //{
        //    UserModel profile = _context.User.FirstOrDefault(u => u.Username == Utils.Decode(user.Username));

        //    if (profile == null)
        //        return "Wrong Credentials"; // username not exist

        //    if (!Utils.VerifyPassword(profile.Password, Utils.Decode(user.Password)))
        //        return "Wrong Credentials"; // wrong password

        //    //profile.LastLogin = DateTime.Now; // nicht hier, sondern wenn BDGL beendet wird
        //    return "OK";
        //}

        public string LoginVerification(UserModel user)
        {
            UserModel profile = _context.User.FirstOrDefault(u => u.Username == user.Username);

            if (profile == null)
                return "Wrong Credentials"; // username not exist

            if (!Utils.VerifyPassword(profile.Password, user.Password))
                return "Wrong Credentials"; // wrong password

            return "OK";
        }
        public bool StoreUserGameData(SaveGameRequest saveGameRequest)
        {
            UserModel profile = _context.User.FirstOrDefault(u => u.Username == saveGameRequest.Username);
            _context.Application.FirstOrDefault(v => v.UUID == profile.UUID).Data = saveGameRequest.File;
            _context.SaveChanges();
            return true;
        }
        public byte[] ReadUserGameData(SaveGameRequest readGameRequest)
        {
            UserModel profile = _context.User.FirstOrDefault(u => u.Username == readGameRequest.Username);
            return _context.Application.FirstOrDefault(v => v.UUID == profile.UUID).Data;
        }
    }
}