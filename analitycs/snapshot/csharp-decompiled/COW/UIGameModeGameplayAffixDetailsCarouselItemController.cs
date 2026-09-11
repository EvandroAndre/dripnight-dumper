using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeGameplayAffixDetailsCarouselItemController : UIBaseController, IFixTimeCarouselItem
{
	private UIGameModeGameplayAffixDetailsCarouselItemView m_View;

	private UIGameModeGameplayAffixDetailsCarouselItemViewData m_ViewData;

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
