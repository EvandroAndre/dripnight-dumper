using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSkillMightyUpgradeController : UIBaseController, INotifyHudConfigChanged
{
	private const float FLY_EFFECT_DURATION = 1f;

	private const float HIT_VFX_DURATION = 1f;

	private const float HIT_LOOP_VFX_DURATION = 1f;

	private static readonly ResourceID FLY_EFFECT_RESID;

	private UIHudSkillMightyUpgradeView m_View;

	private float m_LastReminderTime;

	private bool m_IsShowing;

	private GKGGOIJHDBO m_SkillPowerUpItem;

	private GameObject m_FlyEffectGo;

	private uint m_FlyEffectLoadTicket;

	private EntityVisualEffectManager m_VfxMgr;

	private EntityVisualEffectManager VfxMgr => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnSkillPowerUpItemChanged(object[] param)
	{
	}

	private void StartFlyInEffect()
	{
	}

	private void OnFlyInEffectLoaded(uint ticket, bool success, Object obj)
	{
	}

	private void OnFlyInEffectFinished()
	{
	}

	private static Transform TryGetHudVfxParent()
	{
		return null;
	}

	private Vector3? TryGetFlyStartWorldPos()
	{
		return null;
	}

	private void CancelFlyInEffect()
	{
	}

	private void ShowUpgradeButton()
	{
	}

	private void HideUpgradeButton()
	{
	}

	private void OnUpgradeBtnClick()
	{
	}

	private void OnLocalPlayerDead(object[] param)
	{
	}

	private void OnLocalPlayerAlive(object[] param)
	{
	}

	private void Update()
	{
	}

	private void PlayHitVfx()
	{
	}

	private void PlayHitLoopVfx()
	{
	}

	public void NotifyHudConfigChanged(HudConfigItem config)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
