using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaLimitChestSelectRewardItemController : UIBaseController
{
	public enum ViewStage
	{
		NORMAL,
		TRANSLUCENT,
		HIGHLIGHT,
		SELECTED,
		GET_REWARD
	}

	private Action<int> m_onClickFunc;

	private bool m_bIsSelected;

	private uint m_itemID;

	protected uint m_GachaID;

	protected UIGachaLimitChestSelectRewardItemView m_View;

	private GachaLimitItemState m_CurrentState;

	protected uint m_gachaItemID;

	protected int m_Idx;

	protected BaseItemInfo m_Info;

	protected GameObject m_RemoveVfx;

	protected GameObject m_ThirdVfx;

	protected GameObject m_SecondVfx;

	protected GameObject m_FlickerEffect;

	public int Index => 0;

	public BaseItemInfo Info => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void OnBtnTipClick()
	{
	}

	public void InitOnClickFunc(Action<int> onClick = null)
	{
	}

	public void RefreshState()
	{
	}

	public void SetViewData(uint gachaID, int idx, GachaShowItem info)
	{
	}

	public uint GetGachaItemID()
	{
		return 0u;
	}

	public void SetCurrentItemState(GachaLimitItemState state)
	{
	}

	private void OnChooseClick()
	{
	}

	public void SetQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual GameObject GetRemoveVfx()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
