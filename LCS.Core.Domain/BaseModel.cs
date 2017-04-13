using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS.Core.Domain
{
    public class BaseModel
    {
        public Guid Id { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
