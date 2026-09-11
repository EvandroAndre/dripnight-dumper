using System.Collections.Generic;
using GCommon;

namespace COW;

public class UGCOptionalResConfigData : CSVBaseData
{
	public enum EUGCOptionalResLevel
	{
		NecessaryResource = 1,
		EditorNecessaryResource,
		NotNecessaryResource
	}

	public enum EUGCOptionalResDownloadType
	{
		EnterGame,
		EnterCraftLand,
		RandomMatch
	}

	public string ResName;

	public ResourceID ResId;

	private readonly List<int> ObCodes;

	private readonly List<int> ResLevels;

	private string CompatibleInfoForDebug;

	public bool IsRecommended;

	private bool RandomMatchDependent;

	private int[] DependantConfigIDs;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public bool IsNecessary(int OBCode, EUGCOptionalResDownloadType downloadType)
	{
		return false;
	}

	public bool IsNecessary(int configID)
	{
		return false;
	}

	private void PasteCompatibleInfo(string compatibleInfo)
	{
	}

	private EUGCOptionalResLevel GetLevelByOBCode(int OBCode)
	{
		return (EUGCOptionalResLevel)0;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
