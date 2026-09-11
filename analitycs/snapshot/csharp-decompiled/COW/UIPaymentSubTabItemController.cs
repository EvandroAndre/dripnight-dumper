using GCommon;

namespace COW;

public class UIPaymentSubTabItemController : UIBaseController
{
	private UIPaymentSubTabItemView m_View;

	private int m_Index;

	private ActivityGroupDesc m_ActivityGroupDesc;

	private UIModelActivity m_ModelActivity;

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

	private void OnBtnClick()
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void ResetSelectedState()
	{
	}

	public void SetViewData(ActivityGroupDesc desc, int index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
