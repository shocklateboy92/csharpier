using System.Collections.Generic;
using CSharpier.DocTypes;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier.SyntaxPrinter.SyntaxNodePrinters
{
    public static class BinaryPattern
    {
        public static Doc Print(BinaryPatternSyntax node)
        {
            return Doc.IndentIf(
                node.Parent is SubpatternSyntax or IsPatternExpressionSyntax,
                Doc.Concat(
                    Node.Print(node.Left),
                    Doc.Line,
                    Token.PrintWithSuffix(node.OperatorToken, " "),
                    Node.Print(node.Right)
                )
            );
        }
    }
}
