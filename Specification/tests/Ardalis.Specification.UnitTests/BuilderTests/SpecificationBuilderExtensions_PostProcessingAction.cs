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
    public class SpecificationBuilderExtensions_PostProcessingAction
    {
        [Fact]
        public void SetsNothing_GivenNoPostProcessingAction()
        {
            var spec = new StoreEmptySpec();

            spec.PostProcessingAction.Should().BeNull();
        }

        [Fact]
        public void SetsNothing_GivenSelectorSpecWithNoPostProcessingAction()
        {
            var spec = new StoreNamesEmptySpec();

            spec.PostProcessingAction.Should().BeNull();
        }

        [Fact]
        public void SetsPostProcessingPredicate_GivenPostProcessingAction()
        {
            var spec = new StoreWithPostProcessingActionSpec();

            spec.PostProcessingAction.Should().NotBeNull();
        }

        [Fact]
        public void SetsPostProcessingPredicate_GivenSelectorSpecWithPostProcessingAction()
        {
            var spec = new StoreNamesWithPostProcessingActionSpec();

            spec.PostProcessingAction.Should().NotBeNull();
        }
    }
}
