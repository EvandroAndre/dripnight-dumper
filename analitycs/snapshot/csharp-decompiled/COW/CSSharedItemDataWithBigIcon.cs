using GCommon;

namespace COW;

public class CSSharedItemDataWithBigIcon : CSSharedItemData
{
	private ResourceID m_BigIcon;

	public override ResourceID BigIcon => default(ResourceID);

	public CSSharedItemDataWithBigIcon(CSSharedLikeItemData likeItemData)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_get_BigIcon()
	{
		return default(ResourceID);
	}
}
