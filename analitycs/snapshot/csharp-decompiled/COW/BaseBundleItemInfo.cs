using proto;

namespace COW;

public class BaseBundleItemInfo
{
	public uint award_id;

	public bool is_preview;

	public uint preview_avatar;

	public BaseBundleItemInfo(BundleShowData bundleitem)
	{
	}

	public BaseBundleItemInfo(TreasureBoxShowData bundleitem)
	{
	}
}
