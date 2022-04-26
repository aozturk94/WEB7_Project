using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2504.DAL.Abstract
{
    interface IEntityRepository<T> where T:class //GENERİC BİR YAPILANDIRMA ALMASI İÇİN BUNU YAPARIZ.
    {
        void Add(T entity);
    }
}
