namespace COW;

public class AlbumPhotoInfo
{
	public string native_identifier;

	public string file_path;

	public string photo_thumbnail_path;

	public EAlbumPhotoSceneType scene_type;

	public string ingame_mode_name;

	public string ingame_map_name;

	public long time_ticks;

	public long photo_size;

	public string check_sum;

	public bool is_screenshot;

	public bool is_vertical;

	public bool is_mark_delete;

	public bool is_cutting_result;

	public HighlightInfo highlightInfo;

	public UGCExtraInfo ugcExtraInfo;

	public string GetTrueFilePath()
	{
		return null;
	}

	public string GetTrueThumbnailPath()
	{
		return null;
	}
}
