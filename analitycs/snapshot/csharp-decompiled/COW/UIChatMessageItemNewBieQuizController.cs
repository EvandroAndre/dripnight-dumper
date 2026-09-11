using GCommon;

namespace COW;

public class UIChatMessageItemNewBieQuizController : UIBaseController
{
	private const string CLICK_KEY_NEWBIE_DAILY_QUIZ_UNANSWERED_ITEM_CLICK = "NewbieDailyQuizUnansweredItemClick";

	private UIChatMessageItemNewBieQuizView m_View;

	private UIStandardItemMiniController m_RewardItemController;

	private RookieAnswer m_CurrentQuizData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData()
	{
	}

	private void OnBtnQuizClick()
	{
	}

	private void OnAnswerCompleteBtnClick()
	{
	}

	private bool HasAnsweredNewbieDailyQuizToday()
	{
		return false;
	}

	private void OnNewbieDailyQuizAnswered()
	{
	}

	private void RefreshAnswerState(bool hasAnswered)
	{
	}

	private void ShowAlreadyAnswerTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
