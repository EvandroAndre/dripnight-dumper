using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudBrakeController : UIHudVehicleButtonBaseController
{
	private UIHudBrakeView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override bool CanLockInput()
	{
		return false;
	}

	protected override EControlMode ShowInControlMode()
	{
		return EControlMode.Default;
	}

	public override void Show()
	{
	}

	public void SetButtonState(Player.AALGCBFJHJM status)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanLockInput()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
