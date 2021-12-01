using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace UltimitAts.Data.initializer
{
    public interface IDbInitializer
    {

        public void Initialize(DataContext dbContext);
    }
}
