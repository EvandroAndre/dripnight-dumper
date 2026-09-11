using GCommon;
using message;

namespace COW;

public class HuntingGroundRoundInfoData : CSVBaseData
{
	public int ID;

	public int RoundID;

	public int Difficulty;

	public BNEFLFAMOCE RoundTargetType;

	public string RoundTitleName;

	public string StageName;

	public string RoundName;

	public string[] RoundNameParam;

	public string MissonName;

	public string[] MissonNameParam;

	public int RoundTime;

	public int ZombieNum;

	public bool IsBossRound;

	public bool NeedInitDragonHeadType;

	public int BossHPLayerCount;

	public int EnterCutSceneIndex;

	public int LeaveCutSceneIndex;

	public int LevelID;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
