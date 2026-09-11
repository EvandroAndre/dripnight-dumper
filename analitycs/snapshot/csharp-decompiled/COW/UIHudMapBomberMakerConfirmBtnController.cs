using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMapBomberMakerConfirmBtnController : UIBaseController
{
	private UIHudMapBomberMakerConfirmBtnView m_View;

	private Action<bool> m_onConfirm;

	private Action m_onCancel;

	private Vector3 m_Position;

	private uint m_ItemId;

	private List<uint> m_ItemIds;

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

	public void SetData(List<uint> itemIds, Action<bool> onConfirm, Action onCancel)
	{
	}

	public void ShowConfirmBtn(bool v)
	{
	}

	public void SetPos(Vector3 mapPos)
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	private void OnBtnCancelClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
