using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMiTesisUG.Entities.Interfaces
{
    interface IFactory
    {
        public  static T GetObjeto<T>() where T : IHttpOption => throw new NotImplementedException();
        public static List<T> GetListObjeto<T>() where T : IHttpOption => throw new NotImplementedException() ;

    }
}
