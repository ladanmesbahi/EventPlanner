using EventPlanner.Domain.Entities;
using EventPlanner.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPlanner.Persistence.Configurations
{
    internal sealed class ConferenceConfiguration : IEntityTypeConfiguration<Conference>
    {
        public void Configure(EntityTypeBuilder<Conference> builder)
        {
            builder.ToTable(TableNames.Conference);

            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.Creator)
                .WithMany();

            builder
                .HasMany(x => x.Invitations)
                .WithOne()
                .HasForeignKey(x => x.ConferenceId);

            builder
                .HasMany(x => x.Attendees)
                .WithOne()
                .HasForeignKey(x => x.ConferenceId);
        }
    }
}
