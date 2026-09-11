using System.Collections.Generic;
using GCommon;

namespace COW;

public class CSSharedAvatarDataManager : SingletonModule<CSSharedAvatarDataManager>
{
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public uint bundleID;

		internal bool _003CFindAvatarDataByBundleID_003Eb__0(CSSharedAvatarData x)
		{
			return false;
		}
	}

	private Dictionary<uint, CSSharedAvatarData> m_dictIdToAvatarData;

	private Dictionary<int, List<CSSharedAvatarData>> m_dictGenderToAvatarData;

	private List<uint> m_DefaultPVEWeapons;

	private Dictionary<uint, Dictionary<uint, AvatarAwakenTaskData>> m_dicToAvatarAwakenTaskData;

	private List<CSSharedAvatarData> m_AvatarDataList;

	private Dictionary<uint, int> m_FemaleWardrobeeReceipeDict;

	private Dictionary<uint, int> m_FemaleWardrobeReceipeDictInGame;

	private Dictionary<uint, int> m_MaleWardrobeReceipeDict;

	private Dictionary<uint, int> m_MaleWardrobeReceipeDictInGame;

	private List<ResourceID> m_resourceIDList;

	public void MultiThreadLoad(object o)
	{
	}

	public void MultiThreadInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	private void LoadCSVData()
	{
	}

	public CSSharedAvatarData FindCSSharedAvatarDataById(uint InId)
	{
		return null;
	}

	public void SetDefaultAvatarReceipe(bool isFemale, bool inLobby, uint wardrobeType, int receipe)
	{
	}

	public int GetDefaultAvatarReceipeByWardrobe(bool isFemale, bool isLobby, uint wardrobeType)
	{
		return 0;
	}

	public bool IsAvatarCantEquipHeadAdditive(uint avatarId)
	{
		return false;
	}

	public List<CSSharedAvatarData> FindCSSharedAvatarListByGender(int gender)
	{
		return null;
	}

	public uint FindDefaultAvatarIDByGender(int gender)
	{
		return 0u;
	}

	public bool HasAvatarFacialExpressionData()
	{
		return false;
	}

	public uint[] AllPVEWeapons()
	{
		return null;
	}

	public CSSharedAvatarData FindAvatarDataByPVEWeapon(uint weaponID)
	{
		return null;
	}

	public AvatarAwakenTaskData GetAvatarAwakenTaskData(uint avatarID, uint taskType)
	{
		return null;
	}

	public AvatarAwakenComicData GetAwakenComicData(uint avatarID, uint comicID)
	{
		return null;
	}

	public List<AvatarAwakenComicData> GetAwakenComicConfigList(uint avatarID)
	{
		return null;
	}

	public AvatarAwakenTaskRefreshData GetAvatarAwakenTaskRefreshData(uint avatarID)
	{
		return null;
	}

	public List<CSSharedAvatarData> GetALLAvatarInfo()
	{
		return null;
	}

	public CSSharedAvatarData FindAvatarDataByBundleID(uint bundleID)
	{
		return null;
	}

	public string GetAvatarKeyartUrl(uint avatarID)
	{
		return null;
	}
}
