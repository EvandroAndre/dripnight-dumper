using GCommon;

public class AvatarLookAtData : CSVBaseData
{
	public uint AvatarID;

	public uint[] UIType;

	public uint[] EyeUIType;

	public float EyeAngleMax;

	public float EyeAngleMin;

	public float EyeAngleInMax;

	public float EyeAngleInMin;

	public float EyeTurnSpeed;

	public float EyeInLerpSpeed;

	public float EyeNewFrameAngleWeight;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
