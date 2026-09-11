using System;

[Serializable]
public class ReplayKitVideoInfo
{
	public string filePath;

	public string video_path;

	public string bitmap_path;

	public long size;

	public int duration;

	public long time;

	public bool saved;

	public uint match_mode;

	public uint game_mode;

	public int game_type;

	public bool is_highlight_video;

	public string highlight_cover_label;

	public string video_record_path;

	public string audio_record_path;

	public string sandbox_video_path;

	public bool stoped;

	public string GetVideoPath()
	{
		return null;
	}

	public string GetVideoName()
	{
		return null;
	}

	public int GetLogType()
	{
		return 0;
	}

	public void SetGameType()
	{
	}

	public string ToPrefix()
	{
		return null;
	}

	public static string ToTime(long time, bool isNeedToLocal = false)
	{
		return null;
	}

	public static string GetMemorySize(long size)
	{
		return null;
	}

	public string GetDuration()
	{
		return null;
	}

	public static string GetDuration(int value)
	{
		return null;
	}
}
