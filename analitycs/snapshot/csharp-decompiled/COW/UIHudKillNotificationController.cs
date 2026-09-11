using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudKillNotificationController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHudKillNotificationView m_View;

	private List<UIHudKillNotificationItem> m_Items;

	private List<UIHudKillNotificationItem> m_MiniItems;

	private UIWeaponKillNotificationItemController m_WeaponKillNotification;

	private UIHudWeaponKillNotificationItem m_WeaponKillNotificationItem;

	private UIModelMatch m_MatchModel;

	private Queue<PendingNotification> m_PendingNotificationRegular;

	private Queue<PendingNotification> m_PendingNotificationWeaponWithSkin;

	private Queue<PendingNotification> m_PendingNotificationPool;

	private Timer m_AddNotificationCoolDown;

	private Dictionary<ushort, string> m_LevelToTipsLoc;

	private bool m_IsMiniTips;

	private int m_TeamColor;

	private UIHudKillNotificationItem templateItem;

	private UIHudKillNotificationItem templateMiniItem;

	private Vector3 NormalItemGridOriginalPosition;

	private Vector3 MiniItemGridOriginalPosition;

	private UIBaseController m_HudCoveredBy;

	private bool m_OnlyShowSelfWeaponSkill;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void PreCreateNotiItems()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetHudCoveredBy(UIBaseController ctrl)
	{
	}

	private void CreateNotiItem(bool isMini)
	{
	}

	private void RefreshKillNotiPosition(object[] param)
	{
	}

	private void Update()
	{
	}

	private void UpdateNewStyleWeaponKill(float gameTime)
	{
	}

	private void UpdateOldStyleWeaponKill(float gameTime)
	{
	}

	private void OnHypeLevelChanged(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void AddPendingNotificationToQueue(PendingNotification notification)
	{
	}

	private PendingNotification GetPendingNotificationFromPool()
	{
		return null;
	}

	private uint CheckWeaponSkinId(uint skinId)
	{
		return 0u;
	}

	public void DebugEnqueueNotification(EPendingNotificationType type, string killer = "Killer_Debug", string victim = "Victim_Debug", string weaponName = "Rifle", uint weaponId = 0u, float visibleTime = 3f)
	{
	}

	public static UIHudKillNotificationController GetOpenedInstance()
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void UpdateMiniTips(bool isMini)
	{
	}

	private void OnIngameTipsChanged(object[] data)
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
