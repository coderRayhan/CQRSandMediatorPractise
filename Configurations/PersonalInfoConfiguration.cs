using MediatrAndCQRSDemo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediatrAndCQRSDemo.Configurations
{
    public class PersonalInfoConfiguration : IEntityTypeConfiguration<PersonalInfo>
    {
        public void Configure(EntityTypeBuilder<PersonalInfo> builder)
        {
            builder.Property(pi => pi.Id).ValueGeneratedNever();
            builder.Property(pi => pi.Name).HasMaxLength(50);
            builder.Property(pi => pi.IsNew).HasColumnType("bit");
            builder.HasKey(pi => pi.Id);
        }
    }
}
