using System.Collections.Generic;

namespace proto;

public class CSGetSeventhBDataInfoRes
{
	public SeventhBData data;

	public SeventhBFriendInfoRes pos_info;

	public List<PeakRankInfo> br_peak_rank_infos;

	public List<PeakRankInfo> cs_peak_rank_infos;
}
