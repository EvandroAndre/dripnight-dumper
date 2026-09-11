namespace GCommon;

public class AnimationBlendConfigData : CSVBaseData
{
	private class AnimationBlendConfigDataContext
	{
		public string fadeOutAnimName;

		public string fadeInAnimName;
	}

	public long TransitionID;

	public bool UseFixedDuration;

	public float TransitionDuration;

	private AnimationBlendConfigDataContext context;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override bool AfterParseData()
	{
		return false;
	}

	public static long MakeTransitionID(AnimationID fadeOutAnim, AnimationID fadeInAnim)
	{
		return 0L;
	}
}
