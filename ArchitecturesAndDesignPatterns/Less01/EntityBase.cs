using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less01
{
    public abstract class EntityBase
    {
        public long Id { get; private set; }

        public EntityBase()
        {
            Id = CalculateId();
        }

        private long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }

}
