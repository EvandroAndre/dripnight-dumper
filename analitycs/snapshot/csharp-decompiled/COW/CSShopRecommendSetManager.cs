using System.Collections.Generic;
using GCommon;

namespace COW;

public class CSShopRecommendSetManager : SingletonModule<CSShopRecommendSetManager>
{
	private List<CSShopRecommendSetData> m_Data;

	private Dictionary<uint, List<CSShopRecommendSetData>> m_DicData;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<CSShopRecommendSetData> GetDatasByItemID(uint itemID)
	{
		return null;
	}
}
