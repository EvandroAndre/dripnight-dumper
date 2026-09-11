using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace COW.Gameplay.UGC.BlockEdit;

public class ExpressionDefine
{
	private static Regex TokenReg;

	private readonly Stack<string> ExpressionStack;

	private string[] ExpressionTokens;

	private bool AssignToReturnType;

	private int AssignToValueByIndex;

	private string SourceExpression;

	public bool FromExpression(string source, int valueCount)
	{
		return false;
	}

	public void Execute(BlockData blockData)
	{
	}

	private string CalculateExpression(BlockData blockData)
	{
		return null;
	}

	private bool CalculateToken(Stack<string> stack, string token, BlockData blockData, ref int valueIndex)
	{
		return false;
	}
}
