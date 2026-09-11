using System;

namespace COW;

public class RoomInfo : IEquatable<RoomInfo>
{
	public enum ERoomType
	{
		None,
		LobbySocial
	}

	public enum EVoiceJoinScene
	{
		Other,
		CustomRoomMatch
	}

	public string RoomID;

	public string UserID;

	public string Tag;

	public string ChannelID;

	public bool IsForLoading;

	public EVoiceJoinScene JoinScene;

	public ERoomType RoomType;

	public RoomInfo()
	{
	}

	public RoomInfo(string roomID, string userID, string tag = "", bool is_for_loading = false, EVoiceJoinScene join_scene = EVoiceJoinScene.Other, ERoomType roomType = ERoomType.None)
	{
	}

	public bool Equals(RoomInfo other)
	{
		return false;
	}
}
