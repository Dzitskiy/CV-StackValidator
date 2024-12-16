using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StackValidatorTests
{
    public class StackVatidatorTests
    {
        public StackVatidatorTests() 
        { 
        
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("(", false)]
        [InlineData("]", false)]
        [InlineData("([]{()[{}]}", true)]
        public void Test(string s, bool result)
        {
            var isValid = Solution.IsValid(s);
            Assert.Equal(isValid, result);
        }
    }
}
