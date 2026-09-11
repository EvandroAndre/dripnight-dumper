using GCommon;

namespace COW;

public class IngameBattleStyleLoadoutData : CSVBaseData, IGetId
{
	public uint PrimaryKey;

	public uint ID;

	public uint Mode;

	public uint[] AbilityID;

	public string HudIcon;

	public string DescKey;

	public string NameKey;

	public string LobbyIcon;

	public string BrDescKey;

	public string CsDescKey;

	public ResourceID EquipEffect;

	public string BgIcon;

	public string HudTipsKey;

	public ResourceID BgEffect;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
