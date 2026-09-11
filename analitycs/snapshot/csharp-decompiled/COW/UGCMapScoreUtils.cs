namespace COW;

public static class UGCMapScoreUtils
{
	public enum ECheckItem
	{
		MapName = 1,
		MapDescription,
		MapCover,
		MapDesigned,
		MapTested,
		MapGenre,
		MapTags
	}

	public static bool NeedShowChecklist(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public static int RecalculateMapScore(SceneEditSlotInfo slotInfo)
	{
		return 0;
	}

	public static int GetCheckItemMaxScore(int itemId)
	{
		return 0;
	}

	public static int GetCheckItemScore(int itemId, SceneEditSlotInfo slotInfo)
	{
		return 0;
	}

	public static bool IsCheckItemOpen(ECheckItem item)
	{
		return false;
	}

	public static int GetMapScoreRank(int mapScore)
	{
		return 0;
	}

	public static bool CheckMapName(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public static bool CheckMapDescription(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public static bool CheckMapCover(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public static bool CheckMapDesigned(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public static bool CheckMapTested(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public static bool CheckMapGenreID(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public static bool CheckMapTags(SceneEditSlotInfo slotInfo)
	{
		return false;
	}
}
