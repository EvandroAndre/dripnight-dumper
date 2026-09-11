using UnityEngine;

namespace COW;

public class UICountDownLabel : MonoBehaviour
{
	public UILabel m_Label;

	private ulong endTime;

	private string m_Prefix;

	private string m_Suffix;

	private bool m_Formated;

	private bool m_ShortDisplay;

	private bool m_FuzzyDisplay;

	private bool m_MsOnlyDisplay;

	private bool m_ShowHour;

	private bool m_SecondOnlyDisplay;

	private bool m_SquadTreasureDisplay;

	private bool m_ShortDisplayHM;

	public OnStarted m_OnStarted;

	public OnFinished m_OnFinished;

	public OnUpdate m_OnUpdate;

	private uint m_DelayCall;

	private string m_fmtStringIDStyle;

	private string m_fmtPureStringStyle;

	public void SetCountDownEndTime(ulong end, bool shortDisplay, OnStarted onStarted = null, OnFinished onFinished = null)
	{
	}

	public void SetCountDownEndTimeNew(ulong end, bool shortDisplay, OnStarted onStarted = null, OnFinished onFinished = null, bool formated = true)
	{
	}

	public void SetCountDownEndTime(ulong end, string prefix = "", string suffix = "", bool formated = true, OnStarted onStarted = null, OnFinished onFinished = null, bool shortDisplay = true, bool isStarted = true, bool fuzzyDisplay = false, bool msOnlyDisplay = false)
	{
	}

	public void SetCountDownEndTimeNew(ulong end, string prefix = "", string suffix = "", bool formated = true, OnStarted onStarted = null, OnFinished onFinished = null, bool shortDisplay = true, bool isStarted = true, bool fuzzyDisplay = false, bool msOnlyDisplay = false, bool secondOnly = false, bool squadTreasureDisplay = false, bool shortDisplayHM = false)
	{
	}

	public void SetCountDownEndTime(CountDownConfig config)
	{
	}

	public void SetCountDownEndTimeNew(CountDownConfig config)
	{
	}

	public void SetUpdateDelegate(OnUpdate callback)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void CountDown()
	{
	}

	public bool IsDuringCountDown()
	{
		return false;
	}

	public void Cancel()
	{
	}

	public void SetFormatStyle(string fmtStringID)
	{
	}

	public void SetPureFormatStyle(string fmtString)
	{
	}
}
