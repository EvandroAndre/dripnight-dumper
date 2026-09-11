using System.Collections.Generic;
using GCommon;

namespace COW;

public class AvatarProfileDataManager : SingletonModule<AvatarProfileDataManager>, IUIModelDataChangeObserver
{
	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelInventory m_ModelInventory;

	private UIModelAvatar m_ModelAvatar;

	private bool m_IsBackpackReady;

	private bool m_IsAvatarInfoReady;

	private List<ResourceID> m_resourceIDList;

	private List<CSVBaseData> m_NPCSuit;

	private Dictionary<uint, AvatarSuitData> m_SuitDataDict;

	private Dictionary<uint, List<AvatarSuitData>> m_AvatarId2SuitDataDict;

	private Dictionary<uint, AvatarProfileData> m_AvatarProfileDataDict;

	public void MultiThreadInit()
	{
	}

	protected override void OnInit()
	{
	}

	private void LoadCSVData()
	{
	}

	private void ProcessSuitDataDict()
	{
	}

	public List<AvatarSuitData> GetAvatarSuitDataListByAvatarID(uint avatarId)
	{
		return null;
	}

	public AvatarSuitData GetDefaultAvatarSuitDataByAvatarID(uint avatarId)
	{
		return null;
	}

	public List<CSVBaseData> GetArenaNPCSuit()
	{
		return null;
	}

	public AvatarSuitData GetSuitData(uint suitID)
	{
		return null;
	}

	public Dictionary<uint, AvatarSuitData> GetSuidDict()
	{
		return null;
	}

	public Dictionary<uint, AvatarProfileData> GetAvatarPorfileDict()
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}

	public void ClearData()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}
}
