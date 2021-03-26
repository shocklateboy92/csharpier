using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private int depth = 0;
        public Doc Print(SyntaxNode syntaxNode)
        {
            if (syntaxNode == null)
            {
                return null;
            }

            // TODO 0 kill? runtime repo has files that will fail on deep recursion
            if (depth > 200)
            {
                throw new InTooDeepException();
            }
            
            depth++;
            try {
                switch (syntaxNode)
                {
                    case YieldStatementSyntax yieldStatementSyntax:
                        return this.PrintYieldStatementSyntax(yieldStatementSyntax);
                    case WithExpressionSyntax withExpressionSyntax:
                        return this.PrintWithExpressionSyntax(withExpressionSyntax);
                    case WhileStatementSyntax whileStatementSyntax:
                        return this.PrintWhileStatementSyntax(whileStatementSyntax);
                    case WhereClauseSyntax whereClauseSyntax:
                        return this.PrintWhereClauseSyntax(whereClauseSyntax);
                    case WhenClauseSyntax whenClauseSyntax:
                        return this.PrintWhenClauseSyntax(whenClauseSyntax);
                    case VariableDeclaratorSyntax variableDeclaratorSyntax:
                        return this.PrintVariableDeclaratorSyntax(variableDeclaratorSyntax);
                    case VarPatternSyntax varPatternSyntax:
                        return this.PrintVarPatternSyntax(varPatternSyntax);
                    case UsingStatementSyntax usingStatementSyntax:
                        return this.PrintUsingStatementSyntax(usingStatementSyntax);
                    case UsingDirectiveSyntax usingDirectiveSyntax:
                        return this.PrintUsingDirectiveSyntax(usingDirectiveSyntax);
                    case UnsafeStatementSyntax unsafeStatementSyntax:
                        return this.PrintUnsafeStatementSyntax(unsafeStatementSyntax);
                    case UnaryPatternSyntax unaryPatternSyntax:
                        return this.PrintUnaryPatternSyntax(unaryPatternSyntax);
                    case TypeParameterSyntax typeParameterSyntax:
                        return this.PrintTypeParameterSyntax(typeParameterSyntax);
                    case TypeOfExpressionSyntax typeOfExpressionSyntax:
                        return this.PrintTypeOfExpressionSyntax(typeOfExpressionSyntax);
                    case TypeArgumentListSyntax typeArgumentListSyntax:
                        return this.PrintTypeArgumentListSyntax(typeArgumentListSyntax);
                    case TupleTypeSyntax tupleTypeSyntax:
                        return this.PrintTupleTypeSyntax(tupleTypeSyntax);
                    case TupleExpressionSyntax tupleExpressionSyntax:
                        return this.PrintTupleExpressionSyntax(tupleExpressionSyntax);
                    case TupleElementSyntax tupleElementSyntax:
                        return this.PrintTupleElementSyntax(tupleElementSyntax);
                    case TryStatementSyntax tryStatementSyntax:
                        return this.PrintTryStatementSyntax(tryStatementSyntax);
                    case ThrowStatementSyntax throwStatementSyntax:
                        return this.PrintThrowStatementSyntax(throwStatementSyntax);
                    case ThrowExpressionSyntax throwExpressionSyntax:
                        return this.PrintThrowExpressionSyntax(throwExpressionSyntax);
                    case SwitchStatementSyntax switchStatementSyntax:
                        return this.PrintSwitchStatementSyntax(switchStatementSyntax);
                    case SwitchSectionSyntax switchSectionSyntax:
                        return this.PrintSwitchSectionSyntax(switchSectionSyntax);
                    case SwitchExpressionSyntax switchExpressionSyntax:
                        return this.PrintSwitchExpressionSyntax(switchExpressionSyntax);
                    case StackAllocArrayCreationExpressionSyntax stackAllocArrayCreationExpressionSyntax:
                        return this.PrintStackAllocArrayCreationExpressionSyntax(stackAllocArrayCreationExpressionSyntax);
                    case SizeOfExpressionSyntax sizeOfExpressionSyntax:
                        return this.PrintSizeOfExpressionSyntax(sizeOfExpressionSyntax);
                    case SimpleLambdaExpressionSyntax simpleLambdaExpressionSyntax:
                        return this.PrintSimpleLambdaExpressionSyntax(simpleLambdaExpressionSyntax);
                    case SelectClauseSyntax selectClauseSyntax:
                        return this.PrintSelectClauseSyntax(selectClauseSyntax);
                    case ReturnStatementSyntax returnStatementSyntax:
                        return this.PrintReturnStatementSyntax(returnStatementSyntax);
                    case RelationalPatternSyntax relationalPatternSyntax:
                        return this.PrintRelationalPatternSyntax(relationalPatternSyntax);
                    case RefValueExpressionSyntax refValueExpressionSyntax:
                        return this.PrintRefValueExpressionSyntax(refValueExpressionSyntax);
                    case RefTypeSyntax refTypeSyntax:
                        return this.PrintRefTypeSyntax(refTypeSyntax);
                    case RefTypeExpressionSyntax refTypeExpressionSyntax:
                        return this.PrintRefTypeExpressionSyntax(refTypeExpressionSyntax);
                    case RefExpressionSyntax refExpressionSyntax:
                        return this.PrintRefExpressionSyntax(refExpressionSyntax);
                    case RecursivePatternSyntax recursivePatternSyntax:
                        return this.PrintRecursivePatternSyntax(recursivePatternSyntax);
                    case RangeExpressionSyntax rangeExpressionSyntax:
                        return this.PrintRangeExpressionSyntax(rangeExpressionSyntax);
                    case QueryExpressionSyntax queryExpressionSyntax:
                        return this.PrintQueryExpressionSyntax(queryExpressionSyntax);
                    case QueryContinuationSyntax queryContinuationSyntax:
                        return this.PrintQueryContinuationSyntax(queryContinuationSyntax);
                    case QueryBodySyntax queryBodySyntax:
                        return this.PrintQueryBodySyntax(queryBodySyntax);
                    case QualifiedNameSyntax qualifiedNameSyntax:
                        return this.PrintQualifiedNameSyntax(qualifiedNameSyntax);
                    case PrimaryConstructorBaseTypeSyntax primaryConstructorBaseTypeSyntax:
                        return this.PrintPrimaryConstructorBaseTypeSyntax(primaryConstructorBaseTypeSyntax);
                    case PrefixUnaryExpressionSyntax prefixUnaryExpressionSyntax:
                        return this.PrintPrefixUnaryExpressionSyntax(prefixUnaryExpressionSyntax);
                    case PostfixUnaryExpressionSyntax postfixUnaryExpressionSyntax:
                        return this.PrintPostfixUnaryExpressionSyntax(postfixUnaryExpressionSyntax);
                    case PointerTypeSyntax pointerTypeSyntax:
                        return this.PrintPointerTypeSyntax(pointerTypeSyntax);
                    case ParenthesizedVariableDesignationSyntax parenthesizedVariableDesignationSyntax:
                        return this.PrintParenthesizedVariableDesignationSyntax(parenthesizedVariableDesignationSyntax);
                    case ParenthesizedPatternSyntax parenthesizedPatternSyntax:
                        return this.PrintParenthesizedPatternSyntax(parenthesizedPatternSyntax);
                    case ParenthesizedLambdaExpressionSyntax parenthesizedLambdaExpressionSyntax:
                        return this.PrintParenthesizedLambdaExpressionSyntax(parenthesizedLambdaExpressionSyntax);
                    case ParenthesizedExpressionSyntax parenthesizedExpressionSyntax:
                        return this.PrintParenthesizedExpressionSyntax(parenthesizedExpressionSyntax);
                    case ParameterListSyntax parameterListSyntax:
                        return this.PrintParameterListSyntax(parameterListSyntax);
                    case OrderByClauseSyntax orderByClauseSyntax:
                        return this.PrintOrderByClauseSyntax(orderByClauseSyntax);
                    case ObjectCreationExpressionSyntax objectCreationExpressionSyntax:
                        return this.PrintObjectCreationExpressionSyntax(objectCreationExpressionSyntax);
                    case NullableTypeSyntax nullableTypeSyntax:
                        return this.PrintNullableTypeSyntax(nullableTypeSyntax);
                    case NamespaceDeclarationSyntax namespaceDeclarationSyntax:
                        return this.PrintNamespaceDeclarationSyntax(namespaceDeclarationSyntax);
                    case NameEqualsSyntax nameEqualsSyntax:
                        return this.PrintNameEqualsSyntax(nameEqualsSyntax);
                    case NameColonSyntax nameColonSyntax:
                        return this.PrintNameColonSyntax(nameColonSyntax);
                    case MemberBindingExpressionSyntax memberBindingExpressionSyntax:
                        return this.PrintMemberBindingExpressionSyntax(memberBindingExpressionSyntax);
                    case MemberAccessExpressionSyntax memberAccessExpressionSyntax:
                        return this.PrintMemberAccessExpressionSyntax(memberAccessExpressionSyntax);
                    case MakeRefExpressionSyntax makeRefExpressionSyntax:
                        return this.PrintMakeRefExpressionSyntax(makeRefExpressionSyntax);
                    case LockStatementSyntax lockStatementSyntax:
                        return this.PrintLockStatementSyntax(lockStatementSyntax);
                    case LocalDeclarationStatementSyntax localDeclarationStatementSyntax:
                        return this.PrintLocalDeclarationStatementSyntax(localDeclarationStatementSyntax);
                    case LetClauseSyntax letClauseSyntax:
                        return this.PrintLetClauseSyntax(letClauseSyntax);
                    case LabeledStatementSyntax labeledStatementSyntax:
                        return this.PrintLabeledStatementSyntax(labeledStatementSyntax);
                    case JoinClauseSyntax joinClauseSyntax:
                        return this.PrintJoinClauseSyntax(joinClauseSyntax);
                    case IsPatternExpressionSyntax isPatternExpressionSyntax:
                        return this.PrintIsPatternExpressionSyntax(isPatternExpressionSyntax);
                    case InvocationExpressionSyntax invocationExpressionSyntax:
                        return this.PrintInvocationExpressionSyntax(invocationExpressionSyntax);
                    case InterpolationSyntax interpolationSyntax:
                        return this.PrintInterpolationSyntax(interpolationSyntax);
                    case InterpolatedStringExpressionSyntax interpolatedStringExpressionSyntax:
                        return this.PrintInterpolatedStringExpressionSyntax(interpolatedStringExpressionSyntax);
                    case InitializerExpressionSyntax initializerExpressionSyntax:
                        return this.PrintInitializerExpressionSyntax(initializerExpressionSyntax);
                    case ImplicitStackAllocArrayCreationExpressionSyntax implicitStackAllocArrayCreationExpressionSyntax:
                        return this.PrintImplicitStackAllocArrayCreationExpressionSyntax(implicitStackAllocArrayCreationExpressionSyntax);
                    case ImplicitObjectCreationExpressionSyntax implicitObjectCreationExpressionSyntax:
                        return this.PrintImplicitObjectCreationExpressionSyntax(implicitObjectCreationExpressionSyntax);
                    case ImplicitArrayCreationExpressionSyntax implicitArrayCreationExpressionSyntax:
                        return this.PrintImplicitArrayCreationExpressionSyntax(implicitArrayCreationExpressionSyntax);
                    case IfStatementSyntax ifStatementSyntax:
                        return this.PrintIfStatementSyntax(ifStatementSyntax);
                    case GroupClauseSyntax groupClauseSyntax:
                        return this.PrintGroupClauseSyntax(groupClauseSyntax);
                    case GotoStatementSyntax gotoStatementSyntax:
                        return this.PrintGotoStatementSyntax(gotoStatementSyntax);
                    case GlobalStatementSyntax globalStatementSyntax:
                        return this.PrintGlobalStatementSyntax(globalStatementSyntax);
                    case GenericNameSyntax genericNameSyntax:
                        return this.PrintGenericNameSyntax(genericNameSyntax);
                    case FromClauseSyntax fromClauseSyntax:
                        return this.PrintFromClauseSyntax(fromClauseSyntax);
                    case ForEachVariableStatementSyntax forEachVariableStatementSyntax:
                        return this.PrintForEachVariableStatementSyntax(forEachVariableStatementSyntax);
                    case ForEachStatementSyntax forEachStatementSyntax:
                        return this.PrintForEachStatementSyntax(forEachStatementSyntax);
                    case FixedStatementSyntax fixedStatementSyntax:
                        return this.PrintFixedStatementSyntax(fixedStatementSyntax);
                    case FinallyClauseSyntax finallyClauseSyntax:
                        return this.PrintFinallyClauseSyntax(finallyClauseSyntax);
                    case ExternAliasDirectiveSyntax externAliasDirectiveSyntax:
                        return this.PrintExternAliasDirectiveSyntax(externAliasDirectiveSyntax);
                    case ExpressionStatementSyntax expressionStatementSyntax:
                        return this.PrintExpressionStatementSyntax(expressionStatementSyntax);
                    case EqualsValueClauseSyntax equalsValueClauseSyntax:
                        return this.PrintEqualsValueClauseSyntax(equalsValueClauseSyntax);
                    case ElementAccessExpressionSyntax elementAccessExpressionSyntax:
                        return this.PrintElementAccessExpressionSyntax(elementAccessExpressionSyntax);
                    case DoStatementSyntax doStatementSyntax:
                        return this.PrintDoStatementSyntax(doStatementSyntax);
                    case DestructorDeclarationSyntax destructorDeclarationSyntax:
                        return this.PrintDestructorDeclarationSyntax(destructorDeclarationSyntax);
                    case DelegateDeclarationSyntax delegateDeclarationSyntax:
                        return this.PrintDelegateDeclarationSyntax(delegateDeclarationSyntax);
                    case DefaultSwitchLabelSyntax defaultSwitchLabelSyntax:
                        return this.PrintDefaultSwitchLabelSyntax(defaultSwitchLabelSyntax);
                    case DefaultExpressionSyntax defaultExpressionSyntax:
                        return this.PrintDefaultExpressionSyntax(defaultExpressionSyntax);
                    case DeclarationPatternSyntax declarationPatternSyntax:
                        return this.PrintDeclarationPatternSyntax(declarationPatternSyntax);
                    case DeclarationExpressionSyntax declarationExpressionSyntax:
                        return this.PrintDeclarationExpressionSyntax(declarationExpressionSyntax);
                    case ContinueStatementSyntax continueStatementSyntax:
                        return this.PrintContinueStatementSyntax(continueStatementSyntax);
                    case ConstructorInitializerSyntax constructorInitializerSyntax:
                        return this.PrintConstructorInitializerSyntax(constructorInitializerSyntax);
                    case ConstructorDeclarationSyntax constructorDeclarationSyntax:
                        return this.PrintConstructorDeclarationSyntax(constructorDeclarationSyntax);
                    case ConstructorConstraintSyntax constructorConstraintSyntax:
                        return this.PrintConstructorConstraintSyntax(constructorConstraintSyntax);
                    case ConditionalExpressionSyntax conditionalExpressionSyntax:
                        return this.PrintConditionalExpressionSyntax(conditionalExpressionSyntax);
                    case ConditionalAccessExpressionSyntax conditionalAccessExpressionSyntax:
                        return this.PrintConditionalAccessExpressionSyntax(conditionalAccessExpressionSyntax);
                    case CompilationUnitSyntax compilationUnitSyntax:
                        return this.PrintCompilationUnitSyntax(compilationUnitSyntax);
                    case ClassOrStructConstraintSyntax classOrStructConstraintSyntax:
                        return this.PrintClassOrStructConstraintSyntax(classOrStructConstraintSyntax);
                    case CheckedStatementSyntax checkedStatementSyntax:
                        return this.PrintCheckedStatementSyntax(checkedStatementSyntax);
                    case CheckedExpressionSyntax checkedExpressionSyntax:
                        return this.PrintCheckedExpressionSyntax(checkedExpressionSyntax);
                    case CatchClauseSyntax catchClauseSyntax:
                        return this.PrintCatchClauseSyntax(catchClauseSyntax);
                    case CastExpressionSyntax castExpressionSyntax:
                        return this.PrintCastExpressionSyntax(castExpressionSyntax);
                    case CaseSwitchLabelSyntax caseSwitchLabelSyntax:
                        return this.PrintCaseSwitchLabelSyntax(caseSwitchLabelSyntax);
                    case CasePatternSwitchLabelSyntax casePatternSwitchLabelSyntax:
                        return this.PrintCasePatternSwitchLabelSyntax(casePatternSwitchLabelSyntax);
                    case BreakStatementSyntax breakStatementSyntax:
                        return this.PrintBreakStatementSyntax(breakStatementSyntax);
                    case BracketedParameterListSyntax bracketedParameterListSyntax:
                        return this.PrintBracketedParameterListSyntax(bracketedParameterListSyntax);
                    case BracketedArgumentListSyntax bracketedArgumentListSyntax:
                        return this.PrintBracketedArgumentListSyntax(bracketedArgumentListSyntax);
                    case BlockSyntax blockSyntax:
                        return this.PrintBlockSyntax(blockSyntax);
                    case BinaryPatternSyntax binaryPatternSyntax:
                        return this.PrintBinaryPatternSyntax(binaryPatternSyntax);
                    case BinaryExpressionSyntax binaryExpressionSyntax:
                        return this.PrintBinaryExpressionSyntax(binaryExpressionSyntax);
                    case AwaitExpressionSyntax awaitExpressionSyntax:
                        return this.PrintAwaitExpressionSyntax(awaitExpressionSyntax);
                    case AssignmentExpressionSyntax assignmentExpressionSyntax:
                        return this.PrintAssignmentExpressionSyntax(assignmentExpressionSyntax);
                    case ArrowExpressionClauseSyntax arrowExpressionClauseSyntax:
                        return this.PrintArrowExpressionClauseSyntax(arrowExpressionClauseSyntax);
                    case ArrayTypeSyntax arrayTypeSyntax:
                        return this.PrintArrayTypeSyntax(arrayTypeSyntax);
                    case ArrayRankSpecifierSyntax arrayRankSpecifierSyntax:
                        return this.PrintArrayRankSpecifierSyntax(arrayRankSpecifierSyntax);
                    case ArrayCreationExpressionSyntax arrayCreationExpressionSyntax:
                        return this.PrintArrayCreationExpressionSyntax(arrayCreationExpressionSyntax);
                    case ArgumentListSyntax argumentListSyntax:
                        return this.PrintArgumentListSyntax(argumentListSyntax);
                    case AnonymousObjectMemberDeclaratorSyntax anonymousObjectMemberDeclaratorSyntax:
                        return this.PrintAnonymousObjectMemberDeclaratorSyntax(anonymousObjectMemberDeclaratorSyntax);
                    case AnonymousObjectCreationExpressionSyntax anonymousObjectCreationExpressionSyntax:
                        return this.PrintAnonymousObjectCreationExpressionSyntax(anonymousObjectCreationExpressionSyntax);
                    case AliasQualifiedNameSyntax aliasQualifiedNameSyntax:
                        return this.PrintAliasQualifiedNameSyntax(aliasQualifiedNameSyntax);
                    case VariableDeclarationSyntax variableDeclarationSyntax:
                        return this.PrintVariableDeclarationSyntax(variableDeclarationSyntax);
                    case TypePatternSyntax typePatternSyntax:
                        return this.PrintTypePatternSyntax(typePatternSyntax);
                    case TypeParameterListSyntax typeParameterListSyntax:
                        return this.PrintTypeParameterListSyntax(typeParameterListSyntax);
                    case TypeParameterConstraintClauseSyntax typeParameterConstraintClauseSyntax:
                        return this.PrintTypeParameterConstraintClauseSyntax(typeParameterConstraintClauseSyntax);
                    case TypeConstraintSyntax typeConstraintSyntax:
                        return this.PrintTypeConstraintSyntax(typeConstraintSyntax);
                    case ThisExpressionSyntax thisExpressionSyntax:
                        return this.PrintThisExpressionSyntax(thisExpressionSyntax);
                    case StructDeclarationSyntax structDeclarationSyntax:
                        return this.PrintStructDeclarationSyntax(structDeclarationSyntax);
                    case SingleVariableDesignationSyntax singleVariableDesignationSyntax:
                        return this.PrintSingleVariableDesignationSyntax(singleVariableDesignationSyntax);
                    case SimpleBaseTypeSyntax simpleBaseTypeSyntax:
                        return this.PrintSimpleBaseTypeSyntax(simpleBaseTypeSyntax);
                    case RecordDeclarationSyntax recordDeclarationSyntax:
                        return this.PrintRecordDeclarationSyntax(recordDeclarationSyntax);
                    case PropertyDeclarationSyntax propertyDeclarationSyntax:
                        return this.PrintPropertyDeclarationSyntax(propertyDeclarationSyntax);
                    case PredefinedTypeSyntax predefinedTypeSyntax:
                        return this.PrintPredefinedTypeSyntax(predefinedTypeSyntax);
                    case ParameterSyntax parameterSyntax:
                        return this.PrintParameterSyntax(parameterSyntax);
                    case OperatorDeclarationSyntax operatorDeclarationSyntax:
                        return this.PrintOperatorDeclarationSyntax(operatorDeclarationSyntax);
                    case OmittedTypeArgumentSyntax omittedTypeArgumentSyntax:
                        return this.PrintOmittedTypeArgumentSyntax(omittedTypeArgumentSyntax);
                    case OmittedArraySizeExpressionSyntax omittedArraySizeExpressionSyntax:
                        return this.PrintOmittedArraySizeExpressionSyntax(omittedArraySizeExpressionSyntax);
                    case MethodDeclarationSyntax methodDeclarationSyntax:
                        return this.PrintMethodDeclarationSyntax(methodDeclarationSyntax);
                    case LocalFunctionStatementSyntax localFunctionStatementSyntax:
                        return this.PrintLocalFunctionStatementSyntax(localFunctionStatementSyntax);
                    case LiteralExpressionSyntax literalExpressionSyntax:
                        return this.PrintLiteralExpressionSyntax(literalExpressionSyntax);
                    case InterpolatedStringTextSyntax interpolatedStringTextSyntax:
                        return this.PrintInterpolatedStringTextSyntax(interpolatedStringTextSyntax);
                    case InterfaceDeclarationSyntax interfaceDeclarationSyntax:
                        return this.PrintInterfaceDeclarationSyntax(interfaceDeclarationSyntax);
                    case IndexerDeclarationSyntax indexerDeclarationSyntax:
                        return this.PrintIndexerDeclarationSyntax(indexerDeclarationSyntax);
                    case IncompleteMemberSyntax incompleteMemberSyntax:
                        return this.PrintIncompleteMemberSyntax(incompleteMemberSyntax);
                    case ImplicitElementAccessSyntax implicitElementAccessSyntax:
                        return this.PrintImplicitElementAccessSyntax(implicitElementAccessSyntax);
                    case IdentifierNameSyntax identifierNameSyntax:
                        return this.PrintIdentifierNameSyntax(identifierNameSyntax);
                    case FunctionPointerTypeSyntax functionPointerTypeSyntax:
                        return this.PrintFunctionPointerTypeSyntax(functionPointerTypeSyntax);
                    case ForStatementSyntax forStatementSyntax:
                        return this.PrintForStatementSyntax(forStatementSyntax);
                    case FieldDeclarationSyntax fieldDeclarationSyntax:
                        return this.PrintFieldDeclarationSyntax(fieldDeclarationSyntax);
                    case EventFieldDeclarationSyntax eventFieldDeclarationSyntax:
                        return this.PrintEventFieldDeclarationSyntax(eventFieldDeclarationSyntax);
                    case EventDeclarationSyntax eventDeclarationSyntax:
                        return this.PrintEventDeclarationSyntax(eventDeclarationSyntax);
                    case EnumMemberDeclarationSyntax enumMemberDeclarationSyntax:
                        return this.PrintEnumMemberDeclarationSyntax(enumMemberDeclarationSyntax);
                    case EnumDeclarationSyntax enumDeclarationSyntax:
                        return this.PrintEnumDeclarationSyntax(enumDeclarationSyntax);
                    case EmptyStatementSyntax emptyStatementSyntax:
                        return this.PrintEmptyStatementSyntax(emptyStatementSyntax);
                    case ElseClauseSyntax elseClauseSyntax:
                        return this.PrintElseClauseSyntax(elseClauseSyntax);
                    case ElementBindingExpressionSyntax elementBindingExpressionSyntax:
                        return this.PrintElementBindingExpressionSyntax(elementBindingExpressionSyntax);
                    case DiscardPatternSyntax discardPatternSyntax:
                        return this.PrintDiscardPatternSyntax(discardPatternSyntax);
                    case DiscardDesignationSyntax discardDesignationSyntax:
                        return this.PrintDiscardDesignationSyntax(discardDesignationSyntax);
                    case DefaultConstraintSyntax defaultConstraintSyntax:
                        return this.PrintDefaultConstraintSyntax(defaultConstraintSyntax);
                    case ConversionOperatorDeclarationSyntax conversionOperatorDeclarationSyntax:
                        return this.PrintConversionOperatorDeclarationSyntax(conversionOperatorDeclarationSyntax);
                    case ConstantPatternSyntax constantPatternSyntax:
                        return this.PrintConstantPatternSyntax(constantPatternSyntax);
                    case ClassDeclarationSyntax classDeclarationSyntax:
                        return this.PrintClassDeclarationSyntax(classDeclarationSyntax);
                    case BaseListSyntax baseListSyntax:
                        return this.PrintBaseListSyntax(baseListSyntax);
                    case BaseExpressionSyntax baseExpressionSyntax:
                        return this.PrintBaseExpressionSyntax(baseExpressionSyntax);
                    case AttributeListSyntax attributeListSyntax:
                        return this.PrintAttributeListSyntax(attributeListSyntax);
                    case ArgumentSyntax argumentSyntax:
                        return this.PrintArgumentSyntax(argumentSyntax);
                    case AnonymousMethodExpressionSyntax anonymousMethodExpressionSyntax:
                        return this.PrintAnonymousMethodExpressionSyntax(anonymousMethodExpressionSyntax);

                    default:
                        throw new Exception("Can't handle " + syntaxNode.GetType().Name);
                }
            }
            finally
            {
                depth--;
            }
        }
    }
}
