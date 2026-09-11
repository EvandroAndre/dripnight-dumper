using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelOnlineMatch : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<OnlineMatch> _003C_003E9__9_0;

		internal int _003CSetHighestPriorityMatchType_003Eb__9_0(OnlineMatch a, OnlineMatch b)
		{
			return 0;
		}
	}

	private OnlineMatch m_HighestPriorityOnlineMatch;

	private bool m_SetHighestPriorityOnlineMatch;

	private List<OnlineMatch> m_OnlineMatchList;

	public const uint PropID_AllOnlineMatchInfoReady = 2u;

	public override uint GetModelType()
	{
		return 0u;
	}

	public void InitOnlineMatchList()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public OnlineMatchEntranceState GetEntranceBtnState()
	{
		return OnlineMatchEntranceState.Closed;
	}

	public bool IsCupMatchEntranceActivated()
	{
		return false;
	}

	public bool SetHighestPriorityMatchType()
	{
		return false;
	}

	public void SetEntranceWarmUpState()
	{
	}

	public bool AllProtocalReady()
	{
		return false;
	}

	public void MatchProtocalReady()
	{
	}

	public void SetLobbyEntranceWarmUpPlayerPrefs()
	{
	}

	public void SetLobbyEntranceMatchOpenPlayerPrefs()
	{
	}

	public List<AdvertDesc> GetEntranceCdnDesc()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
