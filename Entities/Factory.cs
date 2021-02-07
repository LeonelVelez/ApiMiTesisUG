using ApiMiTesisUG.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMiTesisUG.Entities
{
    public class Factory : IFactory
    {
        public static List<T> GetListObjeto<T>() where T : IHttpOption
        {
            return new List<T>();
        }

        public static T GetObjeto<T>() where T : IHttpOption
        {
            return default(T);
        }
    }
}
