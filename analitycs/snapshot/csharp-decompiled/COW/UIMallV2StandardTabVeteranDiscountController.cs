using GCommon;

namespace COW;

public class UIMallV2StandardTabVeteranDiscountController : UIBaseController, IUIModelDataChangeObserver
{
	private UIMallV2StandardTabVeteranDiscountView m_View;

	private UIModelVeteran m_ModelVeteran;

	private UIModelMall m_ModelMall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetDiscountState()
	{
	}

	private void RefreshState(uint discount)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
