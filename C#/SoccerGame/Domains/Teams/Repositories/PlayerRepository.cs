namespace SoccerGame.Repositories
{
    using BaseLibrary.Repositories;
    using Microsoft.EntityFrameworkCore;
    using SoccerGame.Entities;

    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
