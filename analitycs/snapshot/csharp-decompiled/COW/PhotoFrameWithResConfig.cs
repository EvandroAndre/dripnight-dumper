using GCommon;
using proto;

namespace COW;

public class PhotoFrameWithResConfig
{
	public PhotoFrameConfigDesc PhotoFrameConfig;

	public bool isOwned;

	public ulong expireTime;

	public ResourceID FrameRes;

	public ResourceID CobrandedLogoRes;

	public ResourceID CobrandedDescRes;

	public ResourceID PreviewSmallIconRes;
}
