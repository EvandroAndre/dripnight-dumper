using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal class UIHudWeaponExpansionAbilityShurikenController : UIWeaponExpansionAbilityContentController
{
	private PKMPONMNFNP m_BindAbility;

	private UIHudWeaponExpansionAbilityShurikenView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
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

	protected override void RefreshContentDetail(JLOFMCKFFHB ability)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
