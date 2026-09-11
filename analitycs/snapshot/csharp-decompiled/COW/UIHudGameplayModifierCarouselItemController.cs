using GCommon;
using UnityEngine;

namespace COW;

public class UIHudGameplayModifierCarouselItemController : UIBaseController, IFixTimeCarouselItem
{
	private UIHudGameplayModifierCarouselItemView m_View;

	private UIHudGameplayModifierCarouselItemViewData m_ViewData;

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

	private void SetupDefaultState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
