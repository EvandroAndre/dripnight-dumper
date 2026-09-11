using System.Collections.Generic;
using GCommon;

namespace COW;

public class ClothesSetIDDataManager : SingletonModule<ClothesSetIDDataManager>
{
	private bool m_IsLoaded;

	private Dictionary<uint, uint> m_DictClothesSetIDToLikeItemID;

	private Dictionary<uint, uint> m_DictLikeItemIDToClothesSetID;

	private List<uint> m_SetIDList;

	private Dictionary<uint, List<uint>> m_DictClothesSetIdToLinkSetId;

	protected override void OnInit()
	{
	}

	private void LoadData()
	{
	}

	protected override void OnCleanup()
	{
	}

	public uint GetClothesIDByClothesSetID(uint clothesSetID)
	{
		return 0u;
	}

	public List<uint> GetAllSetIDList()
	{
		return null;
	}

	public List<uint> GetLikeItemIDListBySetIDList(List<uint> setIDList)
	{
		return null;
	}

	public uint GetClothesSetIDByLikeItemID(uint likeItemID)
	{
		return 0u;
	}

	public List<uint> GetLinkSetIdListByClothesSetID(uint clothesSetID)
	{
		return null;
	}
}
