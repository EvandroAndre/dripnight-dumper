using System.Collections.Generic;
using GCommon;

namespace COW.GamePlay;

internal class AJMGIJJMNAH : CSVBaseData, IGetId
{
	public enum PGNLHBOCOJN
	{
		LoadoutSubType_Campfire,
		LoadoutSubType_Carepackage,
		LoadoutSubType_Treasuremap,
		LoadoutSubType_BountyContract,
		LoadoutSubType_BountyScanner,
		LoadoutSubType_CS_SUPPLIES,
		LoadoutSubType_CS_BAG0,
		LoadoutSubType_CS_MARKER,
		LoadoutSubType_CS_AIRDROP,
		LoadoutSubType_CS_TREASUREMAP_TeamBuff,
		LoadoutSubType_CS_BOUNTY,
		LoadoutSubType_AirdropCar,
		LoadoutSubType_CS_STYLELOADOUT_MARKER,
		LoadoutSubType_GameMission,
		LoadoutSubType_CreateLoot,
		LoadoutSubType_CreateMapCampFire,
		LoadoutSubType_CreateMapSmoke,
		LoadoutSubType_CreateMapSpaceShield,
		LoadoutSubType_HealRobot,
		LoadoutSubType_CS_TREASUREMAP_GiveItem,
		MAX
	}

	public HENEHAGJCLI FJCPKOMMIPH;

	public uint FPANKJIJBIH;

	public PGNLHBOCOJN EEOJJNLHJPG;

	public bool ADOJPHDKMMD;

	public int MOGFFFHEKLB;

	public Dictionary<string, string> CJIIHENEKKL;

	public List<string> LMOIGKGFBHO;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long NIBBKONKPHP, int AOHKLOEKIDA, string[] KNLLNGJMIDB, string[] NMGMFIGPBGL)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
