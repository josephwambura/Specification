using System.Linq;
/* Unmerged change from project 'Ardalis.Specification.EntityFrameworkCore (netstandard2.0)'
Before:
using System.Text;
using Microsoft.EntityFrameworkCore;
After:
using System.Text;

using Microsoft.EntityFrameworkCore;
*/

/* Unmerged change from project 'Ardalis.Specification.EntityFrameworkCore (netstandard2.1)'
Before:
using System.Text;
using Microsoft.EntityFrameworkCore;
After:
using System.Text;

using Microsoft.EntityFrameworkCore;
*/


using Microsoft.EntityFrameworkCore;

namespace Ardalis.Specification.EntityFrameworkCore
{
#if !NETSTANDARD2_0
    public class AsSplitQueryEvaluator : IEvaluator
    {
        private AsSplitQueryEvaluator() { }
        public static AsSplitQueryEvaluator Instance { get; } = new AsSplitQueryEvaluator();

        public bool IsCriteriaEvaluator { get; } = true;

        public IQueryable<T> GetQuery<T>(IQueryable<T> query, ISpecification<T> specification) where T : class
        {
            if (specification.AsSplitQuery)
            {
                query = query.AsSplitQuery();
            }

            return query;
        }
    }
#endif
}
