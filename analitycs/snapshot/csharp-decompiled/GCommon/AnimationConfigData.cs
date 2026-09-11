using System.Collections.Generic;

namespace GCommon;

public class AnimationConfigData : CSVBaseData
{
	private static Dictionary<int, int> sGenID;

	private static Dictionary<int, AnimationConfigData> hashToData;

	public AnimationID AnimID;

	public string AnimIDName;

	public string TargetStateName;

	public int TargetStateNameHash;

	public float TransitionDuration;

	public bool NeedWaitForFinished;

	public float EndCutTime;

	public bool ToDefault;

	public AnimationID FinishedID;

	public bool NeedDynamicLoad;

	public string[] ResourceName;

	public float IKWeight;

	public int LayerIndex;

	public string FinishedName;

	private static int GetNextID(int layerIndex)
	{
		return 0;
	}

	public static void OnCleanup()
	{
	}

	public static AnimationConfigData GetFinishConfigData(int hash)
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	private AnimationID GetAnimationID(string from, int layer)
	{
		return default(AnimationID);
	}

	public override bool AfterParseData()
	{
		return false;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
