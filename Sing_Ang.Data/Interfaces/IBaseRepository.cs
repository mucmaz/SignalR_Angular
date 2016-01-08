using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sing_Ang.Data.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity:class 
    {
        void Ekle(TEntity nesne);
        void Guncelle(TEntity nesne);
        void Sil(TEntity nesne);
        TEntity IdyeGoreGetir(int id);
        List<TEntity> TumunuGetir();
    }
}
