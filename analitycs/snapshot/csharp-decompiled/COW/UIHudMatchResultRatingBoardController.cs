using GCommon;
using proto;

namespace COW;

internal class UIHudMatchResultRatingBoardController : UIBaseController
{
	private UIHudMatchResultRatingBoardView m_View;

	private UIModelMatch m_ModelMatch;

	private ERatingLevel m_RatingBoardType;

	private const string COMMON_LABEL_GOLD = "T_52_TSY_GOLD_MEDAL_FIRST";

	private const string COMMON_LABEL_SILVER = "T_52_TSY_SILVER_MEDAL_FIRST";

	private const string STREAK_LABEL_GOLD = "T_52_TSY_GOLD_MEDAL_STREAK";

	private const string STREAK_LABEL_SILVER = "T_52_TSY_SILVER_MEDAL_STREAK";

	private const string STEAK_TIMES_LABEL = "T_52_TSY_MEDAL_STREAK_COUNT";

	private const string STREAK_BOARD_BG_GOLD = "FF_UI_Rating_Settlement_BG_01";

	private const string STREAK_BOARD_BG_SILVER = "FF_UI_Rating_Settlement_BG_02";

	private const string STREAK_BOARD_MADEL_BG_GOLD = "FF_UI_Rating_Icon_01_Big";

	private const string STREAK_BOARD_MADEL_BG_SILVER = "FF_UI_Rating_Icon_02_Big";

	private const string GOLD_ANIM_Name = "UIFX_UIHudMatchResultRatingBoard_Gold";

	private const string SILVER_ANIM_Name = "UIFX_UIHudMatchResultRatingBoard_Silvery";

	private string m_AnimName;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(MatchIncome income, MatchStats stats)
	{
	}

	public void RefreshVisibleWholeContainer(bool show)
	{
	}

	public void RefreshVisibleUIFX(bool show)
	{
	}

	public float PlayAnimationAndGetLength()
	{
		return 0f;
	}

	private void OnClickWholeContainerBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
