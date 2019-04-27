//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\Johnny\Documents\programming\XBabyScript\BabyScriptParser.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace XBabyScript.Compile {

    using XBabyScript.Compile;

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="BabyScriptParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface IBabyScriptParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.document"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDocument([NotNull] BabyScriptParser.DocumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.document"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDocument([NotNull] BabyScriptParser.DocumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] BabyScriptParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] BabyScriptParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.exprEof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprEof([NotNull] BabyScriptParser.ExprEofContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.exprEof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprEof([NotNull] BabyScriptParser.ExprEofContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.tableDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableDef([NotNull] BabyScriptParser.TableDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.tableDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableDef([NotNull] BabyScriptParser.TableDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.tableRowDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableRowDef([NotNull] BabyScriptParser.TableRowDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.tableRowDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableRowDef([NotNull] BabyScriptParser.TableRowDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.squareList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSquareList([NotNull] BabyScriptParser.SquareListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.squareList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSquareList([NotNull] BabyScriptParser.SquareListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.braceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBraceList([NotNull] BabyScriptParser.BraceListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.braceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBraceList([NotNull] BabyScriptParser.BraceListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] BabyScriptParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] BabyScriptParser.AtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.elementName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementName([NotNull] BabyScriptParser.ElementNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.elementName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementName([NotNull] BabyScriptParser.ElementNameContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Element</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElement([NotNull] BabyScriptParser.ElementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Element</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElement([NotNull] BabyScriptParser.ElementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Assign</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssign([NotNull] BabyScriptParser.AssignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Assign</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssign([NotNull] BabyScriptParser.AssignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Increment</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIncrement([NotNull] BabyScriptParser.IncrementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Increment</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIncrement([NotNull] BabyScriptParser.IncrementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Decrement</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecrement([NotNull] BabyScriptParser.DecrementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Decrement</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecrement([NotNull] BabyScriptParser.DecrementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AdditionAssign</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditionAssign([NotNull] BabyScriptParser.AdditionAssignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditionAssign</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditionAssign([NotNull] BabyScriptParser.AdditionAssignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SubtractionAssign</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubtractionAssign([NotNull] BabyScriptParser.SubtractionAssignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SubtractionAssign</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubtractionAssign([NotNull] BabyScriptParser.SubtractionAssignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Delete</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete([NotNull] BabyScriptParser.DeleteContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Delete</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete([NotNull] BabyScriptParser.DeleteContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Text</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterText([NotNull] BabyScriptParser.TextContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Text</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitText([NotNull] BabyScriptParser.TextContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BlockComment</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockComment([NotNull] BabyScriptParser.BlockCommentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BlockComment</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockComment([NotNull] BabyScriptParser.BlockCommentContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SlashComment</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSlashComment([NotNull] BabyScriptParser.SlashCommentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SlashComment</c>
	/// labeled alternative in <see cref="BabyScriptParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSlashComment([NotNull] BabyScriptParser.SlashCommentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.elementAttributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementAttributes([NotNull] BabyScriptParser.ElementAttributesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.elementAttributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementAttributes([NotNull] BabyScriptParser.ElementAttributesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute([NotNull] BabyScriptParser.AttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute([NotNull] BabyScriptParser.AttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.attributeValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributeValue([NotNull] BabyScriptParser.AttributeValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.attributeValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributeValue([NotNull] BabyScriptParser.AttributeValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ElementEmptyChildren</c>
	/// labeled alternative in <see cref="BabyScriptParser.elementChildren"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementEmptyChildren([NotNull] BabyScriptParser.ElementEmptyChildrenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ElementEmptyChildren</c>
	/// labeled alternative in <see cref="BabyScriptParser.elementChildren"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementEmptyChildren([NotNull] BabyScriptParser.ElementEmptyChildrenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ElementChildrenBlock</c>
	/// labeled alternative in <see cref="BabyScriptParser.elementChildren"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementChildrenBlock([NotNull] BabyScriptParser.ElementChildrenBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ElementChildrenBlock</c>
	/// labeled alternative in <see cref="BabyScriptParser.elementChildren"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementChildrenBlock([NotNull] BabyScriptParser.ElementChildrenBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BabyScriptParser.lookupChain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLookupChain([NotNull] BabyScriptParser.LookupChainContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BabyScriptParser.lookupChain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLookupChain([NotNull] BabyScriptParser.LookupChainContext context);
}
} // namespace XBabyScript.Compile
