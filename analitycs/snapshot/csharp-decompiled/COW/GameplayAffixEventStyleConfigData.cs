using GCommon;

namespace COW;

public class GameplayAffixEventStyleConfigData : CSVBaseData
{
	public uint EventID;

	public bool ShowAffixCarousel_BRrank;

	public bool ShowProtectPointsCarousel_BRrank;

	public bool ShowProgress_BRrank;

	public string GameModeDropdownCollapseTitleKey_BRrank;

	public string GameModeDropdownExpandTitleKey_BRrank;

	public ResourceID GameModePreviewRes_BRrank;

	public ResourceID GameModeDropdownRes_BRrank;

	public ResourceID GameModeDropdownCarouselItemRes_BRrank;

	public uint ModePageLiveEffectsID_BRrank;

	public string CoverNetworkTexture_BRrank;

	public bool ShowProtectPointsCarousel_CSrank;

	public ResourceID SpecialPlayDropdownRes_CSrank;

	public ResourceID DetailsContentTipsBtn_Casual;

	public ResourceID DetailsContentPopup_Casual;

	public uint OptionalItemID1;

	public uint OptionalItemID2;

	public ResourceID EventTitleBG;

	public ResourceID EventTitleLittleIcon;

	public string NewbieDropdownLimitDesc;

	public string NewbieDropdownDesc;

	public string[] EventTitleAdapt;

	public override string GetPrimaryKey()
	{
		return null;
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
