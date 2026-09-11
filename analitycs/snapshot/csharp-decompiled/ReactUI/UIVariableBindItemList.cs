using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace ReactUI;

public sealed class UIVariableBindItemList : UIEventBind, IEasyList
{
	private string paramBinds;

	private string paramCurrentSelected;

	private GameObject itemTemplate;

	private UIVariable m_bindVariable;

	private UIVariable m_curSelVariable;

	private string eventOnSelectName;

	private SignalDelegateList m_delegateList;

	private List<UIBindItemListItemController> m_cacheItemControllers;

	private List<object> m_allItemData;

	private UIEasyList m_easyList;

	protected override void BindVariables()
	{
	}

	protected override void UnbindVariables()
	{
	}

	private SignalDelegateList GetDelegateList()
	{
		return null;
	}

	protected override void RefreshBind()
	{
	}

	private void RefreshList()
	{
	}

	private void OnVariableInit()
	{
	}

	private void ScrollToCurSel()
	{
	}

	public void OnSelectItem(int dataIndex)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void RefreshListInfinite()
	{
	}

	private new void Awake()
	{
	}
}
