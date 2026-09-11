using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelGameplayAffix : UIBaseModel
{
	private const uint m_SafeGameModeMax = 429496u;

	private const string m_GameplayAffixVisitedPlayerPrefsKey = "GameplayAffix_EventId{0}_GameMode{1}_MatchMode{2}_VisitedTime";

	private readonly Dictionary<uint, List<GameplayAffixEventData>> m_ModeToAffixes;

	private readonly Dictionary<uint, GameplayAffixEventStyleDesc> m_ServerStyleDescs;

	private const uint m_GameplayAffixEventOpenBossInvade = 1u;

	public bool ShowKillDragonInMatchResult;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	private static uint GetModeHashCode(uint gameMode, uint matchMode)
	{
		return 0u;
	}

	private static bool IsGameplayAffixDescValid(GameplayAffixDesc desc, ulong currentTimestamp)
	{
		return false;
	}

	private GameplayAffixEventData GetCurrentEventDataWithModeInternal(uint gameMode, uint matchMode)
	{
		return null;
	}

	private bool GetCurrentStyleConfigDataWithMode(uint gameMode, uint matchMode, out GameplayAffixEventStyleConfigData configData)
	{
		configData = null;
		return false;
	}

	private bool TryGetCurrentServerStyleDesc(uint gameMode, uint matchMode, out GameplayAffixEventStyleDesc desc)
	{
		desc = null;
		return false;
	}

	public void ProcessServerEventStyleList(List<GameplayAffixEventStyleDesc> list)
	{
	}

	public void ProcessGameplayAffixDesc(CSGetGameplayAffixDescRes res)
	{
	}

	public bool IsAffixesOpenedWithMode(uint gameMode, uint matchMode)
	{
		return false;
	}

	public bool IsAffixesVisitedWithMode(uint gameMode, uint matchMode)
	{
		return false;
	}

	public uint[] GetLobbyDisplayAffixesWithMode(uint gameMode, uint matchMode)
	{
		return null;
	}

	public GameplayAffixEventData GetCurrentEventDataWithMode(uint gameMode, uint matchMode)
	{
		return null;
	}

	public void SetAffixesVisitedWithMode(uint gameMode, uint matchMode)
	{
	}

	public List<MatchResultTaskInfo> GetBossMatchResultTaskInfosList()
	{
		return null;
	}

	public int GetBossProgress()
	{
		return 0;
	}

	public bool IsSpecialBossActivity()
	{
		return false;
	}

	public bool IsNextMatchCanSlayDragon()
	{
		return false;
	}

	public bool HasSlayDragonBuff()
	{
		return false;
	}

	public void OnSlayDragonCntChange(Item it, Item originItem)
	{
	}

	public bool IsAffixCarouselNeededOnTitle_BR_Rank()
	{
		return false;
	}

	public bool IsProgressNeededOnTitle_BR_Rank()
	{
		return false;
	}

	public bool IsShowProtectPointsCarousel_BRrank()
	{
		return false;
	}

	public ResourceID GetGameModePreviewRes_BR_Rank()
	{
		return default(ResourceID);
	}

	public ResourceID GetGameModeDropdownRes_BR_Rank()
	{
		return default(ResourceID);
	}

	public ResourceID GetGameModeDropdownCarouselItemRes_BR_Rank()
	{
		return default(ResourceID);
	}

	public ResourceID GetGameModeDetailsContentTipsBtnRes(uint gameMode, uint matchMode)
	{
		return default(ResourceID);
	}

	public ResourceID GetGameModeDetailsContentPopupRes(uint gameMode, uint matchMode)
	{
		return default(ResourceID);
	}

	public uint GetModePageLiveEffectsID_BR_Rank()
	{
		return 0u;
	}

	public string GetCoverNetworkTexture_BR_Rank()
	{
		return null;
	}

	public string GetCoverNetworkTexture_CS_Rank()
	{
		return null;
	}

	public uint GetCDNLiveEffectsID_BR_Rank()
	{
		return 0u;
	}

	public uint GetCDNLiveEffectsID_CS_Rank()
	{
		return 0u;
	}

	public string GetGameModeDropdownCollapseTitleKey_BR_Rank()
	{
		return null;
	}

	public string GetGameModeDropdownExpandTitleKey_BR_Rank()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
