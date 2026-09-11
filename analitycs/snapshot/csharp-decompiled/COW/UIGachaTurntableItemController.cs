using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaTurntableItemController : UIBaseController
{
	public enum ViewStage
	{
		NORMAL,
		TRANSLUCENT,
		HIGHLIGHT,
		SELECTED,
		GET_REWARD
	}

	private uint m_GachaID;

	private UIGachaTurntableItemView m_View;

	private int m_Idx;

	private BaseItemInfo m_Info;

	private GameObject m_FlickerEffect;

	public int Index => 0;

	public BaseItemInfo Info => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnTipClick()
	{
	}

	public void SetViewInfo(uint gachaID, int idx, BaseItemInfo info, bool isShowDropUp = false)
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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void PlayAnim()
	{
	}

	public void ResetAnim()
	{
	}

	private GameObject GetFlickerEffect()
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
