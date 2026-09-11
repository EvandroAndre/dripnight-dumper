using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2PrimeContainerController : UIBaseController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__7_0;

		internal void _003CRefreshPrimeCountDownShowState_003Eb__7_0()
		{
		}
	}

	private UIMallV2PrimeContainerView m_View;

	private UIModelPrime m_ModelPrime;

	private UICountDownController m_PrimeCountDownCtrl;

	private List<PrimeStoreItemDesc> m_DataList;

	private UIEasyListItemController m_CurrentItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshPrimeCountDownShowState()
	{
	}

	public void SetViewData(List<PrimeStoreItemDesc> primeItemDescList)
	{
	}

	public UIEasyList GetEasyList()
	{
		return null;
	}

	void IEasyList.CloseItemController(UIEasyListItemController itemController)
	{
	}

	UIEasyListItemController IEasyList.OpenItemController(Transform parent)
	{
		return null;
	}

	internal void SelectItem(int index, bool force = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
