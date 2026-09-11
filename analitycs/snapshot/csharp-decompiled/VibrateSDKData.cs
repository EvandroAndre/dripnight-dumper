using GCommon;

public class VibrateSDKData : CSVBaseData
{
	public int id;

	public string effect_name;

	public int priority;

	public int seting_type;

	public bool isSettingOpen;

	public float duration;

	public string vibrateContent;

	public int setting_type_Group;

	public int amplitude;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
