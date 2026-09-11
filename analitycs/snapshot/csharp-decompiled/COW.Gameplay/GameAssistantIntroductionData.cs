namespace COW.Gameplay;

public abstract class GameAssistantIntroductionData
{
	public uint m_EventType;

	public GameAssistantIntroductionData(uint eventType)
	{
	}

	public abstract void SetConfigData(int[] conditions, int[] subConditions);

	public abstract bool HasTriggered(int condition);

	public abstract bool MeetConditions(int condition);

	public abstract void UpdateCacheData(int condition);

	public abstract bool CheckIsTriggerInThisMatch(int[] conditions, int[] subConditions);
}
