using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less01
{
    public class Customer
    {
        private readonly IIdGenerator _idGenerator;
        public long Id { get; private set; }
        public string Description { get; set; }

        public Customer(IIdGenerator idGenerator)
        {
            _idGenerator = idGenerator;
            Id = _idGenerator.CalculateId();
        }
    }
}
