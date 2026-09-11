using System.Collections.Generic;

namespace GCommon;

public class AnimationDynamicUGCData : CSVBaseData
{
	public string AniConName;

	public Dictionary<string, string> AniClipDic;

	private string[] AniClipDicStr;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	private void ParseAniClip()
	{
	}
}
