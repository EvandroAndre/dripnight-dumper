namespace COW;

public class PresetRoomCreateRuleInfo
{
	public uint ID;

	public uint MapID;

	public uint GameMode;

	public uint MapConfigID;

	public uint GroupMode;

	public uint RoomType;

	public uint[] Members;

	public uint[] Spectators;

	public uint[] LevelLimits;

	public uint MinMemberCnt;

	public bool EnableVoiceChat;

	public bool AfkPunish;

	public bool EnableIngameVoice;

	public bool EnableScoreBoard;
}
