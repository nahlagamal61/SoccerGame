namespace SoccerGame.EntityConfiguration
{
    using BaseLibrary.BaseEntities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class EntityConfiguration<T> : IEntityTypeConfiguration<T>
     where T : BaseEntity
    {

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(p => p.Id);

        }
    }

}


