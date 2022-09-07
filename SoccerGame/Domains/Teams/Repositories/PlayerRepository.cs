namespace SoccerGame.Repositories
{
    using Microsoft.EntityFrameworkCore;

    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
