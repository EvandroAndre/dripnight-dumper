using GCommon;

namespace COW;

public class SeasonYearConfig : CSVBaseData, IGetId
{
	public string Year;

	public string ExtralCDN2;

	public string ExtralCDN1;

	public string MainBGCDN;

	public string SeasonYearTitle;

	public string SeasonTripRewardBG;

	public string SeasonKickOffSprite;

	public string SeasonTripSprite;

	public string MainPageUnLightUpCSIcon;

	public string MainPageUnLightUpBRIcon;

	public string MainPageUnOpenCSIcon;

	public string MainPageUnOpenBRIcon;

	public string MainPageInProgressCSIcon;

	public string MainPageInProgressBRIcon;

	public string EntranceVFXResId;

	public string Icon;

	public uint SeasonYearId;

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
