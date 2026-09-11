using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIImageShareFrameSelectPopController : UIPopupWindowController, IEasyList
{
	private UIImageShareFrameSelectPopView m_View;

	private UIModelTakePhoto m_ModelTakePhoto;

	private List<FrameSelectItemData> m_ItemDatas;

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

	public void SetViewData(bool isVertical, uint CurFrameItemID)
	{
	}

	private void CheckAndRequestNoGoposItems(List<PhotoFrameWithResConfig> list)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
