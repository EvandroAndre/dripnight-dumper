using GCommon;

namespace COW;

public class AntiAddiction18LogoSwitchData : CSVBaseData, IGetId
{
	public string LockRegion;

	public string EndMatchCDNUrl;

	public string UGCOffLineLobbyCDNUrl;

	public string IPRegion;

	public string LobbyCDNUrl;

	public string UGCOffLineInGameCDNUrl;

	public string InGameCDNUrl;

	public string LoginCDNUrl;

	public uint ID;

	public bool UGCOffLineLobbySwitch;

	public bool LoginSwitch;

	public bool UGCOffLineInGameSwitch;

	public bool InGameSwitch;

	public bool LobbySwitch;

	public bool EndMatchSwitch;

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
