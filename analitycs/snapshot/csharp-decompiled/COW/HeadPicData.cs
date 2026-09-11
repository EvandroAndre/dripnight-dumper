using GCommon;
using proto;

namespace COW;

public class HeadPicData : CSVBaseData, IGetId
{
	public ulong accountId;

	public string external_icon;

	public ResourceID iconRes;

	public EAccount.ExternalIconStatus status;

	public EAccount.ExternalIconShowType show_type;

	public uint iID;

	public uint sortId;

	public ESourceType sourceTypeKey;

	public string iconResName;

	public uint avatarID;

	public ResourceID effectRes;

	public bool NotInCDN;

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

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

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
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
