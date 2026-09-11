using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDFeedbackGroupItemController : UIBaseController
{
	private UIHUDFeedbackGroupItemView m_View;

	private bool m_MatchResultShow;

	private bool m_Clicked;

	private bool m_UseNewStyle;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnHideTip()
	{
	}

	private void OnClick(GameObject ob)
	{
	}

	public void SetFeedData(AftergameFeedback feedData)
	{
	}

	public string SetData(byte id)
	{
		return null;
	}

	public void SetGroupDataID(uint id)
	{
	}

	public UIGridAnimPopAsideItem GetAnimQueueItem()
	{
		return null;
	}

	private void OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
