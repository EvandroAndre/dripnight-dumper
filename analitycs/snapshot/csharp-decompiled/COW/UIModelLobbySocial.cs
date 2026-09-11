using System;
using System.Collections.Generic;
using GCommon;
using message;
using proto;
using tcp;

namespace COW;

public class UIModelLobbySocial : UIBaseModel
{
	private class PendingSocialHallChosenTitle
	{
		public ulong UserID;

		public proto.ESocialHall.TitleType ChosenTitleType;

		public PendingSocialHallChosenTitle(ulong userID, proto.ESocialHall.TitleType chosenTitleType)
		{
		}
	}

	public enum EInteractTitleState
	{
		None,
		UnReach,
		ReachUnClaim,
		Claimed
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public UIModelLobbySocial _003C_003E4__this;

		public string cmd;

		public Action<bool> callback;

		internal void _003CRequestClaimArenaTitle_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public UIModelLobbySocial _003C_003E4__this;

		public string cmd;

		public Action<bool> callback;

		internal void _003CRequestClaimDanceTitle_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public proto.ESocialHall.TitleType chosenTitleType;

		public Action<bool> callback;

		internal void _003CRequestChooseTitle_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private const uint TITLE_NOT_CLAIMED = 0u;

	private const uint TITLE_CLAIMED = 1u;

	private uint m_DanceTime;

	private uint m_DanceTitleLevel;

	private uint m_LobbyLWTitleLevel;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private readonly Dictionary<uint, PendingSocialHallChosenTitle> m_PendingSocialHallChosenTitles;

	private MatchmakingSussNtf m_CacheRoomReconnectInfo;

	private string m_CacheRoomReconnectAddr;

	private int m_CacheRoomReconnectPort;

	public uint DanceTime => 0u;

	public uint LocalLobbyLWTitleWinStreak => 0u;

	public uint TitleMinTime => 0u;

	public EInteractTitleState DanceTitleState => EInteractTitleState.None;

	public bool HasClaimedDanceTitle => false;

	public uint TitleWinStreak => 0u;

	public EInteractTitleState LobbyLWTitleState => EInteractTitleState.None;

	public bool HasClaimedLobbyLWTitle => false;

	public ResourceID GetLobbyLWWinStreakVFXResourceID(uint maxWinStreak)
	{
		return default(ResourceID);
	}

	public override void Init()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void SetSocialHallInfo(KFBDFCBIIFO info)
	{
	}

	public void RequestClaimArenaTitle(Action<bool> callback)
	{
	}

	public void RequestClaimDanceTitle(Action<bool> callback)
	{
	}

	public bool RequestChooseTitle(proto.ESocialHall.TitleType chosenTitleType, Action<bool> callback = null)
	{
		return false;
	}

	public void OnSocialHallChooseTitleNtf(ulong userId, uint playerId, proto.ESocialHall.TitleType chosenTitleType)
	{
	}

	public void ApplyPendingSocialHallChosenTitle(ulong userId, uint playerId)
	{
	}

	public void RemovePendingSocialHallChosenTitle(uint playerId)
	{
	}

	public void ClearPendingSocialHallChosenTitles()
	{
	}

	private bool TryApplySocialHallChosenTitle(ulong userId, uint playerId, proto.ESocialHall.TitleType chosenTitleType)
	{
		return false;
	}

	public void OnSocialHallUpdateDanceInfoNtf(uint danceTime)
	{
	}

	public void CacheRoomReconnectInfo(MatchmakingSussNtf info, string addr, int port)
	{
	}

	public bool HasRoomReconnectInfo()
	{
		return false;
	}

	public void TryRoomReconnect()
	{
	}

	private void ClearCacheRoomInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
