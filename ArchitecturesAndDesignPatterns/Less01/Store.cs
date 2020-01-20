using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less01
{
    public class Store
    {
        private readonly IIdGenerator _idGenerator;
        public long Id { get; private set; }

        public Store(IIdGenerator idGenerator)
        {
            _idGenerator = idGenerator;
            Id = _idGenerator.CalculateId();
        }
    }

}
