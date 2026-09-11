using GCommon;

namespace COW;

public class AccountBindPhoneData : CSVBaseData, IGetId
{
	public uint ID;

	public string Region;

	public string Country;

	public string[] AreaCode;

	public int NumDown;

	public int NumUp;

	public int FrontShow;

	public int EndShow;

	public int DailyLimitOTP;

	public int SendOTPCD;

	public int DailyLimitVertify;

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
