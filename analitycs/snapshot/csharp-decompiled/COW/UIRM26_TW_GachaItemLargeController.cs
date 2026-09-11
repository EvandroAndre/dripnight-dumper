using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIRM26_TW_GachaItemLargeController : UIBaseController, IUIRM26TWGachaItemController
{
	protected Action<int> m_onClickFunc;

	protected uint m_GachaID;

	protected UIRM26_TW_GachaItemLargeView m_View;

	private UIModelGacha m_ModelGacha;

	protected int m_Idx;

	protected GachaShowItem m_GachaShowItem;

	protected BaseItemInfo m_Info;

	private bool m_CDNReady;

	private uint _003CLayoutType_003Ek__BackingField;

	public int Index => 0;

	public BaseItemInfo Info => null;

	public uint LayoutType
	{
		get
		{
			return _003CLayoutType_003Ek__BackingField;
		}
		private set
		{
			_003CLayoutType_003Ek__BackingField = value;
		}
	}

	Transform IUIRM26TWGachaItemController.transform => null;

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

	public void SetLayoutType(uint layoutType)
	{
	}

	public override void Show()
	{
	}

	public void InitOnClickFunc(Action<int> onClick = null)
	{
	}

	protected void OnBtnTipClick()
	{
	}

	public void SetCDNReady(bool cndReady)
	{
	}

	public void SetFixedIconSpriteName(string spriteName)
	{
	}

	public void SetViewInfo(uint gachaID, int idx, GachaShowItem info, bool isShowDropUp = false)
	{
	}

	protected virtual void SetQualityBG(int Quality, UISprite QualityBG, bool bRareItem)
	{
	}

	public void ShowView(UIRM26TWGachaItemViewStage stage, float alpha = 1f)
	{
	}

	protected void PlayHilightAudio()
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

	public void PlayIdleAnim()
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
