using System;
using GCommon;
using proto;

namespace COW;

public class UIGachaLimitChestItemController : UIBaseController
{
	private GachaShowItem m_gachaShowItemInfo;

	protected uint m_GachaID;

	protected UIGachaLimitChestItemView m_View;

	protected GachaLimitItemState m_CurrentState;

	protected uint m_gachaItemID;

	protected int m_Idx;

	protected BaseItemInfo m_Info;

	private Action<int, bool> m_onClickFunc;

	public GachaShowItem ShowItemInfo => null;

	public int Index => 0;

	public BaseItemInfo Info => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void PlayerLightningEffect()
	{
	}

	public void CloseLightningEffect()
	{
	}

	public void RefreshState()
	{
	}

	protected void OnBtnTipClick()
	{
	}

	public void SetViewInfo(uint gachaID, int idx, GachaShowItem info, bool isShowDropUp = false)
	{
	}

	public void SetQualityBG(int Quality)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void InitOnClickFunc(Action<int, bool> action)
	{
	}

	public void PlayLoadingEndAniEffect()
	{
	}

	public void StopLoadingEndAniEffect()
	{
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
