using System.Collections.Generic;

namespace proto;

public class GameOpeningInfoRes
{
	public GameOpeningInfoDescList opening_info_list;

	public long timezone_offset_secs;

	public GameModeNameList game_mode_name_list;

	public ModeLevelLimitDescList mode_level_limit_list;

	public RankingLevelLimitDescList ranking_level_limit_list;

	public GameModeIntegrateDescList game_mode_integrate_list;

	public List<SpecialModeOpeningInfoDesc> special_mode_opening_list;

	public List<SpectateModeDesc> spectate_mode_list;

	public List<MMCertainMapDesc> mm_certain_map_list;

	public List<GameplayAffixEventStyleDesc> gameplay_affix_event_style_list;
}
