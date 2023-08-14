using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {

        public void Configure(EntityTypeBuilder<Address> Builder)
        {
            builder.ToTable("addresses");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentyColumn)
                .HasColumnName("Id_Address")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Neigborhood)
                .HasColumnName("Nameneigborhood")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            buider.Property(p => p.TypeMay)
                .HasColumnName("TypeWay")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.NumberWay)
                .HasAnnotation("Mysql:ValueGenerationStrategy", MysqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("NumberWay")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.QuadrantPrefix)
                .HasColumnName("QuadrantPrefix")
                .HasColumnType("varchar")
                .HasMaxLength("200")
                .IsRequired();

            builder.Property(p => p.NumberVenereableWay)
                .HasColumnName("NumberVenereableWay")
                .HasColumneType("int")
                .IsRequired();

            builder.Property(p => p.NumberPlate)
                .HasColumnName("NumberPlate")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(p => p.City)
            .WithMany(p => p.Addresses)
            .HasForeignKey(p => p.Id_CityA);

            builder.HasOne(p => p.Person)
            .WithMany(p => p.Addresses)
            .HasForeignKey(p => p.Id_Pa);

        }

    }