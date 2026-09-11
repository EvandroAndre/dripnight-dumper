using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIGameBigMapSafeZoneChooseBtnController : UIBaseController
{
	private UIGameBigMapSafeZoneChooseBtnView m_View;

	private Vector3 m_Position;

	private uint m_ObjectID;

	private Action m_onConfirmClick;

	private Action m_onCancelClick;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(uint objectID, Action onConfirmClick, Action onCancelClick)
	{
	}

	public void SetPos(Vector3 mapPos)
	{
	}

	public void OnBtnCancelClick()
	{
	}

	private void OnTelescopeBtnClick()
	{
	}

	private void OnTelescopeConfirmBtnClick()
	{
	}

	public void ShowConfirmBtn(bool v)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
