using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchisNormalDrawAnimWndController : UIPopupWindowController
{
	private UIGachaIchisNormalDrawAnimWndView m_View;

	private uint m_ChestId;

	private uint m_ChestSubId;

	private uint m_DrawCount;

	private Action m_OnAnimEndAction;

	private bool m_AnimEnded;

	private uint m_LoopAutoCloseDelayCall;

	private GameObject m_GrandPrizeFx;

	private const string ANIM_EVT_END = "IchisDrawAnimEnd";

	private const string CLIP_IN_1 = "UIFX_Ichis_Normal_Box_In1_Ainm";

	private const string CLIP_IN_5 = "UIFX_Ichis_Normal_Box_In5_Ainm";

	private const string CLIP_IN_10 = "UIFX_Ichis_Normal_Box_In10_Ainm";

	private const string CLIP_LOOP_1 = "UIFX_Ichis_Normal_Box_Loop1_Ainm";

	private const string CLIP_LOOP_10 = "UIFX_Ichis_Normal_Box_Loop10_Ainm";

	private const float LOOP_AUTO_CLOSE_SECONDS_1 = 2.8f;

	private const float LOOP_AUTO_CLOSE_SECONDS_5 = 2.8f;

	private const float LOOP_AUTO_CLOSE_SECONDS_10 = 3f;

	private const string GRAND_PRIZE_FX_RES_NAME = "UIFX_Ichis_Normal_Box_DrawGrandPrize";

	private const string GRAND_PRIZE_VFX_RED = "UIFX_Ichis_Normal_Box_DrawGrandPrizeRed";

	private const string GRAND_PRIZE_VFX_YELLOW = "UIFX_Ichis_Normal_Box_DrawGrandPrizeYellow";

	private const string GRAND_PRIZE_VFX_PURPLE = "UIFX_Ichis_Normal_Box_DrawGrandPrizePurple";

	private const string GRAND_PRIZE_VFX_BLUE = "UIFX_Ichis_Normal_Box_DrawGrandPrizeBlue";

	private const int VFX_SORT_THRESHOLD_RED = 8;

	private const int VFX_SORT_THRESHOLD_YELLOW = 6;

	private const int VFX_SORT_THRESHOLD_PURPLE = 4;

	private ResourceID m_VFXRed;

	private ResourceID m_VFXYellow;

	private ResourceID m_VFXPurple;

	private ResourceID m_VFXBlue;

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

	protected override void OnUIClose()
	{
	}

	public void SetViewData(uint chestId, uint chestSubId, bool isBigPrize, uint drawCount, Action onAnimEnd)
	{
	}

	private void EnsureGrandPrizeFx(bool isBigPrize)
	{
	}

	private void RefreshDrawGrandPrizeVFX()
	{
	}

	private int GetMaxAwardRareSortValue()
	{
		return 0;
	}

	private ResourceID ResolveDrawPrizeVFXResourceID(int maxRareSort)
	{
		return default(ResourceID);
	}

	private void PlayDrawAnim()
	{
	}

	private void ScheduleLoopAutoClose(float delayBeforeLoop)
	{
	}

	private float GetLoopAutoCloseSeconds()
	{
		return 0f;
	}

	private void CancelLoopAutoClose()
	{
	}

	private void OnLoopAutoClose()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void OnMaskClick()
	{
	}

	public void OnAnimEnd()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
