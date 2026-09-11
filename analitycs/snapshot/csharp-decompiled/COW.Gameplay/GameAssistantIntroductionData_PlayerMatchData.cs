using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay;

public class GameAssistantIntroductionData_PlayerMatchData : GameAssistantIntroductionData
{
	private PKFPFBJMNGJ valueCompareData;

	private uint m_IsTriggered;

	private Dictionary<Vector2Int, bool> m_DicValueAndCompareTypeToIsTrigger;

	public GameAssistantIntroductionData_PlayerMatchData(uint eventType)
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
