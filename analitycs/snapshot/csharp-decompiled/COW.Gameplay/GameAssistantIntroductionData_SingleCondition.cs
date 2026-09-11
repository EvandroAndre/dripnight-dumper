namespace COW.Gameplay;

public class GameAssistantIntroductionData_SingleCondition : GameAssistantIntroductionData
{
	private uint m_IsTriggered;

	public GameAssistantIntroductionData_SingleCondition(uint eventType)
		: base(0u)
	{
	}

	public override void SetConfigData(int[] conditions, int[] subConditions)
	{
	}

	public override bool HasTriggered(int condition)
	{
		return false;
	}

	public override bool MeetConditions(int condition)
	{
		return false;
	}

	public override void UpdateCacheData(int condition)
	{
	}

	public override bool CheckIsTriggerInThisMatch(int[] conditions, int[] subConditions)
	{
		return false;
	}
}
