namespace SoccerGame.UnitOfWorks
{

    public class PlayerUnitOfWork : BaseUnitOfWork<Player>, IPlayerUnitOfWork
    {
        public PlayerUnitOfWork(IBaseRepository<Player> repository) : base(repository)
        {
        }
    }
}
