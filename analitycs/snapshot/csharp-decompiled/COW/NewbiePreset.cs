using GCommon;

namespace COW;

public class NewbiePreset : CSVBaseData, IGetId
{
	public string Text1;

	public string Text2;

	public string Text5;

	public string Text4;

	public string Text3;

	public uint Type;

	public uint AvatarId4;

	public uint AvatarId3;

	public uint AvatarId2;

	public uint AvatarId1;

	public uint Level;

	public uint Stage;

	public uint ID;

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
