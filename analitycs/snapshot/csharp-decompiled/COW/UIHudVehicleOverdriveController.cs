using GCommon;

namespace COW;

internal class UIHudVehicleOverdriveController : UIHudVehicleButtonBaseController
{
	private UIHudVehicleOverdriveView m_View;

	private bool LastFrameCooldown;

	private uint m_RefreshVFXHolder;

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	private void CheckVisiable()
	{
	}

	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void PlayRefreshVFX()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	protected override EControlMode ShowInControlMode()
	{
		return EControlMode.Default;
	}

	protected override void RefreshVisibleWithControlMode(object[] data)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshVisibleWithControlMode(object[] P0)
	{
	}
}
