using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class AutoQuickChat : SingletonModule<AutoQuickChat>
{
	public enum EAutoChatEventType
	{
		None,
		PersonPassive,
		PersonActive,
		TeamCommon
	}

	public const uint CS_MAXEP_ITEMID = 8013u;

	public const uint CS_EPSPEEDUP_ITEMID = 8014u;

	public const uint CS_SPEEDUP_ITEMID = 8015u;

	public const uint CS_EXTRA_MEDKIT = 8016u;

	private Dictionary<uint, float> m_ChatCDMap;

	private Dictionary<uint, float> m_AutoEventCDMap;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void SendAutoQuickChatAnyMode(LKIBAMHPNOM actionIndex, uint targetId)
	{
	}

	public void SendAutoQuickChat(LKIBAMHPNOM actionIndex, LLPIFHCLLCF gameMode, uint itemDataID = 0u, uint param4 = 0u)
	{
	}

	public void RefreshAutoQuickChatCD(LKIBAMHPNOM autoChatId)
	{
	}

	public bool IsSyncAutoQuickChatInCD(LKIBAMHPNOM quickChatID)
	{
		return false;
	}

	public bool IsAutoQuickChatInCD(LKIBAMHPNOM quickChatID)
	{
		return false;
	}
}
