using System;
using GCommon;

namespace COW;

public class UIGachaIchis55DrawAnimWndController : UIPopupWindowController
{
	private UIGachaIchis55DrawAnimWndView m_View;

	private uint m_ChestId;

	private uint m_ChestSubId;

	private uint m_DrawCount;

	private Action m_OnAnimEndAction;

	private bool m_AnimEnded;

	private uint m_AutoCloseDelayCall;

	private const string ANIM_EVT_END = "IchisDrawAnimEnd";

	private const string CLIP_IN_1 = "UIFX_Ichis_55_Box_In1_Ainm";

	private const string CLIP_IN_5 = "UIFX_Ichis_55_Box_In5_Ainm";

	private const string CLIP_IN_10 = "UIFX_Ichis_55_Box_In10_Ainm";

	private const uint CDN_BG_SUBTYPE_BIG_PRIZE = 3u;

	private const uint CDN_BG_SUBTYPE_NORMAL = 2u;

	private const string GRAND_PRIZE_VFX_YELLOW = "UIFX_Ichis_55_Box_DrawGrandPrizeYellow";

	private const string GRAND_PRIZE_VFX_PURPLE = "UIFX_Ichis_55_Box_DrawGrandPrizePurple";

	private const string GRAND_PRIZE_VFX_BLUE = "UIFX_Ichis_55_Box_DrawGrandPrizeBlue";

	private const int VFX_SORT_THRESHOLD_YELLOW = 6;

	private const int VFX_SORT_THRESHOLD_PURPLE = 4;

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

	private void RefreshCdnBg(bool isBigPrize)
	{
	}

	private void RefreshDrawGrandPrizeVFX(uint chestId, uint chestSubId)
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

	private static string ResolveDrawClipName(uint drawCount)
	{
		return null;
	}

	private void ScheduleAutoClose(float clipLen)
	{
	}

	private void CancelAutoClose()
	{
	}

	private void OnAutoClose()
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
