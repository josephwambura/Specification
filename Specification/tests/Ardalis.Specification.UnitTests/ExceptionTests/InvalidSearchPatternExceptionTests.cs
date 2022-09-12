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
    public class InvalidSearchPatternExceptionTests
    {
        private const string defaultMessage = "Invalid search pattern: " + pattern;
        private const string pattern = "x";

        [Fact]
        public void ThrowWithDefaultConstructor()
        {
            Action action = () => throw new InvalidSearchPatternException(pattern);

            action.Should().Throw<InvalidSearchPatternException>(pattern).WithMessage(defaultMessage);
        }

        [Fact]
        public void ThrowWithInnerException()
        {
            Exception inner = new Exception("test");
            Action action = () => throw new InvalidSearchPatternException(pattern, inner);

            action.Should().Throw<InvalidSearchPatternException>(pattern).WithMessage(defaultMessage).WithInnerException<Exception>().WithMessage("test");
        }
    }
}
