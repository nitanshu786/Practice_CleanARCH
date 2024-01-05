using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Base_Entity
{
    public class BaseEntity<PrimaryKey>
    {
        public PrimaryKey Id { get; set; }
    }
}
