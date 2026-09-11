using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSFRoleplayRoleEnergyController : UIBaseController
{
	private UIHudSFRoleplayRoleEnergyView m_View;

	private uint m_BasicMaxEnergy;

	private const string m_DefaultIconName = "SF50_Small_Profession_Icon_Null";

	private bool m_CanClick;

	private uint m_RoleId;

	private UIClickMask m_ClickMask;

	private uint m_EneygyTipsDelayID;

	private ResourceID m_RoleUIFXResId;

	private VisualInstanceHolder m_UIFXHolder;

	private uint m_DelayCallHideBurstId;

	private GameObject m_BurstObj;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnEnergyBtnClick()
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	public void RefreshEnergy(bool showGuide)
	{
	}

	private void ResetEnergyBars()
	{
	}

	private void HandlePlayerEnergyDisplay(Player player, bool showGuide)
	{
	}

	private void HandleObserverDisplay(PHLHIEGPMMK observer)
	{
	}

	private void UpdateMaskContainer()
	{
	}

	private void OnClickMask()
	{
	}

	private void OnShowEneygyTips(uint type)
	{
	}

	private void CancelEneygyTipsDelay()
	{
	}

	private VisualInstanceHolder EnsureUIFXHolder()
	{
		return null;
	}

	private void TryReleaseUIFXHolder()
	{
	}

	public void PlayUseGhostUIFX()
	{
	}

	private void OnGhostUIFXEnd()
	{
	}

	private void ClearUseGhostUIFX()
	{
	}

	private void _003CUpdateMaskContainer_003Eb__22_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
