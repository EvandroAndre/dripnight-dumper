using System.Collections.Generic;
using GCommon;

namespace COW;

public class UITutorialGameGlobalMissionAffixController : UIBaseController
{
	private const int STEP_START_DICE_ANIMATION = 0;

	private const int STEP_SHOW_FINAL_AFFIX = 1;

	private const int STEP_AUTO_CLOSE = 2;

	private const float SCROLL_INTERVAL = 0.1f;

	public const float SCROLL_DURATION = 2f;

	private UITutorialGameGlobalMissionAffixView m_View;

	private uint[] m_PickSourceAffixIDs;

	private uint m_GlobalMissionAffixID;

	private GameplayAffixConfigData m_GlobalMissionAffixData;

	private DelayCallSequencer m_DelayCallSequencer;

	private uint m_TitleScrollDelayID;

	private int m_CurrentTitleIndex;

	private List<string> m_TitleKeys;

	private float m_TitleScrollTotalDuration;

	private float m_AutoCloseDelayTime;

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

	private void CancelAllDelayCall()
	{
	}

	private void StopTitleScrollingLoop()
	{
	}

	public void SetRandomAffixContentWithData(uint globalMissionAffixID, uint[] pickSourceAffixIDs)
	{
	}

	public void StartDelayCallSequencer(float scrollTime, float autoCloseDelayTime)
	{
	}

	private float GetStepDuration(int step)
	{
		return 0f;
	}

	private void ExecuteAnimationStep(int step)
	{
	}

	private void PrepareScrollingTitles()
	{
	}

	private void StartDiceAnimation()
	{
	}

	private void TitleScrollingLoop()
	{
	}

	private void UpdateScrollingTitle()
	{
	}

	private void ShowFinalAffixContent()
	{
	}

	private void AutoCloseUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
