﻿using Ecommerce.Infrastructure.Interfaces;

namespace Ecommerce.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public EFUnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
