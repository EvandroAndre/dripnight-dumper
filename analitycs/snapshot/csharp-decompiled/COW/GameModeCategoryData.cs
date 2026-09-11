using System.Collections.Generic;
using GCommon;

namespace COW;

public class GameModeCategoryData : CSVBaseData
{
	public EGameModeCategory m_Category;

	public List<uint> m_GameModes;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public bool ContainInCategory(uint gamemodeid)
	{
		return false;
	}

	public static ResourceID GetLadderIconByGameMode(uint gamemodeid, uint rank)
	{
		return default(ResourceID);
	}

	public static EGameModeCategory GetGameModeCategory(uint gamemodeid)
	{
		return EGameModeCategory.None;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
