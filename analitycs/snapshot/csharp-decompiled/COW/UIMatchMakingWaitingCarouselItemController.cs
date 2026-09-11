using GCommon;
using UnityEngine;

namespace COW;

internal class UIMatchMakingWaitingCarouselItemController : UIBaseController, IFixTimeCarouselItem
{
	private UIMatchMakingWaitingCarouselItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Populate(object viewData)
	{
	}

	public void SetLocalPosition(Vector3 pos)
	{
	}

	public void OnCarouselEnter()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
