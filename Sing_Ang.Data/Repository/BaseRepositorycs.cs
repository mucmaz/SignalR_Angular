using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sing_Ang.Data.Repository
{
    public class BaseRepositorycs<TEntity> where TEntity:class
    {
        Context.Context _context = Context.Context.ContextOlustur();

        public void Ekle(TEntity nesne)
        {
            _context.Set<TEntity>().Add(nesne);
            _context.SaveChanges();
        }

        public void Guncelle(TEntity nesne)
        {
            _context.Entry(nesne).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Sil(TEntity nesne)
        {
            _context.Entry(nesne).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public TEntity IdyeGoreGetir(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public List<TEntity> TumunuGetir()
        {
            return _context.Set<TEntity>().ToList();
        }
    }
}
