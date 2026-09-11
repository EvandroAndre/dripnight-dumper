namespace proto;

public class EFresh
{
	public enum GuideMode
	{
		GuideMode_None,
		GuideMode_FORCE,
		GuideMode_CS
	}

	public enum PresetType
	{
		PresetType_None,
		PresetType_Newbie,
		PresetType_Veteran
	}

	public enum LoadoutPublishStatus
	{
		LoadoutPublishStatus_Delete,
		LoadoutPublishStatus_Unreleased,
		LoadoutPublishStatus_Publish
	}

	public enum KolConfigOperateType
	{
		KolConfigOperateType_None,
		KolConfigOperateType_EDIT,
		KolConfigOperateType_ADD,
		KolConfigOperateType_DELETE
	}
}
