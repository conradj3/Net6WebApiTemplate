﻿using Microsoft.EntityFrameworkCore;
using Net6WebApiTemplate.Domain.Entities;

namespace Net6WebApiTemplate.Application.Common.Interfaces
{
    public interface INet6WebApiTemplateDbContext
    {
        DbSet<Client> Clients { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<RefreshToken> RefreshTokens { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}