using
/* Unmerged change from project 'Ardalis.Specification.UnitTests (net472)'
Before:
using System.Text;
using Ardalis.Specification.UnitTests.Fixture.Entities;
After:
using System.Text;

using Ardalis.Specification.UnitTests.Fixture.Entities;
*/
Ardalis.Specification.UnitTests.Fixture.Entities;

namespace Ardalis.Specification.UnitTests.Fixture.Specs
{
    public class StoreIncludeCompanyThenNameSpec : Specification<Store>
    {
        public StoreIncludeCompanyThenNameSpec()
        {
            Query.Include(x => x.Company)
                 .ThenInclude(x => x!.Name);
        }
    }
}
