namespace COW;

public class HudUploadItem
{
	public enum EHudUploadStatus
	{
		NoContent,
		Unpublished,
		Published
	}

	public int ToggleIdx;

	public HudUploadInfoItem HudUploadInfoItem;

	public EHudUploadStatus PublishState;

	public HudUploadItem()
	{
	}

	public HudUploadItem(int toggleIdx)
	{
	}
}
