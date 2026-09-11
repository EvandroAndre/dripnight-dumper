using System;
using GCommon;

namespace COW;

public class UIIAPBundlePreviewItemController : UIBaseController
{
	private UIIAPBundlePreviewItemView m_View;

	private IAPBundleStoreData m_Data;

	private Action<IAPBundleStoreData> m_Callback;

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

	public void SetDragScrollView(UIScrollView scrollView)
	{
	}

	public void UpdateData(IAPBundleStoreData data)
	{
	}

	public void SetCallback(Action<IAPBundleStoreData> callback)
	{
	}

	private void OnItemClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
