using System.Collections.Generic;
using GCommon;

namespace COW;

public class PlayerSocialTagsDataManager : SingletonModule<PlayerSocialTagsDataManager>
{
	private Dictionary<uint, List<PlayerSocialTagsData>> m_DicData;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public string GetSocicalKeyById(uint typeid, uint sortid)
	{
		return null;
	}

	public string GetIconByTypeIDAndSortID(uint typeid, uint sortid)
	{
		return null;
	}

	public List<PlayerSocialTagsData> GetPlayerSocialTagsByType(uint typeid, bool needunlimited)
	{
		return null;
	}
}
