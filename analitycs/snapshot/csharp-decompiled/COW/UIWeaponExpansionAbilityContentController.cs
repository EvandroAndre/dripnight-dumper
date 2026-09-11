using COW.GamePlay;
using message;

namespace COW;

internal abstract class UIWeaponExpansionAbilityContentController : UIHudButtonBaseController
{
	protected uint m_BindInventoryID;

	protected abstract PFNNIPJHHOD GetTargetAbilityType();

	protected abstract void OnBindAbility(JLOFMCKFFHB ability);

	protected abstract void RefreshContentDetail(JLOFMCKFFHB ability);

	private bool AbilityTypeAssertion(JLOFMCKFFHB ability)
	{
		return false;
	}

	public uint GetBindInventoryID()
	{
		return 0u;
	}

	internal void BindAbility(JLOFMCKFFHB ability)
	{
	}

	internal void RefreshContent(JLOFMCKFFHB ability)
	{
	}

	public virtual void OnParentChangeVisibility()
	{
	}
}
