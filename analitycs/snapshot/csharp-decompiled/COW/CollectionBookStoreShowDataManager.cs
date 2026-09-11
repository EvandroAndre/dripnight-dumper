using System.Collections.Generic;
using GCommon;

namespace COW;

public class CollectionBookStoreShowDataManager : SingletonModule<CollectionBookStoreShowDataManager>
{
	private Dictionary<uint, CollectionBookStoreShowData> m_dictIdToBookData;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public CollectionBookStoreShowData GetDataByBOOKID(uint bookID)
	{
		return null;
	}
}
