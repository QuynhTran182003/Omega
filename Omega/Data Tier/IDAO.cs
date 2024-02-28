using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.Data_Tier
{
    public interface IDAO<T>
    {
        void GetById(int id);
        void Insert(T ele);
        void Update(int id, T newEle);
        void Delete(int id);
    }
}
