using System;
using GCommon;
using proto;

namespace COW;

public class UIGachaIIVTWItemController : UIBaseController
{
	public enum ViewStage
	{
		NORMAL,
		TRANSLUCENT,
		HIGHLIGHT,
		SELECTED,
		GET_REWARD
	}

	protected Action<int, bool> m_onClickFunc;

	protected uint m_GachaID;

	protected UIGachaIIV1_TWIIVItemView m_View;

	private UIModelGacha m_ModelGacha;

	protected int m_Idx;

	protected GachaShowItem m_GachaShowItem;

	protected BaseItemInfo m_Info;

	private bool m_CDNReady;

	public int Index => 0;

	public BaseItemInfo Info => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	public override void Show()
	{
	}

	public void InitOnClickFunc(Action<int, bool> onClick = null)
	{
	}

	protected void OnBtnTipClick()
	{
	}

	public void SetCDNReady(bool cndReady)
	{
	}

	public void SetViewInfo(uint gachaID, int idx, GachaShowItem info, bool isShowDropUp = false)
	{
	}

	protected virtual void OnSetViewInfo()
	{
	}

	protected virtual void SetQualityBG(int Quality, UISprite QualityBG, bool bRareItem)
	{
	}

	public void ShowView(ViewStage stage, float alpha = 1f)
	{
	}

	protected void PlayTranslucentAudio()
	{
	}

	protected void PlayGetRewardAudio()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void PlayLoopAnim()
	{
	}

	public void ResetAnim()
	{
	}

	private void ResizeItemIconSize()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
