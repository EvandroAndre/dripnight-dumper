using System.Collections.Generic;
using GCommon;

namespace COW;

public class AvatarWebDataManager : SingletonModule<AvatarWebDataManager>
{
	private List<AvatarWebData> m_Data;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}
}
