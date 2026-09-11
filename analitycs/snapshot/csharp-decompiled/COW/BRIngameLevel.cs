using GCommon;

namespace COW;

public class BRIngameLevel : CSVBaseData
{
	public string TailColorStr;

	public string TailIcon;

	public string[] GiveItems;

	public string ShortKey;

	public string Key;

	public string HeadIcon;

	public uint LoadoutID;

	public uint ID;

	public uint ShowHudTips;

	public byte Level;

	public byte EXP;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
