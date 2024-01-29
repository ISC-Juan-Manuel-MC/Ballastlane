using Ballastlane.BusinessLogic.Helpers;
using Ballastlane.Data;
using Ballastlane.Models;

namespace Ballastlane.BusinessLogic
{
    public class ProfileService
    {
        private readonly ProfileRepository _profileRepository;

        public ProfileService(ProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        public void Add(string Email, string Alias, DateOnly Birthday)
        {
            if(string.IsNullOrEmpty(Email) & String.IsNullOrEmpty(Alias)) { throw new ArgumentNullException(); }

            Profile ProfileInspected = this.GetByEmail(Email);

            if (ProfileInspected == null)
            {
                ProfileInspected = new Profile();
                ProfileInspected.Email = Email;
                ProfileInspected.Alias = Alias;
                ProfileInspected.Birthday = Birthday;
                _profileRepository.Add(ProfileInspected);
            } 

            throw ExceptionHelper.GetEntityAlreadyExistsException();
        }

        public void Delete(Guid ProfileID)
        {
            Profile ProfileInspected = this.GetById(ProfileID);

            if (ProfileInspected == null)
            {
                throw ExceptionHelper.GetEntityNotFoundException();
            }

            _profileRepository.Delete(ProfileInspected.Id);
        }

        public IEnumerable<Profile> GetAll()
        {
            return _profileRepository.GetAll();
        }

        public Profile GetById(Guid ProfileId)
        {
            if (String.IsNullOrEmpty(ProfileId.ToString())) { throw ExceptionHelper.GetInvalidInputsException(); }

            return _profileRepository.GetById(ProfileId);
        }

        public Profile GetByEmail(string Email)
        {
            if (String.IsNullOrEmpty(Email)) { throw ExceptionHelper.GetInvalidInputsException(); }

            return _profileRepository.GetByEmail(Email);
        }

        public void Update(Guid ProfileID, string Alias, DateOnly Birtday)
        {
            if (string.IsNullOrEmpty(ProfileID.ToString()) & String.IsNullOrEmpty(Alias)) { throw ExceptionHelper.GetInvalidInputsException(); }

            Profile ProfileInspected = this.GetById(ProfileID);

            if (ProfileInspected == null)
            {
                throw ExceptionHelper.GetEntityNotFoundException();
            }

            ProfileInspected.Alias = Alias;
            ProfileInspected.Birthday = Birtday;
            _profileRepository.Update(ProfileInspected);
        }

    }
}
