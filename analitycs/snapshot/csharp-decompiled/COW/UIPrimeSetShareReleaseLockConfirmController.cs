using GCommon;

namespace COW;

internal class UIPrimeSetShareReleaseLockConfirmController : UIPopupWindowController
{
	private UIPrimeSetShareReleaseLockConfirmView m_View;

	private UIModelPrime m_ModelPrime;

	private int m_Source;

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

	private void OnConfirmClick()
	{
	}

	private void OnDenyClick()
	{
	}

	public void SetTimesLabel(uint times, ulong sharerAccountID, int source)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
