using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Domain.Entities.Booking;

namespace Tarker.Booking.Persistence.Configuration
{
    public class BookingConfiguration
    {
        public BookingConfiguration(EntityTypeBuilder<BookingEntity> entityTypeBuilder) 
        {
            entityTypeBuilder.HasKey(x => x.BookingId);
            entityTypeBuilder.Property(x => x.RegisterDate).IsRequired();
            entityTypeBuilder.Property(x => x.Code).IsRequired();
            entityTypeBuilder.Property(x => x.Type).IsRequired();
            entityTypeBuilder.Property(x => x.UserId).IsRequired();
            entityTypeBuilder.Property(x => x.CustomerId).IsRequired();
        }
    }
}
