namespace proto;

public class Trea25BAwardDesc
{
	public enum ETreaType
	{
		ETT_NONE,
		ETT_NORMAL,
		ETT_SPECIAL,
		ETT_TREA_PIECE
	}

	public enum ESpecialType
	{
		EST_NONE,
		EST_GOLDENSHOVEL,
		EST_RADAR,
		EST_BOMB,
		EST_SKYROCKET
	}

	public enum ETreaPieceType
	{
		ETPT_NONE,
		ETPT_TOP,
		ETPT_MIDDLE,
		ETPT_BOTTOM
	}

	public uint map_id;

	public uint trea_id;

	public uint trea_type;

	public string trea_name;

	public AwardDesc normal_award;

	public string icon;

	public AwardDesc helper_award;
}
