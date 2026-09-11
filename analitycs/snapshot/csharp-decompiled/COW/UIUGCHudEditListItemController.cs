using System;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIUGCHudEditListItemController : UIEasyListItemController
{
	public Action<int> SelectCallback;

	public Action<int, Vector3> LongPressCallback;

	private UIUGCHudEditListItemView m_View;

	private NLNAMPBAGDC m_Data;

	private UIModelUGCHudEdit m_Model;

	private static Color s_SelectedColor;

	private static Color s_DefaultColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshView()
	{
	}

	private void OnSelect(bool selected)
	{
	}

	private void OnClickMenuBtn()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void UpdateScriptedIcon(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
