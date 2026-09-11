using System.Collections.Generic;

namespace proto;

public class SparkLevelAwardDesc
{
	public uint level;

	public uint exp_upgrade;

	public uint stage_change;

	public List<EFriend.SparkFeatureUnlockType> feature_unlock;

	public string feature_icon;

	public AwardDesc spark_level_award;

	public string feature_title;

	public string feature_content;

	public string feature_icon_ash;

	public string feature_announce_icon;

	public string gacha_icon;
}
