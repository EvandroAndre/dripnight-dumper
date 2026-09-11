using GCommon;
using UnityEngine;

namespace COW;

public class UIStanardDrawTabIPCollalbController : UIStandardDrawerTabController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override UIStandardTabItemController CreateTabItem(Transform container, StandardTabItemViewData mainTabData)
	{
		return null;
	}

	private void SetScrollViewWidth()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public UIStandardTabItemController _003C_003EiFixBaseProxy_CreateTabItem(Transform P0, StandardTabItemViewData P1)
	{
		return null;
	}
}
