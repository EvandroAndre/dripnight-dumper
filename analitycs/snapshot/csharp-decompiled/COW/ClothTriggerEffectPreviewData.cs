using GCommon;

namespace COW;

public class ClothTriggerEffectPreviewData : CSVBaseData, IGetId
{
	public uint ID;

	public uint MultipleTriggerType;

	public ResourceID PreviewAnimMale;

	public ResourceID PreviewAnimFemale;

	public string Title;

	public string Description;

	public bool IsLoop;

	public float IdleDuration;

	public int RotationY;

	public string EffectTriggerIconName;

	public uint FeatureShowType;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
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
