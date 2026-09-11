using System.Collections.Generic;

namespace proto;

public class CSGetMusicFestSettingRes
{
	public MusicFestSettingDesc setting;

	public List<MusicFestCardDesc> music_fest_card_desc_list;

	public List<MusicFestCardRewardDesc> music_fest_card_reward_desc_list;

	public List<MusicFestSignInDesc> sign_in_desc_list;

	public List<MusicFestPuzzleDesc> puzzle_desc_list;

	public List<MusicFestPuzzleProgressDesc> puzzle_progress_desc_list;

	public List<MusicFestGachaConditionDesc> gacha_condition_desc_list;
}
