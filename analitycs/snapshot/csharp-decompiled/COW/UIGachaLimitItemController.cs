using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaLimitItemController : UIBaseController
{
	public enum ViewStage
	{
		NORMAL,
		TRANSLUCENT,
		HIGHLIGHT,
		SELECTED,
		GET_REWARD
	}

	protected uint m_GachaID;

	protected UIGachaLimitItemView m_View;

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

	public bool isOwnedorRemoved()
	{
		return false;
	}

	public uint GetGachaItemID()
	{
		return 0u;
	}

	public void SetCurrentItemState(GachaLimitItemState state)
	{
	}

	private void OnBtnTipClick()
	{
	}

	private void OnChooseClick()
	{
	}

	public void SetViewInfo(uint gachaID, int idx, GachaShowItem info, bool isShowDropUp = false)
	{
	}

	public void SetQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01)
	{
	}

	public void ShowView(ViewStage stage, float alpha = 1f)
	{
	}

	private void PlaySelectedAudio()
	{
	}

	private void PlayGetRewardAudio()
	{
	}

	protected virtual GameObject GetRemoveVfx()
	{
		return null;
	}

	protected virtual GameObject GetThirdVfx()
	{
		return null;
	}

	protected virtual GameObject GetSecondVfx()
	{
		return null;
	}

	protected virtual GameObject GetFlickerEffect()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
