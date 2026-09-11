using GCommon;

namespace COW;

public class AccountSecurityData : CSVBaseData, IGetId
{
	public uint ID;

	public string Region;

	public string Country;

	public uint SupportVerifyAccess;

	public uint RecommendVerifyAccess;

	public bool Reminder;

	public int BindCooldown;

	public int RebindCooldown;

	public string[] Language;

	public string SecurityCDN;

	public string AccountSwapCDN;

	public uint Level;

	public uint SupportPhoneVerifyAccess;

	public uint RecommendPhoneVerifyAccess;

	public bool IsDefaultFromIpData;

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
