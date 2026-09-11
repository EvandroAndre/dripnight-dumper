using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIBRMatchReviewBattleLogController : UIBaseController
{
	private struct IntegrateGroup
	{
		public int HeadIdx;

		public int EndIdxExclusive;

		public long CloseMs;
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public UIBRMatchReviewBattleLogController _003C_003E4__this;

		public UITable2 tableRef;

		internal UITable2.IUITable2Item _003COnUIInit_003Eb__0()
		{
			return null;
		}
	}

	private static readonly Vector2 LOG_ITEM_SIZE;

	private static readonly UITable2.Margin LOG_ITEM_MARGIN;

	private const int LOG_ITEM_TYPE = 0;

	private const string LOG_ITEM_SLIDE_IN_SOUND = "SOUND_UI_BRMATCHREVIEW_SLIDEIN";

	private UIBRMatchReviewBattleLogView m_View;

	private List<HJNFDCJPPDE> m_Events;

	private Dictionary<uint, NGKNJIMOHBM> m_DictPlayerIdToInfo;

	private Dictionary<uint, int> m_DictPlayerTeamIndex;

	private List<NGKNJIMOHBM> m_MyTeamPlayers;

	private List<IntegrateGroup> m_Groups;

	private readonly Dictionary<int, BRMatchReviewDisplayEvent> m_MergedReviveDisplayEvents;

	private readonly HashSet<int> m_SurfacedGroupIndices;

	private HashSet<uint> m_VisiblePlayerFilter;

	private HJNFDCJPPDE m_SelectedEvent;

	private uint m_LocalPlayerID;

	private uint m_MapID;

	private uint m_MapLayerID;

	private bool m_IsTeammatesKillShow;

	private long m_PlaybackEndTimeMs;

	private ResourceID m_LogItemSlideInSound;

	private bool m_LogItemSlideInSoundResolved;

	private int m_LastLogItemSlideInSoundFrame;

	private readonly HashSet<HJNFDCJPPDE> m_PendingEntranceEvents;

	private UIBRMatchReviewController ReviewCtrl => null;

	public Dictionary<uint, NGKNJIMOHBM> GetPlayerIdToInfo()
	{
		return null;
	}

	public bool IsLocalPlayer(uint playerId)
	{
		return false;
	}

	public int GetPlayerTeamIndex(uint playerId)
	{
		return 0;
	}

	public uint GetMapID()
	{
		return 0u;
	}

	public uint GetMapLayerID()
	{
		return 0u;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void NotifyLogItemInAnimationPlayed()
	{
	}

	private ResourceID GetLogItemSlideInSound()
	{
		return default(ResourceID);
	}

	public bool TryConsumeEntranceAnimation(HJNFDCJPPDE eventData)
	{
		return false;
	}

	private static HJNFDCJPPDE GetEntranceKey(HJNFDCJPPDE eventData)
	{
		return null;
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

	public void SetData(List<HJNFDCJPPDE> events, Dictionary<uint, NGKNJIMOHBM> dictPlayerIdToInfo, uint localPlayerID, List<NGKNJIMOHBM> myTeamPlayers = null, long playbackEndTimeMs = 0L, uint mapID = 0u, uint mapLayerID = 0u, uint groupMode = 0u, bool isTeammatesKillShow = true)
	{
	}

	private void BuildIntegrateGroups()
	{
	}

	private static void SortIntegrateGroupsByCloseTime(List<IntegrateGroup> groups)
	{
	}

	private static int CompareIntegrateGroups(IntegrateGroup a, IntegrateGroup b)
	{
		return 0;
	}

	private static bool IsImmediateBattleLogEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private long ClampGroupCloseMs(long closeMs)
	{
		return 0L;
	}

	private static long GetLogIntegrateMs()
	{
		return 0L;
	}

	public void UpdateData(float currentTimeMs)
	{
	}

	private bool InsertGroupRows(IntegrateGroup grp, HashSet<int> mergedReviveEventIndices, bool allowMergedKillUpdate, List<HJNFDCJPPDE> pendingMergedKillFxEvents)
	{
		return false;
	}

	private void RebuildSurfacedLog(bool resetPos)
	{
	}

	private List<HJNFDCJPPDE> BuildSurfacedLogRows()
	{
		return null;
	}

	private static void AddRebuildLogRow(List<HJNFDCJPPDE> rows, Dictionary<BRMatchReviewDisplayEvent, int> mergedKillRowIndexMap, HJNFDCJPPDE displayEvent)
	{
	}

	private bool TryRefreshMergedKillRow(HJNFDCJPPDE displayEvent, List<HJNFDCJPPDE> pendingMergedKillFxEvents)
	{
		return false;
	}

	private bool TryFindMergedKillLogItem(BRMatchReviewDisplayEvent mergeRoot, out int itemIndex, out UIBRMatchReviewLogItemController logItemCtrl)
	{
		itemIndex = default(int);
		logItemCtrl = null;
		return false;
	}

	private void ReplayPendingMergedKillFx(List<HJNFDCJPPDE> pendingMergedKillFxEvents)
	{
	}

	private static void AddPendingMergedKillFx(HJNFDCJPPDE displayEvent, List<HJNFDCJPPDE> pendingMergedKillFxEvents)
	{
	}

	private static bool IsSameMergedKillRoot(HJNFDCJPPDE eventData, BRMatchReviewDisplayEvent mergeRoot)
	{
		return false;
	}

	private static bool IsKillRootDisplayEvent(BRMatchReviewDisplayEvent displayEvent)
	{
		return false;
	}

	private static bool IsMergedKillUpdateEvent(HJNFDCJPPDE eventData)
	{
		return false;
	}

	private static bool IsMergedKillUpdateEvent(BRMatchReviewDisplayEvent displayEvent)
	{
		return false;
	}

	public void ClearLog()
	{
	}

	public void OnLogItemClicked(HJNFDCJPPDE eventData)
	{
	}

	public void OnLogItemClicked(long timeMs)
	{
	}

	public bool IsEventSelected(HJNFDCJPPDE eventData)
	{
		return false;
	}

	private void SetSelectedEvent(HJNFDCJPPDE eventData)
	{
	}

	private static long GetLogClickTimeMs(HJNFDCJPPDE eventData)
	{
		return 0L;
	}

	private void RefreshVisibleItemSelectedState()
	{
	}

	public void SetVisiblePlayerFilter(HashSet<uint> visiblePlayerIds)
	{
	}

	public void SetVisiblePlayerFilter(HashSet<uint> visiblePlayerIds, float currentTimeMs)
	{
	}

	private static HashSet<uint> CloneVisiblePlayerFilter(HashSet<uint> visiblePlayerIds)
	{
		return null;
	}

	private void SyncSurfacedGroupsToTime(long currentTimeMs)
	{
	}

	private bool IsEventVisible(HJNFDCJPPDE evt)
	{
		return false;
	}

	private bool ShouldShowKillEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private static bool IsBattleLogKillEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private bool IsEventPlayerVisible(HJNFDCJPPDE evt)
	{
		return false;
	}

	private bool IsRepresentativeBooyahEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private bool IsPlayerVisible(uint playerId)
	{
		return false;
	}

	private int GetVisibleFilterLogValue()
	{
		return 0;
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
