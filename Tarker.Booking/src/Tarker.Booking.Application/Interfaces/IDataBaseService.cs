using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Domain.Entities.User;

namespace Tarker.Booking.Application.Interfaces
{
    public interface IDataBaseService
    {
        DbSet<UserEntity> User { get; set; }
    }
}
