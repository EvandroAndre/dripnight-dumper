using System.Collections.Generic;

namespace proto;

public class CSSetPlayerGalleryInfoSettingReq
{
	public uint version;

	public List<GalleryShowInfo> info_items;
}
