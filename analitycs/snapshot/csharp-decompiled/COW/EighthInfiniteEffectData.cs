using GCommon;

namespace COW;

public class EighthInfiniteEffectData : CSVBaseData, IGetId
{
	public string DescParam;

	public string Params;

	public string EffectName;

	public string EffectDesc;

	public string BRLandGetTipsKey;

	public string FlyToUIName;

	public string FlyToUIView;

	public uint Id;

	public uint DurationTime;

	public uint Type;

	public ResourceID IconRes;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
