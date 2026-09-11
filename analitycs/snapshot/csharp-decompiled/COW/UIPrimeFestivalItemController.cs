using GCommon;
using proto;

namespace COW;

public class UIPrimeFestivalItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIPrimeFestivalItemView m_View;

	private PrimeFestivalStatus m_PrimeFestivalStatus;

	private UIModelPrime m_ModelPrime;

	private PrimeFestivalDesc m_Desc;

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

	public void SetViewData(PrimeFestivalDesc desc)
	{
	}

	private void OnButtonClick()
	{
	}

	private void RefreshFestival()
	{
	}

	private void UpdateBirthdayDesc()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
