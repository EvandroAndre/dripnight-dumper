using GCommon;
using UnityEngine;

namespace COW;

public class UIHudKillNotificationItem : MonoBehaviour
{
	public GameObject InfoContainer;

	public UILabel text;

	public GameObject m_RedEnvelopeGo;

	public UISprite m_NotifyIcon;

	public UILabel m_RedEnvelopeLabel;

	public GameObject m_RedEnvelopeBGTradition;

	public GameObject m_RedEnvelopeBGCompact;

	public UISprite m_BonusIcon;

	public UIRelocateToLabelSprite m_EPKiller;

	public UIRelocateToLabelSprite m_EPBeKiller;

	public UIRelocateToLabelSprite m_BPKiller;

	public UIRelocateToLabelSprite m_BPBeKiller;

	public UIRelocateToLabelSprite m_BadgeKiller;

	public UIRelocateToLabelSprite m_BadgeBeKiller;

	public UILabel m_LeftText;

	public UILabel m_RightText;

	public UISprite m_WeaponIcon;

	public UISprite m_KillIcon;

	public UISprite m_KnockdownIcon;

	public UITable m_TwoTextTable;

	public UILabel m_BattleInfoText;

	public GameObject m_TwoTextGroup;

	public GameObject m_EpEffectGroup;

	public GameObject m_BadgeEffectGroup;

	private Timer m_ShowupTimer;

	private const string BP_ICON_SPRITE = "Minimap_BooyahPass_Kill";

	private string m_KillVerbColor;

	private MutableString m_TextBuilder;

	private bool m_isTwoText;

	private bool m_KillHasBp;

	private bool m_BeKillHasBp;

	public bool PlainVerbColor
	{
		set
		{
		}
	}

	public void SetActive(bool v)
	{
	}

	public bool IsActive(float gameTime)
	{
		return false;
	}

	public void MoveTo(UIHudKillNotificationItem item)
	{
	}

	private void EPEffectMoveTo(UIHudKillNotificationItem item)
	{
	}

	private void BadgeEffectMoveTo(UIHudKillNotificationItem item)
	{
	}

	private void Awake()
	{
	}

	public void RefreshLayoutForLeftAligned(object[] param)
	{
	}

	private void RefreshBattleInfoTextPosition()
	{
	}

	public virtual void SetKillInfo(float gameTime, PendingNotification notification)
	{
	}

	protected void SetTextInfo(PendingNotification notification)
	{
	}

	private void ShowSingleText(bool show, PendingNotification notification)
	{
	}

	private void SetFFWSIcon(UILabel textContent, PendingNotification notification)
	{
	}

	private ResourceID GetWeaponIconResourceId(uint notificationWeaponID)
	{
		return default(ResourceID);
	}

	private void SetWeaponIcon(ResourceID weaponIconResourceId)
	{
	}

	private void SetEpEffectTarget(bool isTwoText)
	{
	}

	private void SetBadgeEffect(bool isTwoText)
	{
	}
}
