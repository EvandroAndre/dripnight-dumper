using GCommon;

namespace COW;

public class ItemExt : CSVBaseData
{
	public string EndTime;

	public uint Id;

	public byte SubType;

	public override bool AfterParseData()
	{
		return false;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public bool _003C_003EiFixBaseProxy_AfterParseData()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
