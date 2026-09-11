using System.Collections.Generic;

namespace proto;

public class CSGetSixthBWarmUpInfoRes
{
	public uint consumed_token_cnt;

	public uint claimed_times;

	public List<SixthBBulletComment> friend_comments;

	public List<SixthBBulletComment> mock_comments;

	public uint world_progress_numerator;

	public uint world_progress_denominator;
}
