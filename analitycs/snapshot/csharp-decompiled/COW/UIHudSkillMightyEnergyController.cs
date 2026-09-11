using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSkillMightyEnergyController : UIBaseController
{
	private const string ENERGY_FULL_TIPS_LOC_KEY_WITH_POWERUP = "T_54_U_Ninth_GP_SkillMighty_FULL2";

	private const string ENERGY_FULL_TIPS_LOC_KEY_WITHOUT_POWERUP = "T_54_U_Ninth_GP_SkillMighty_FULL1";

	private const string ENERGY_FULL_TIPS_UI_RES = "UIHUDACTIVITYTWEENTIPS_NINTH_GP_SKILLMIGHTY";

	private const float ENERGY_GROW_VFX_DURATION = 1f;

	private const float ENERGY_FULL_VFX_DURATION = 1f;

	private UIHudSkillMightyEnergyView m_View;

	private bool m_IsEnergyFull;

	private EntityVisualEffectManager m_VfxMgr;

	private EntityVisualEffectManager VfxMgr => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void OnAddLocalPlayer(object[] param)
	{
	}

	private void OnObserverSwitch(object[] param)
	{
	}

	private void OnEnergyChanged(object[] param)
	{
	}

	public void RefreshEnergy()
	{
	}

	private void UpdateFill(uint energy)
	{
	}

	public void SetSide(bool showOnRight)
	{
	}

	public bool TryGetFillSpriteWorldPosition(out Vector3 worldPosition)
	{
		worldPosition = default(Vector3);
		return false;
	}

	private void PlayEnergyGrowVfx()
	{
	}

	private void PlayEnergyFullVfx()
	{
	}

	private void ShowEnergyFullBannerTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}
}
