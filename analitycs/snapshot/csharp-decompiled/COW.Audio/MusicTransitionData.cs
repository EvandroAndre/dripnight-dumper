namespace COW.Audio;

public class MusicTransitionData
{
	private MusicTransitionRule m_TransitionRule;

	public TransitionStatus ExitStatus;

	public TransitionStatus EnterStatus;

	public readonly TransitionExitPosition ExitPosition;

	public readonly TransitionEnterPosition EnterPosition;

	private float m_BaseTimeStamp;

	private float m_ExitTimeStamp;

	private float m_EnterTimeStamp;

	public int EnterSample;

	public float LastCheckTime;

	public float ExitOffset => 0f;

	public float EnterOffset => 0f;

	public float FadeOutTime => 0f;

	public float FadeInTime => 0f;

	public float TimeUntilTransition => 0f;

	public float TimeUntilExit => 0f;

	public float TimeUntilEnter => 0f;

	public MusicTransitionData(MusicTransitionRule transitionRule)
	{
	}

	public void SetTimeStamps(float baseDelay, float preEntryTime)
	{
	}
}
