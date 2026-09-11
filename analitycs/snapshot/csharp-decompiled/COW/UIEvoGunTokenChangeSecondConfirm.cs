using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIEvoGunTokenChangeSecondConfirm : UIPopupWindowController, IEasyList
{
	private UIEvoGunTokenChangeSecondConfirmView m_View;

	private List<uint> m_ListSkinID;

	private Action<List<uint>, bool> m_ConfirmButtonClickAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(List<BaseItemInfo> willChangedItem, List<uint> listSkinID, uint generalTokenId, Action<List<uint>, bool> confirmAction = null)
	{
	}

	private void OnComfirmBtnClick()
	{
	}

	private uint CalculateItemCountFromBaseItemInfo(List<BaseItemInfo> listBaseItemInfo)
	{
		return 0u;
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
}
