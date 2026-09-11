using GCommon;

namespace COW;

public class IngameFeedbackData : CSVBaseData, IGetId
{
	public uint ID;

	public int Type;

	public int Category;

	public ResourceID VFX1P;

	public ResourceID Sound1P;

	public ResourceID VFX3P;

	public ResourceID Sound3P;

	public int BroadcastID;

	public string[] Parameters;

	public string LabelKey;

	public ResourceID[] IconRes;

	public uint Priority;

	public string Desc;

	public ResourceID ReplayIcon;

	public ResourceID EffectResName;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
