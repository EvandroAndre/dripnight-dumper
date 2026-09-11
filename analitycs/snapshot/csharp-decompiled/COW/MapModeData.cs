using System;
using System.Collections.Generic;

namespace COW;

public class MapModeData : IComparable<MapModeData>
{
	public uint match_mode;

	public uint game_mode;

	public uint map_mode;

	public uint info_id;

	public string bg_sprite;

	public bool is_new;

	public bool force_autoMatch;

	public uint config_id;

	public uint level_visual_style;

	public List<int> difficulty;

	public uint sort_id;

	public uint tag;

	public string visualMapUrl;

	public string visualMapUrl02;

	public string tutorialUrl;

	public string tutorialUrlCSSpecialMatch;

	public string awardUrl;

	public bool IsSpecialMode;

	public bool IsMapRandom;

	public string match_mode_image;

	public bool IsLiveOpen;

	public uint LiveEffectsID;

	public bool MAXOnly;

	public uint DownloadOptionalReDefId;

	public uint DLCDownloadOptionalReDefId;

	public uint RoomID;

	public uint DropID;

	public string name;

	public MapModeData()
	{
	}

	public MapModeData(uint matchMode, uint gameMode, uint mapMode, string spriteName, uint sortId)
	{
	}

	public int CompareTo(MapModeData other)
	{
		return 0;
	}

	public static implicit operator MapModeData(MapOpeningInfo openInfo)
	{
		return null;
	}
}
