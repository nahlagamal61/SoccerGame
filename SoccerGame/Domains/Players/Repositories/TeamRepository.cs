namespace SoccerGame.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public TeamRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public override async Task<List<Team>> GetAllAsync()
        {
            return await _table.Include(t => t.Players).ToListAsync();
        }
    }
}
