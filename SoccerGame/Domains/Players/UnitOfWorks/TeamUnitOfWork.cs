namespace SoccerGame.UnitOfWorks
{
    

    public class TeamUnitOfWork : BaseUnitOfWork<Team>, ITeamUnitOfWork
    {
        public TeamUnitOfWork(IBaseRepository<Team> repository) : base(repository)
        {
        }
    }
}
