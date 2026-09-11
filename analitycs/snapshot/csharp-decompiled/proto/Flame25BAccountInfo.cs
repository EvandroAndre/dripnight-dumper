using System.Collections.Generic;

namespace proto;

public class Flame25BAccountInfo
{
	public class Flame25BPrivateAccountInfo
	{
		public uint choose_pose_id;

		public uint daily_like_total;

		public long update_like_time;

		public uint max_progress;

		public long update_progress_time;

		public bool is_use_loading;

		public uint reach_progress;

		public bool is_init;

		public uint match_progress;

		public uint like_progress;
	}

	public class Flame25BLikeEvent
	{
		public ulong event_serial_id;

		public ulong account_id;

		public long like_time;
	}

	public class Flame25BDailyProgress
	{
		public long update_time;

		public uint progress;
	}

	public Flame25BPrivateAccountInfo private_info;

	public Flame25BPublicAccountInfo public_info;

	public List<Flame25BDailyProgress> daily_progresses;

	public List<Flame25BLikeEvent> like_events;
}
