using System.Collections.Generic;

namespace proto;

public class WinterLand25BAccountInfo
{
	public class DreamInfo
	{
		public string dream_file_name;

		public uint tag1;

		public uint tag2;

		public long create_time;
	}

	public bool mini_game_begin;

	public List<DreamInfo> dream_infos;

	public string apply_dream_file_name;

	public uint dream_limited;

	public uint cur_dream_stage;
}
