namespace SoccerGame.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TeamConfiguration : EntityConfiguration<Team> 
    {
        public override void Configure(EntityTypeBuilder<Team> builder)
        {
            base.Configure(builder);
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).IsRequired().HasMaxLength(30);
            builder.Property(t => t.Country).IsRequired().HasMaxLength(30);
            builder.Property(t => t.CoachName).IsRequired().HasMaxLength(30);

            builder.HasMany(t => t.Players).WithOne().HasForeignKey(t => t.TeamId);
  
        }
    }
}
