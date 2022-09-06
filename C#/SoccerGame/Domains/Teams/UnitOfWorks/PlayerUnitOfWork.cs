namespace SoccerGame.UnitOfWorks
{
    using BaseLibrary.Repositories;
    using BaseLibrary.UnitOfWorks;
    using SoccerGame.Entities;

    public class PlayerUnitOfWork : BaseUnitOfWork<Player>, IPlayerUnitOfWork
    {
        public PlayerUnitOfWork(IBaseRepository<Player> repository) : base(repository)
        {
        }
    }
}
