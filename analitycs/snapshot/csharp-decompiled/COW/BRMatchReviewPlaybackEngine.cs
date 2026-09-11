using System.Collections.Generic;

namespace COW;

public class BRMatchReviewPlaybackEngine
{
	private const float DEFAULT_SPEED_FAST = 20f;

	private const float DEFAULT_SPEED_SLOW = 2f;

	private const float DEFAULT_EVENT_RANGE_SEC = 5f;

	private const float DEFAULT_TRANSITION_SEC = 3f;

	private float m_AutoSpeedFast;

	private float m_AutoSpeedSlow;

	private long m_AutoSpeedEventRangeMs;

	private long m_AutoSpeedTransitionMs;

	private float m_CurrentTimeMs;

	private float m_TotalTimeMs;

	private float m_PlaybackSpeed;

	private EPlaybackState m_PlaybackState;

	private bool m_IsAutoPlay;

	private List<long> m_SortedEventTimesMs;

	public float GetCurrentTimeMs()
	{
		return 0f;
	}

	public float GetTotalTimeMs()
	{
		return 0f;
	}

	public void SetTotalTimeMs(float totalTimeMs)
	{
	}

	public EPlaybackState GetPlaybackState()
	{
		return EPlaybackState.Stopped;
	}

	public float GetPlaybackSpeed()
	{
		return 0f;
	}

	public bool GetIsAutoPlay()
	{
		return false;
	}

	public List<long> GetSortedEventTimes()
	{
		return null;
	}

	public void InitPlaybackData(float totalDurationMs, List<long> eventTimesMs)
	{
	}

	public void SetPlaybackTime(float timeMs)
	{
	}

	public void SeekPlaybackTime(float timeMs)
	{
	}

	public void SetPlaybackState(EPlaybackState state)
	{
	}

	public void SetAutoPlay(bool autoPlay)
	{
	}

	public float EvaluateAutoSpeed(float currentTimeMs)
	{
		return 0f;
	}

	public void Reset()
	{
	}

	private void LoadConfigSpeedParams()
	{
	}

	private int FindClosest(List<long> sortedList, long target)
	{
		return 0;
	}
}
