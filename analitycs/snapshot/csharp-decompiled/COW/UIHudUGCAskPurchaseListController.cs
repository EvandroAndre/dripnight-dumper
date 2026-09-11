using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCAskPurchaseListController : UIBaseController, IEasyList
{
	private UIHudAskPurchaseListView m_View;

	private List<UGCAskPurchaseInfo> m_PurchaseInfoList;

	private string m_WalletID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetWallet(string walletID)
	{
	}

	public void SetListInfo(List<object> askedList)
	{
	}

	private void RefreshUI()
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
