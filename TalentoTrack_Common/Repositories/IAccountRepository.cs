
using TalentoTrack_Common.Entities;

namespace TalentoTrack_Common.Repositories
{
    public interface IAccountRepository
    {
        Task<LoginDetails> GetLoginDetails(string username, string password);
    }
}
