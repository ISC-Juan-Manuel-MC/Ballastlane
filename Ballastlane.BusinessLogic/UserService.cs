using Ballastlane.BusinessLogic.Helpers;
using Ballastlane.Data;
using Ballastlane.Models;

namespace Ballastlane.BusinessLogic
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(string Email, string Password)
        {
            if (string.IsNullOrEmpty(Email) & String.IsNullOrEmpty(Password)) { throw ExceptionHelper.GetInvalidInputsException("Email or Password invalid"); }

            User userInspected = this.GetById(Email);

            if (userInspected == null)
            {
                userInspected = new User
                {
                    Email = Email,
                    Password = Password,
                    IsActived = true
                };
                _userRepository.Add(userInspected);
            }

            throw ExceptionHelper.GetEntityAlreadyExistsException();
        }

        public void Delete(string Email)
        {
            User userInspected = this.GetById(Email);

            if (userInspected == null)
            {
                throw ExceptionHelper.GetEntityNotFoundException();
            }

            _userRepository.Deactivate(userInspected.Email);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(String Email)
        {
            if (string.IsNullOrEmpty(Email)) { throw ExceptionHelper.GetInvalidInputsException(); }

            return _userRepository.GetById(Email);
        }

        public void UpdatePassword(string Email, string Password)
        {
            if (string.IsNullOrEmpty(Email) & String.IsNullOrEmpty(Password)) { throw ExceptionHelper.GetInvalidInputsException("Email or Password invalid"); }

            User userInspected = this.GetById(Email);

            if (userInspected == null)
            {
                throw ExceptionHelper.GetEntityNotFoundException();
            }

            userInspected.Password = Password;
            _userRepository.Update(userInspected);
        }
   
    }
}
