﻿using System;
/* Unmerged change from project 'Ardalis.Specification.UnitTests (net472)'
Before:
using System.Text;
using FluentAssertions;
After:
using System.Text;

using FluentAssertions;
*/


using FluentAssertions;

using Xunit;

namespace Ardalis.Specification.UnitTests
{
    public class DuplicateOrderChainExceptionTests
    {
        private const string defaultMessage = "The specification contains more than one Order chain!";

        [Fact]
        public void ThrowWithDefaultConstructor()
        {
            Action action = () => throw new DuplicateOrderChainException();

            action.Should().Throw<DuplicateOrderChainException>().WithMessage(defaultMessage);
        }

        [Fact]
        public void ThrowWithInnerException()
        {
            Exception inner = new Exception("test");
            Action action = () => throw new DuplicateOrderChainException(inner);

            action.Should().Throw<DuplicateOrderChainException>().WithMessage(defaultMessage).WithInnerException<Exception>().WithMessage("test");
        }
    }
}
