using System.Collections.Generic;

namespace proto;

public class CSGetMocoMonthSettingRes
{
	public MocoMonthSettingDesc setting;

	public List<MocoMonthChatDesc> chat_desc;

	public List<MocoMonthLevelDesc> level_desc;

	public List<MocoMonthLevelRandomDesc> level_random_desc;

	public List<MocoMonthEnemyDesc> enemy_desc;

	public MocoMonthPlayerDesc player_desc;

	public MocoMonthGameConfigDesc game_config_desc;
}
