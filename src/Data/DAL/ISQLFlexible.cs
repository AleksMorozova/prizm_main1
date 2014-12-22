using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL
{

    interface ISQLFlexible
    {
        ISQLFlexible Top(int count);
        ISQLFlexible WhereAnd();
        ISQLFlexible Where(string a, string b, string c);
        ISQLFlexible WhereActive(bool isActive);
        ISQLFlexible WhereRequired(bool isRequired);
        ISQLFlexible WherePipeMillStatus(string pipeMillStatus);
        string ToString();
    }

}
