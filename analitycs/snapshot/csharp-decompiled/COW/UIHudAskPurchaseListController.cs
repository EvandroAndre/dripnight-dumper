using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudAskPurchaseListController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public AskCSPurchaseInfo info;

		internal bool _003CGCommon_002EIUIModelDataChangeObserver_002EOnDataChanged_003Eb__0(AskCSPurchaseInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public int curCoin;

		public IHFFDJIDIAA financialMgr;

		internal int _003CResortAndRefresh_003Eb__0(AskCSPurchaseInfo a, AskCSPurchaseInfo b)
		{
			return 0;
		}
	}

	private UIHudAskPurchaseListView m_View;

	private List<AskCSPurchaseInfo> m_PurchaseInfoList;

	private Transform m_scrollviewTrans;

	private Vector3 m_scrollviewPos;

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void ResortAndRefresh()
	{
	}

	private static int GetSortRank(AskCSPurchaseInfo info, int curCoin, IHFFDJIDIAA financialMgr)
	{
		return 0;
	}

	private void OnLocalCoinChanged()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
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

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
