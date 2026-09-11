namespace proto;

public class GamePlaySkillUsedInfo
{
	public enum SkillType
	{
		None,
		UsedCount,
		InflictDamage,
		BlockDamage,
		KillCount
	}

	public uint used_skill_id;

	public SkillType used_skill_type;

	public uint effect_value;
}
