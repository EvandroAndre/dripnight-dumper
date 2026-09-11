using System;
using System.Collections.Generic;
using proto;

namespace COW;

public class MapOpeningInfo
{
	public MapConfigData MapConfigData;

	public DateTime StartTimeInDay;

	public uint[] Weekdays;

	public DateTime EndTimeInDay;

	public string Tips;

	public uint MatchMode;

	public uint InfoUniqueID;

	public bool IsNew;

	public bool IsPermanent;

	public bool ForceAutoMatch;

	public uint LevelVisualStyle;

	public uint[] playerCounts;

	public bool IntraTeamDuel;

	public DateTime ConfigStartTime;

	public DateTime ConfigEndTime;

	public uint SortId;

	public List<int> difficulty;

	public uint tag;

	public string visualMapUrl;

	public string visualMapUrl02;

	public string tutorialUrl;

	public string tutorialUrlCSSpecialMatch;

	public string awardUrl;

	public string[] version;

	public bool is_random;

	public string match_mode_image;

	public bool is_force_random;

	public bool is_live_open;

	public uint live_effects_id;

	public bool max_only;

	public uint bubbleId;

	public uint RoomID;

	public uint DropID;

	public string name;

	public bool IsUGCOpen;

	public string UGCWorkshopCode;

	public string UGCMapUrl;

	private DateTime m_Date;

	public static implicit operator MapOpeningInfo(GameOpeningInfoDesc desc)
	{
		return null;
	}
}
