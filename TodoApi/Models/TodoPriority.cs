using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public enum TodoPriority
    {
        Low = 0,
        Normal = 1,
        [EnumMember(Value = "Urgent")]
        High = 2,               
    }
}
