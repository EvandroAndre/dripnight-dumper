using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIBRMatchReviewLogItemController : UIBaseController, UITable2.IUITable2Item
{
	private static readonly Dictionary<int, string> TEAM_BADGE_SPRITES;

	private const string ANIM_IN = "UIFX_UIBRMatchReviewLogItem_In";

	private const string SELF_PLAYER_NAME_COLOR_TAG = "FFBA00";

	private const int MAX_TEAM_MEMBER_SYMBOL_SLOT = 4;

	private const string LOG_KILL_WITH_POI_LOC_KEY = "T_54_TSY_MATCHREVIEW_LOG_KILL";

	private const string LOG_KILL_OTHERS_LOC_KEY = "T_54_TSY_MATCHREVIEW_LOG_KILL_OTHERS";

	private UIBRMatchReviewLogItemView m_View;

	private HJNFDCJPPDE m_CachedEvent;

	private UIBRMatchReviewBattleLogController BattleLogCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnItemClicked()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	private void PlayInAnimation()
	{
	}

	private void SampleInAnimationToEnd()
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public HJNFDCJPPDE GetCachedEvent()
	{
		return null;
	}

	public void RefreshMergedKillUpdate(HJNFDCJPPDE eventData)
	{
	}

	private void RefreshLogItem(HJNFDCJPPDE eventData, bool forceReplayKillMergeFx)
	{
	}

	private static long GetDisplayMs(HJNFDCJPPDE eventData)
	{
		return 0L;
	}

	public void RefreshSelectedState()
	{
	}

	private void SetSelected(bool isSelected)
	{
	}

	private void ApplyActionLabel(HJNFDCJPPDE eventData)
	{
	}

	private static string GetActionLocKey(HJNFDCJPPDE eventData, bool hasEventPlaceName)
	{
		return null;
	}

	private static object[] BuildActionLocParams(HJNFDCJPPDE eventData, string primaryPlayerName, string revivedPlayerBadges, string eventPlaceName)
	{
		return null;
	}

	private static int GetKillCount(HJNFDCJPPDE eventData)
	{
		return 0;
	}

	private void RefreshKillMergeCountUI(HJNFDCJPPDE eventData, bool forceReplayFx = false)
	{
	}

	private static bool TryGetMergedKillCount(HJNFDCJPPDE eventData, out int killCount)
	{
		killCount = default(int);
		return false;
	}

	private int GetTeamBadgeIndex(uint playerId)
	{
		return 0;
	}

	private string GetPlayerDisplayName(uint playerId)
	{
		return null;
	}

	private NGKNJIMOHBM GetPlayerInfo(uint playerId)
	{
		return null;
	}

	private string GetEventPlaceName(HJNFDCJPPDE eventData)
	{
		return null;
	}

	private static string ResolveEventPlaceName(int poiID, uint mapID, uint mapLayerID)
	{
		return null;
	}

	private static List<DLOGLJCCJPJ> GetPlaceNameDatas(uint mapID)
	{
		return null;
	}

	private static DLOGLJCCJPJ FindPlaceNameDataByPoiID(List<DLOGLJCCJPJ> placeNameDatas, int poiID)
	{
		return null;
	}

	private static string GetLocalizedPlaceName(DLOGLJCCJPJ placeData, uint mapID, uint mapLayerID)
	{
		return null;
	}

	private string GetRevivedPlayerBadgeText(HJNFDCJPPDE eventData)
	{
		return null;
	}

	private List<uint> GetBadgeRevivedPlayerIds(HJNFDCJPPDE eventData)
	{
		return null;
	}

	private List<uint> GetRevivedPlayerIds(HJNFDCJPPDE eventData)
	{
		return null;
	}

	private static bool TryGetRevivedPlayerId(HJNFDCJPPDE eventData, out uint revivedPlayerId)
	{
		revivedPlayerId = default(uint);
		return false;
	}

	private static bool IsSingleActorReviveSubType(HIMPICPLPMB subType)
	{
		return false;
	}

	private void ApplyTeamBadgeSymbols(UILabel label, HJNFDCJPPDE eventData)
	{
	}

	private static void UpsertSymbol(UILabel label, int slotIndex, string sequence, string spriteName)
	{
	}

	private uint GetPrimaryActionPlayerId(HJNFDCJPPDE eventData)
	{
		return 0u;
	}

	private bool TryGetFirstRevivedPlayerId(HJNFDCJPPDE eventData, out uint playerId)
	{
		playerId = default(uint);
		return false;
	}

	private static bool IsRevivedPlayerSubjectEvent(HJNFDCJPPDE eventData)
	{
		return false;
	}

	private static string GetTeamBadgeSpriteName(int teamIndex)
	{
		return null;
	}

	private static void ApplyEventSprite(UISprite target, HJNFDCJPPDE eventData)
	{
	}

	private static string GetEventSpriteName(HJNFDCJPPDE eventData)
	{
		return null;
	}

	private static string GetSpecialEventSpriteName(PHOPGMDJODO subType)
	{
		return null;
	}

	private static string GetTopLevelLocKey(NOOPBILFLIJ eventType)
	{
		return null;
	}

	private static string GetReviveLocKey(HIMPICPLPMB subType)
	{
		return null;
	}

	private static string GetSpecialEventLocKey(PHOPGMDJODO subType)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
