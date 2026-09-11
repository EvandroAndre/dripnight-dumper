using System;
using System.Collections.Generic;
using System.Text;
using GCommon;
using proto;

namespace COW;

public class UIModelLobbyEventBubble : UIBaseModel, IUIModelDataChangeObserver
{
	public enum NewModeGotoFrom
	{
		Splash = 1,
		BigBanner,
		SmallBanner,
		NewModeBubble
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public LobbyEventType type;

		internal bool _003CAddLobbyEventBubbleData_003Eb__0(LobbyEventBubbleData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public LobbyEventType type;

		internal bool _003COnEventDataReady_003Eb__0(uint x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public LobbyEventType lobbyEventType;

		internal bool _003CIsBubbleShowing_003Eb__0(LobbyEventBubbleData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public uint curNewModebubbleId;

		internal bool _003CCheckMatchBubbleId_003Eb__0(NewModeBubbleDesc x)
		{
			return false;
		}
	}

	public const uint PropID_GetBubbleDesc = 1u;

	private List<LobbyEventBubbleData> m_EventBubbleList;

	private List<uint> m_DataReadyList;

	private static readonly Dictionary<uint, int> m_EventBubbleSortIdDict;

	private UIModelMapOpeningInfo.GameModeSortData m_CurNewModeSortData;

	private bool m_HasProcessPlayerPrefsKey;

	public StringBuilder gameModeSelectionNewModeGuide;

	public StringBuilder lobbyNewModeBubble;

	private NewModeBubbleDesc m_CurNewModeBubbleDesc;

	private uint m_NewModeTable2ItemIndex;

	private string m_BubbleTotalKey;

	private List<string> m_NewModeBubbleIdList;

	private string m_GuideTotalKey;

	private List<string> m_NewModeGuideIdList;

	private List<NewModeBubbleDesc> m_NewModeBubbleDescList;

	public UIModelMapOpeningInfo.GameModeSortData curNewModeSortData => null;

	public uint mewModeTable2ItemIndex
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void ClearData()
	{
	}

	public uint GetNewModeBubbleID()
	{
		return 0u;
	}

	public string GetNewModeBubbleTotalKey()
	{
		return null;
	}

	public string GetNewModeGuideTotalKey()
	{
		return null;
	}

	public List<LobbyEventBubbleData> GetEventBubbleList()
	{
		return null;
	}

	public void RefreshBubble()
	{
	}

	public List<uint> GetDataReadyList()
	{
		return null;
	}

	private int SortEventBubbleList(LobbyEventBubbleData a, LobbyEventBubbleData b)
	{
		return 0;
	}

	private int SortDataReadyList(uint a, uint b)
	{
		return 0;
	}

	public bool AddLobbyEventBubbleData(LobbyEventType type, Func<bool> canShow, Func<bool> EventShowInContainer, Action resetBubble)
	{
		return false;
	}

	public void OnEventDataReady(LobbyEventType type)
	{
	}

	public bool CanShowBubbleByTimeKey(string key)
	{
		return false;
	}

	public void SetKeyNextDay(string key)
	{
	}

	public bool IsBubbleShowing(LobbyEventType lobbyEventType)
	{
		return false;
	}

	public bool ShowNewModeGuideIfNeed()
	{
		return false;
	}

	public bool CheckMatchBubbleId()
	{
		return false;
	}

	public string GetNewModeBubbleKey()
	{
		return null;
	}

	public void ClickNewModeLog(uint from)
	{
	}

	public void ResetNewModeBubbleKey()
	{
	}

	public void ResetNewModeGuideKey()
	{
	}

	public void ResetNewModeBubbleIdList()
	{
	}

	public void ResetNewModeGuideIdList()
	{
	}

	public void ProcessNewModeBubbleDesc(CSNewModeBubbleDescRes res)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
