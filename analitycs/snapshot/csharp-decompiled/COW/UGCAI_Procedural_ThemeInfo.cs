using GCommon;

namespace COW;

public class UGCAI_Procedural_ThemeInfo : CSVBaseData
{
	public string themeName;

	public string theme_ItemIDListDesc;

	public int[] theme_ItemIDList;

	public string themeDesc;

	public string themeIMG;

	public int themeID;

	public bool New;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
