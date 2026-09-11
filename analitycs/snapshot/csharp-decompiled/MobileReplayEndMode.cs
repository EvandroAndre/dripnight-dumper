public struct MobileReplayEndMode
{
	public enum ReplayEndMode
	{
		NULL,
		Normal,
		Highlight,
		Booyah
	}

	public enum ReplayState
	{
		Running,
		Normal,
		Highlight,
		Booyah,
		End
	}

	private ReplayEndMode m_EndMode;

	private long m_EndTimeMS;

	public void SetMode(ReplayEndMode mode, long timeMS)
	{
	}

	public ReplayState GetReplayState(long timeMS)
	{
		return ReplayState.Running;
	}

	public void Clear()
	{
	}
}
