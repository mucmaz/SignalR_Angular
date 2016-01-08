using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sing_Ang.Data.Repository;
using Sing_Ang.Entity;

namespace Sing_Ang.Bll
{
    public class BaseBusiness<TEntity> where TEntity:class 
    {
        BaseRepositorycs<TEntity> _repo = new BaseRepositorycs<TEntity>();

        public void Ekle(TEntity nesne)
        {
            _repo.Ekle(nesne);
        }

        public void Guncelle(TEntity nesne)
        {
            _repo.Guncelle(nesne);
        }

        public void Sil(TEntity nesne)
        {
            _repo.Sil(nesne);
        }

        public TEntity IdyeGoreGetir(int id)
        {
            return _repo.IdyeGoreGetir(id);
        }

        public List<TEntity> TumunuGetir()
        {
            return _repo.TumunuGetir();
        }
    }
}
