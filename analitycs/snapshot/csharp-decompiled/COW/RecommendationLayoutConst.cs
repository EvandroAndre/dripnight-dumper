namespace COW;

public static class RecommendationLayoutConst
{
	public const int CellWidth3Col = 384;

	public const int CellWidth4Col = 288;

	public const int CellHeight3Col = 238;

	public const int CellHeight4Col = 194;

	public const int BaseH3Col = 296;

	public const int BaseH4Col = 252;

	public const int MapContainerWidth3Col = 364;

	public const int MapContainerHeight3Col = 164;

	public const int MapContainerWidth4Col = 268;

	public const int MapContainerHeight4Col = 120;

	public static bool Use3Col(int displayNum)
	{
		return false;
	}

	public static int GetColumns(int displayNum)
	{
		return 0;
	}

	public static int CalcParentYPosition(int displayNum, int itemCount)
	{
		return 0;
	}

	public static int CalcInnerYPosition(int displayNum, int itemCount)
	{
		return 0;
	}
}
