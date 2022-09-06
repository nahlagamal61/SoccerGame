namespace SoccerGame.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore.Query;
    using SoccerGame.Entities;

    public class PlayerConfiguration :EntityConfiguration<Player>
    {
        public override void Configure(EntityTypeBuilder<Player> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Property(p => p.Nationality).IsRequired().HasMaxLength(30);
            builder.Property(p => p.TeamId).IsRequired();
        }
    }
}
