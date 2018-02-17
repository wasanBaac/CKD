using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKD.Class
{
    class Cal
    {
        public string calAge(DateTime dt)
        {
            DateTime dtNow = DateTime.Now;

            var age = dtNow.Year - dt.Year;

            if (dt > dtNow.AddYears(-age)) age--;
            return age.ToString();
        }
    }
}
