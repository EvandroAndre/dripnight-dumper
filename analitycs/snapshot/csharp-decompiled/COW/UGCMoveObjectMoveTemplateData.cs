using COW.GamePlay;
using GCommon;

namespace COW;

public class UGCMoveObjectMoveTemplateData : CSVBaseData
{
	public uint ID;

	public LevelMotionPlatform.PMCEMHJGDFH MotionType;

	public float MotionValueX;

	public float MotionValueY;

	public float MotionValueZ;

	public float MotionTime;

	public float StayTime;

	public bool IsReset;

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
