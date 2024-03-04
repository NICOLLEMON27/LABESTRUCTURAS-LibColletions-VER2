using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkgServices.pkgCollections.pkgLineal.pkgVector
{
    internal class clsVectorList<T>:clsADTVector<T>,iList<T> where T :IComparable<T>
    {
      public  bool opAdd(T item)
        {
            throw new NotImplementedException();
        }
        public bool opInsert(int index, T item)
        {
            throw new NotImplementedException();
        }
        public  bool opRemove(int idx, T item)
        {
            throw new NotImplementedException();
        }

        public clsVectorList(int capacity) { }
        public clsVectorList() { }
    }
}
