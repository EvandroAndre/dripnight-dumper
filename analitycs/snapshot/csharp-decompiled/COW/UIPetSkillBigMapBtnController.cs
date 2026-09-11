using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPetSkillBigMapBtnController : UIBaseController
{
	public enum TelescopeBtnState
	{
		Normal,
		Clicking,
		Cancel
	}

	private UIGamePetSkillFlyingCreatureBtnView m_View;

	private Vector3 m_Position;

	private uint m_ItemId;

	private Action m_onChoosePositionClick;

	private Action m_onConfirmClick;

	private Action m_onCancelClick;

	private TelescopeBtnState m_CurState;

	private uint m_ClickingDelayID;

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

	public void SetBtnState(TelescopeBtnState btnState)
	{
	}

	public void SetData(uint itemId, Action onChoosePositionClick, Action onConfirmClick, Action onCancelClick)
	{
	}

	public void SetTelescopeCount(int telescopeCount)
	{
	}

	public void ShowConfirmBtn(bool v)
	{
	}

	public void SetPos(Vector3 mapPos)
	{
	}

	public void OnBtnChoosePosition()
	{
	}

	private void OnClickingDelayCall()
	{
	}

	public void OnBtnCancelClick()
	{
	}

	public void OnBtnConfirmClick()
	{
	}

	public Vector2 GetSize()
	{
		return default(Vector2);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
