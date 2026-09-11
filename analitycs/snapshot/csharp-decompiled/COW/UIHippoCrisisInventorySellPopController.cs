using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisInventorySellPopController : UIPopupWindowController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__18_0;

		internal void _003CStartGuide_003Eb__18_0()
		{
		}
	}

	private UIHippoCrisisInventorySellPopView m_View;

	private List<HippoCrisisOutGameItemUIData> m_SellItems;

	private int m_OriginalSelectedCount;

	private int m_CurrentSelectedCount;

	private int m_CurrentSelectedValue;

	private bool m_IsSelled;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private Action m_Callback;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData()
	{
	}

	public void RegisterCloseCallBack(Action cb)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnSellItemChanged(object[] param)
	{
	}

	private void OnSellBtnClick()
	{
	}

	private void StartGuide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
