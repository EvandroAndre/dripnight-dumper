using GCommon;

namespace COW;

public class UIHippoCrisisCommonTopCurrencyController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHippoCrisisCommonTopCurrencyView m_View;

	private UIModelHippoCrisis m_ModelHippoCrisis;

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

	public void SetView()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void ShowTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
