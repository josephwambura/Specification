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
    public class AsNoTrackingEvaluator : IEvaluator
    {
        private AsNoTrackingEvaluator() { }
        public static AsNoTrackingEvaluator Instance { get; } = new AsNoTrackingEvaluator();

        public bool IsCriteriaEvaluator { get; } = true;

        public IQueryable<T> GetQuery<T>(IQueryable<T> query, ISpecification<T> specification) where T : class
        {
            if (specification.AsNoTracking)
            {
                query = query.AsNoTracking();
            }

            return query;
        }
    }
}
