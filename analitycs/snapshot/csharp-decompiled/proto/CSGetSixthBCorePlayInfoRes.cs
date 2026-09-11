using System.Collections.Generic;

namespace proto;

public class CSGetSixthBCorePlayInfoRes
{
	public uint cur_progress;

	public uint[] claimed_box_progress;

	public List<StickerInfo> sticker_list;

	public uint cs_vrp_remaining_times;

	public uint br_vrp_remaining_times;
}
