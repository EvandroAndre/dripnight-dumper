using GCommon;
using UnityEngine;

namespace COW;

internal abstract class UIHudVehicleButtonBaseController : UIHudButtonBaseController
{
	protected GameObject clickEffectGo;

	protected ResourceID clickEffectResId;

	protected GameObject extendCollider;

	protected abstract EControlMode ShowInControlMode();

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	protected virtual void RefreshVisibleWithControlMode(object[] data)
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnBtnUp()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnDisable()
	{
	}

	protected void ClearClickEffect()
	{
	}

	protected void ShowClickEffect()
	{
	}

	protected void HideClickEffect()
	{
	}

	protected void ShowExtendCollider(bool isShow)
	{
	}

	private void TrySetLockInputState()
	{
	}

	protected virtual bool CanLockInput()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}
}
