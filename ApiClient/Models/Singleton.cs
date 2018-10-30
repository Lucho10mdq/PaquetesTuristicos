using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiClient.Models
{
    public abstract class Singleton<T> where T : class, new()
    {
        private static T instance;

        public static T GetInstance()
        {
            if (instance == null)
                instance = new T();
            return instance;
        }
    }
}