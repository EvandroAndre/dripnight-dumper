using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2NewBieOfferContainerController : UIBaseController, IEasyList
{
	public enum UIMallV2NewBieItemType
	{
		Normal = 1
	}

	private UIMallV2NewBieOfferContainerView m_View;

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	private UICountDownController m_CountDownCtrl;

	private uint m_CurrentTopTabID;

	public uint CurrentTopTabID
	{
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SetViewData(List<StarterStoreItemDesc> storeDescList)
	{
	}

	public void RefreshTableView(List<StarterStoreItemDesc> storeDescList)
	{
	}

	private void RefreshCountDown()
	{
	}

	private void RefreshNewBieItem(List<StarterStoreItemDesc> itemList)
	{
	}

	private void InitNewBieOfferItemTemplate()
	{
	}

	private UITable2.IUITable2Item OpenNewBieItem()
	{
		return null;
	}

	private List<StarterStoreItemDesc> GetStarterStoreDescListNoExpired(List<StarterStoreItemDesc> itemList)
	{
		return null;
	}

	private bool CheckCanDisplayGoSystem(uint type)
	{
		return false;
	}

	private void _003CRefreshCountDown_003Eb__13_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
