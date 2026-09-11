using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDFeedbackGroupEndItemController : UIBaseController
{
	private UIHUDFeedbackGroupEndItemView m_View;

	private uint m_UIEnterDelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClick(GameObject ob)
	{
	}

	public void SetPersonlData(IngameFeedbackData feedData)
	{
	}

	public float GetItemHeight()
	{
		return 0f;
	}

	public void DelayShowUFX(float delay)
	{
	}

	private void ShowUfx()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
