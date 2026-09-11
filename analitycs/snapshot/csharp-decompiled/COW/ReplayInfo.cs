using System;
using System.Collections.Generic;

namespace COW;

[Serializable]
public class ReplayInfo
{
	public ulong MatchID;

	public int PlayerCount;

	public string MatchDateTime;

	public float GameTotalTime;

	public uint MapID;

	public uint MatchMode;

	public uint GameMode;

	public uint RoomType;

	public uint GroupMode;

	public uint LayerID;

	public ulong RoomId;

	public string RoomName;

	public bool IsClientReplay;

	public string FileName;

	public List<ReplayEvent> Events;

	public List<ReplayEvent> ReplayEvents;

	public List<ulong> PlayerHighlightUserIDs;

	public List<PlayerHighlightInfo> PlayerHighlightInfos;

	public bool HasAnyHighlight;

	public PlayerHighlightInfo GetPlayerHighlight(ulong userID)
	{
		return null;
	}

	public void SetPlayerHighlight(ulong userID, PlayerHighlightInfo info)
	{
	}

	public bool ContainsPlayerHighlight(ulong userID)
	{
		return false;
	}

	public bool RemovePlayerHighlight(ulong userID)
	{
		return false;
	}

	public int GetPlayerHighlightCount()
	{
		return 0;
	}

	public List<ulong> GetAllPlayerHighlightUserIDs()
	{
		return null;
	}
}
