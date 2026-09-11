using System.Collections.Generic;

namespace proto;

public class GetProfileAllDescRes
{
	public CSGetHideAvatarRes hide;

	public CSGetAvatarAwakenRes avatar_awaken;

	public CSGetGoPosRes go_pos;

	public BuddySkillSettingDesc buddy_skill_setting;

	public List<AvatarProficiencyRewardDesc> proficiency_reward_descs;

	public List<AvatarProficiencyLevelDesc> proficiency_level_descs;

	public List<AvatarJumpDesc> avatar_jump_descs;

	public bool awaken_switch;

	public List<LoadoutModePresetCorrelationDesc> mode_preset_correlation_list;

	public List<AvatarNewDesc> avatar_new_descs;
}
