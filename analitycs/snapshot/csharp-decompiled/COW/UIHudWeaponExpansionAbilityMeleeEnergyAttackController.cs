using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudWeaponExpansionAbilityMeleeEnergyAttackController : UIWeaponExpansionAbilityContentController
{
	private HFEPODPHMEE m_BindAbility;

	private UIHudWeaponExpansionAbilityMeleeEnergyAttackView m_View;

	private Vector3 m_DefaultPos;

	private bool m_IsDraging;

	private float multiscale;

	private float m_BGRangeRadius;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected void Update()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override PFNNIPJHHOD GetTargetAbilityType()
	{
		return PFNNIPJHHOD.EWeaponExpansionAbilityType_None;
	}

	protected override void OnBindAbility(JLOFMCKFFHB ability)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ResetDragBtn()
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void RefreshContentDetail(JLOFMCKFFHB ability)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}
}
