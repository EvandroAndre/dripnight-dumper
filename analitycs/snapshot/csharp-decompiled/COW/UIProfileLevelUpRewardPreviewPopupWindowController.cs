using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileLevelUpRewardPreviewPopupWindowController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	private UIProfileLevelUpRewardPreviewPopupWindowView m_View;

	private UIModelProfile m_Model;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void ScrollToItemBeforeLevel(uint level)
	{
	}

	private void InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
