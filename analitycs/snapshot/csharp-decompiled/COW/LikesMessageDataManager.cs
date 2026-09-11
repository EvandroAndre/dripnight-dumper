using System.Collections.Generic;
using GCommon;

namespace COW;

public class LikesMessageDataManager : SingletonModule<LikesMessageDataManager>
{
	private List<LikesMessageData> m_DataList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<LikesMessageData> Datas()
	{
		return null;
	}
}
