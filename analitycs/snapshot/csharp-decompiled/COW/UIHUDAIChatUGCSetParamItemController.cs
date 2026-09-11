using GCommon;

namespace COW;

internal class UIHUDAIChatUGCSetParamItemController : UIBaseController
{
	private UIHUDAIChatUGCSetParamItemView m_View;

	private string m_DestVal;

	private bool m_IsPercentageAdjustment;

	private uint m_ID;

	private UGCSetParamData m_UGCSetParamData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnLinkButtonClick()
	{
	}

	public void SetViewData(UGCSetParamData uGCSetParamData)
	{
	}

	private void RefreshContent()
	{
	}

	public EAIChatSetParamsError ExcuteModify()
	{
		return EAIChatSetParamsError.None;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
