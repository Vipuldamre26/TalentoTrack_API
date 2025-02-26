using Microsoft.EntityFrameworkCore;
using TalentoTrack_Common.Entities;
using TalentoTrack_Common.Repositories;
using TalentoTrack_Dao.DB;

namespace TalentoTrack_Dao.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public TalentoTrack_DbContext _dbContext;

        public AccountRepository(TalentoTrack_DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LoginDetails> GetLoginDetails(string username, string password)
        {
            var dbRecord = await _dbContext.tbl_login_details.Where(p => (p.UserName != null && p.UserName.Equals(username)) && (p.Password != null && p.Password.Equals(password))).FirstOrDefaultAsync();

            return dbRecord!;
        }
    }
}
