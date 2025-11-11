using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Infrastructure
{
    public enum status
    {
        Lost = -1,
        Available = 0,
        OnLoan = 1,
        Damaged = 2
    }
}
