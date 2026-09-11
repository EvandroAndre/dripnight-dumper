using GCommon;

namespace COW;

public class WorkshopDialogueStyleLibraryData : CSVBaseData
{
	public uint Id;

	public string Skip;

	public string PageTurning;

	public string Name;

	public string Option;

	public string Window;

	public string ResourceFrom;

	public string ResourceWay;

	public string AtlasPath;

	public bool CraftlandShowControl;

	public bool FEShowControl;

	public string ResourceLevel;

	public bool IsObsolote;

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
