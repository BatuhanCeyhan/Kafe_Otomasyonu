using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcern.Utility
{
    public static class RandomValueGenerator
    {
        public static string GenerateFileName(string extension) //extension jpg,jpge gibi uzantılar üretirken . dan sonra gelen uzantı
        {
            //return Guid.NewGuid().ToString().Replace("-","").Substring(0,12)+DateTime.Now.ToShortDateString() + extension;

            return DateTime.Now.Ticks.ToString() + extension;
        }
    }
}
