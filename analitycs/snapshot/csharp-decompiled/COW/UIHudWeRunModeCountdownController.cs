using System.Text;
using GCommon;
using message;

namespace COW;

public class UIHudWeRunModeCountdownController : UIBaseController
{
	private static int PHASE_PREPARE_COUNT_DOWN_SEC;

	private static int PHASE_FIGHT_START_LAST_SEC;

	private static int PHASE_FIGHT_COUNT_DOWN_LAST_SEC;

	private UIHudWeRunModeCountdownView m_View;

	private uint m_EndTime;

	private uint m_StartTime;

	private int mSeconds;

	private MKEIPDPNLOP m_CurPhase;

	private StringBuilder m_Timer;

	private uint min;

	private uint sec;

	private bool m_IsPreparePhaseEndCountDownEffect;

	private bool m_IsFightPhaseStartEffect;

	private bool m_IsFightPhaseCountDownEffect;

	private int m_FightPhaseCountDownShowIndex;

	private bool hasPlayRetreatVoice;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdatePhase(MKEIPDPNLOP phase, uint endTime, uint startTime)
	{
	}

	private void Update()
	{
	}

	private void RefreshPreparePhaseNormalCountDown(bool isShow)
	{
	}

	private void RefreshPreparePhaseEndCountDownEffect(bool isShow)
	{
	}

	private void RefreshFightPhaseStartEffect(bool isShow)
	{
	}

	private void RefreshFightPhaseCountDownEffect(bool isShow, bool isLastShow)
	{
	}

	private void RefreshCountDownLabel(UILabel uiLabel)
	{
	}

	private void PlayRetreatVoice()
	{
	}

	private void PlayStartVoice()
	{
	}

	public int GetCurCountDownLeftSec()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
