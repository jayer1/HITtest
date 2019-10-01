using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIT.Models
{
    public interface IWCTCHealthSystemRepository
    {
        IQueryable<Ethnicity> Ethnicities { get; }
        IQueryable<Gender> Genders { get; }
        IQueryable<Discharge> Discharges { get; }
    }
}
