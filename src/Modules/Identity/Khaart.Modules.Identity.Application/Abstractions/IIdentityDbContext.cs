using Khaart.Modules.Identity.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Khaart.Modules.Identity.Application.Abstractions;

public interface IIdentityDbContext
{
    DbSet<User> Users { get; }
}
