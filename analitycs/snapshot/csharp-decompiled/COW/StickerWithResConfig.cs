using GCommon;
using proto;

namespace COW;

public class StickerWithResConfig
{
	public StickerConfigDesc StickerConfig;

	public bool isOwned;

	public ulong expireTime;

	public ResourceID IconRes;

	public ResourceID PreviewIconRes;
}
