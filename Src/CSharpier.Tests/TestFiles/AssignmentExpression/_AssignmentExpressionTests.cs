using CSharpier.Tests.TestFileTests;
using NUnit.Framework;

namespace CSharpier.Tests.TestFiles
{
    public class AssignmentExpressionTests : BaseTest
    {
        [Test]
        public void AssignmentExpressionComments()
        {
            this.RunTest(
                "AssignmentExpression",
                "AssignmentExpressionComments"
            );
        }
        [Test]
        public void BasicAssignmentExpression()
        {
            this.RunTest("AssignmentExpression", "BasicAssignmentExpression");
        }
        [Test]
        public void AssignmentExpressionWraps()
        {
            this.RunTest("AssignmentExpression", "AssignmentExpressionWraps");
        }
    }
}
