using EF_2504.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2504.DAL.Concrete.EF
{
    public class EFBaseRepository<T> : IEntityRepository<T> where T : class
    {
        public void Add(T entity)
        {
            using (var _context = new BookAppDbContext())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var _context = new BookAppDbContext())
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var _context = new BookAppDbContext())
            {
                return _context.Set<T>().ToList();
            }
        }

        public T GetBy()
        {
            using (var _context = new BookAppDbContext())
            {
                return _context.Set<T>().SingleOrDefault();
            }
        }

        public void Update(T entity)
        {
            using (var _context = new BookAppDbContext())
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
        }
    }
}
