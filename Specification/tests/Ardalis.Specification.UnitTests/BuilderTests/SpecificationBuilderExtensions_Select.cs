using
/* Unmerged change from project 'Ardalis.Specification.UnitTests (net472)'
Before:
using System.Text;
using Ardalis.Specification.UnitTests.Fixture.Entities;
After:
using System.Text;

using Ardalis.Specification.UnitTests.Fixture.Entities;
*/
Ardalis.Specification.UnitTests.Fixture.Specs;

using FluentAssertions;

using Xunit;

namespace Ardalis.Specification.UnitTests
{
    public class SpecificationBuilderExtensions_Select
    {
        [Fact]
        public void SetsNothing_GivenNoSelectExpression()
        {
            var spec = new StoreNamesEmptySpec();

            spec.Selector.Should().BeNull();
        }

        [Fact]
        public void SetsSelector_GivenSelectExpression()
        {
            var spec = new StoreNamesSpec();

            spec.Selector.Should().NotBeNull();
        }
    }
}
