namespace GCommon;

public class TimeService
{
	private float m_GameTime;

	private float m_LastGameTime;

	private float m_DeltaTime;

	private uint m_DeltaTickCount;

	private uint m_TickCount;

	private uint m_RealDoLogicTickCount;

	private bool m_UsingFixedDeltaTime;

	private float m_FixedDeltaTime;

	public float GameTime => 0f;

	public float LastGameTime => 0f;

	public float FixedDeltaTime => 0f;

	public float DeltaTime => 0f;

	public uint DeltaTickCount => 0u;

	public uint TickCount => 0u;

	public uint RealDoLogicTickCount => 0u;

	public void Reset()
	{
	}

	public void UseFixedDeltaTime(float fixedDeltaTime)
	{
	}

	public void UpdateTime()
	{
	}

	public void ClearDeltaTime()
	{
	}

	public void UpdateRealDoLogicTickCount()
	{
	}
}
