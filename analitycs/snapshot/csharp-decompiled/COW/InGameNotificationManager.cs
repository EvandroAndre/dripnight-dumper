using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal class InGameNotificationManager : IUIModelDataChangeObserver
{
	protected UIModelMatch m_Model;

	private Dictionary<int, int> Type2Priority;

	private bool m_TryKillAdditionalShow;

	private LRUCacheResource m_vfxCache;

	private const int VFX_CACHE_CAPACITY = 100;

	private Dictionary<int, ResourceID[]> m_EffectDic;

	public void Init()
	{
	}

	public void Destroy()
	{
	}

	private int GetPriorityByType(NotificationType ntype)
	{
		return 0;
	}

	public void DebugLog(object message)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void AddToQueue(NotificationData data, int Priority, bool weak = false)
	{
	}

	private void OnKill(MatchModelKillData pData)
	{
	}

	private void AddStackedKillToQueue(MatchModelKillData pData, Player localP, Player killer)
	{
	}

	private bool NeedShowActivityKillNotification(MatchModelKillData pData, Player beKiller, Player killer, Player localP)
	{
		return false;
	}

	private bool UseBuffECAKillNotification(MatchModelKillData pData, Player beKiller, Player killer, Player localP)
	{
		return false;
	}

	private int GetPriority(Player localP, Player killer, NotificationType ntype)
	{
		return 0;
	}

	private void AdditionalShowKill(MatchModelKillData pData)
	{
	}

	private void OnTargetPlayerKill(MatchModelKillData pData)
	{
	}

	private void OnKnockOtherDown(MatchModelKillData pData)
	{
	}

	public void ShowUIHudCounterAttack()
	{
	}

	private void TargetPlayerMetropolisKillIcon(int weaponID, uint scannerMarkAddCoin = 0u)
	{
	}

	private void TargetPlayerAssistKnockdownIcon()
	{
	}

	private void TargetPlayerKilledIcon(bool isHeadShot, BHGGAEEHJCO victimPlayerID, BHGGAEEHJCO killerID, int killStack = -1, uint scannerMarkAddCoin = 0u, NotificationKillType type = NotificationKillType.None)
	{
	}

	private void OnEscortBossRuinInfo(object[] data)
	{
	}

	private void OnPveHeadShot(object[] data)
	{
	}

	private void OnOniBossDead()
	{
	}

	private void OnAssistKonckDown(object[] data)
	{
	}

	public void ShowUIHudKillNotificationByType(EUIHudKillNotification type, BHGGAEEHJCO killerID, BHGGAEEHJCO beKilledID, bool isAceTeam, bool isCounterAttack = false, uint skinID = 0u)
	{
	}

	public void ShowFeedback(PLMGJPDLHHE msg)
	{
	}

	private ResourceID GetFeedbackSetpEffect(byte step, int category)
	{
		return default(ResourceID);
	}

	public static ResourceID GetFeedBackIconBg(int category)
	{
		return default(ResourceID);
	}

	public static ResourceID GetFeedBackLabelBg(int category)
	{
		return default(ResourceID);
	}

	private void OnShowNotify(object[] data)
	{
	}

	public static bool ShowPrivilegeNotificationIcon(EPrivilegeKillIconType inIconType, uint inSkinID)
	{
		return false;
	}

	public static bool GetPrivilegeKillIconRes(EPrivilegeKillIconType inIconType, uint inSkinID, out ResourceID outResID)
	{
		outResID = default(ResourceID);
		return false;
	}

	public static bool GetPrivilegeLabelRes(uint inSkinID, out ResourceID outResID)
	{
		outResID = default(ResourceID);
		return false;
	}
}
