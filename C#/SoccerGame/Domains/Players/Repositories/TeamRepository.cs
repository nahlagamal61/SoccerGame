namespace SoccerGame.Repositories
{
    using BaseLibrary.Repositories;
    using Microsoft.EntityFrameworkCore;
    using SoccerGame.Entities;

    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public TeamRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
