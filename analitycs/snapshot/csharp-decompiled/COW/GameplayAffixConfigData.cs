using GCommon;

namespace COW;

public class GameplayAffixConfigData : CSVBaseData, IGetId
{
	private string m_PackedAffixDesc;

	public string IngameTutorialDesc;

	public string AffixTitleKey;

	public string AffixDescKey;

	public string[] AffixDescArguments;

	public uint[] CDNGroupMode;

	public string AffixTutorialCDN;

	public ResourceID LobbyAffixIconPreview;

	public uint AffixID;

	public ResourceID IngameAffixIcon;

	public ResourceID IngameTutorialIcon;

	public int IngameDisplayTab;

	public ResourceID IngameBigMapAffixIconBg;

	public ResourceID IngameTabIcon;

	public ResourceID LobbyAffixIconLarge;

	public ResourceID LobbyAffixIcon;

	public bool HideIngame;

	public bool ShowMinimapCarousel;

	public bool IngameShowTutorial;

	public bool IngameBigMapAffixIconNoTint;

	public string AffixDesc => null;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
