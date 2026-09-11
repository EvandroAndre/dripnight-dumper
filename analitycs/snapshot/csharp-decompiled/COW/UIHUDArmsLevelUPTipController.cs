using GCommon;

namespace COW;

public class UIHUDArmsLevelUPTipController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHUDArmsLevelUPTipView m_View;

	private int m_DelayHandle;

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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void ShowTip()
	{
	}

	public void HideTip()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
