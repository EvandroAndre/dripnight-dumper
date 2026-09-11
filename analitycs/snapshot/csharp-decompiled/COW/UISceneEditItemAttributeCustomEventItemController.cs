using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using message;

namespace COW;

public class UISceneEditItemAttributeCustomEventItemController : UIBaseController
{
	private UISceneEditItemAttributeEventClipItemView m_View;

	protected UIPopMenuSmallControler m_EventPopMenu;

	protected List<PopMenuData> mPopMenuDataList;

	private CustomEventReader m_EventData;

	public CustomEventReader EventData => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(int idx, UGCVarValueDataV2 eventData)
	{
	}

	private void OnRemoveClick()
	{
	}

	private void OnJumpClick()
	{
	}

	protected void RefreshLeftFilterPopMenu()
	{
	}

	protected virtual void OnTrackPopMenuSelected(object value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
