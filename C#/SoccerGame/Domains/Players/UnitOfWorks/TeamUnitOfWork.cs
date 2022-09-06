namespace SoccerGame.UnitOfWorks
{
    using BaseLibrary.Repositories;
    using BaseLibrary.UnitOfWorks;
    using SoccerGame.Entities;

    public class TeamUnitOfWork : BaseUnitOfWork<Team>, ITeamUnitOfWork
    {
        public TeamUnitOfWork(IBaseRepository<Team> repository) : base(repository)
        {
        }
    }
}
