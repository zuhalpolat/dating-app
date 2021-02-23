using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
         Task<UserLike> GetUserLike(int sourceId, int likedUserId);
         Task<AppUser> GetUserWithLikes(int userId);
         Task<PagedList<LikeDTO>> GetUserLikes(LikesParams likesParams);
    }
}
