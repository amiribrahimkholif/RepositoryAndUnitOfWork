using Core.Interfaces;
using Core.Models;
using EntityFramwork.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBaseRepository<Book> Books { get; private set; }
        public IBaseRepository<Author> Authors { get; private set; }

        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Authors = new BaseRepository<Author>(_context);
            Books = new BaseRepository<Book>(_context);
        }
        
        public int Compelet()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
