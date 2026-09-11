using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class InGameAutoRecommendMessageManager : SingletonModule<InGameAutoRecommendMessageManager>
{
	private Dictionary<uint, InGameAutoRecommendMessage> m_InGameAutoRecommendMessageMap;

	private uint m_ResetEventIDDelayCallId;

	private uint m_CurEventID;

	public uint CurEventID => 0u;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	private void InitInGameAutoRecommendMessageData()
	{
	}

	public void SetCurEventID(uint eventId)
	{
	}

	public IngameQuickChatData GetRecommendMessageData()
	{
		return null;
	}

	public void OnAchieveAnAceTeam(BHGGAEEHJCO killerID)
	{
	}

	private uint GetRecommendMessagePriority(uint eventId)
	{
		return 0u;
	}

	private void _003CSetCurEventID_003Eb__8_0()
	{
	}
}
