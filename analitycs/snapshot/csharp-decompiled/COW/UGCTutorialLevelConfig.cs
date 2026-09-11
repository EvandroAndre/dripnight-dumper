using GCommon;

namespace COW;

public class UGCTutorialLevelConfig : CSVBaseData, IGetId
{
	public string[] LoadingDesc;

	public string LoadingTitle;

	public string LoadingCDN;

	public ResourceID Template;

	public int ID;

	public int LevelID;

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
