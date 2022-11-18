using Layer.Core.Interfaces.UnitOfWork;
using Layer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TİGER3Context _db;

        public UnitOfWork(TİGER3Context db)
        {
            _db = db;
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
