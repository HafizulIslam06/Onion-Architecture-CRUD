using DataLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IRepository<UserProfile> userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }
        UserProfile IUserProfileService.GetUserProfile(long id)
        {
            return userProfileRepository.Get(id);
        }
    }
}
