using System.Collections.Generic;
using GCommon;

namespace COW;

public class BigHeadDataConfigManager : SingletonModule<BigHeadDataConfigManager>
{
	private Dictionary<ulong, BigHeadDataConfig> DatasMap;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public BigHeadDataConfig GetData(uint map_id, uint mode_id)
	{
		return null;
	}

	private BigHeadDataConfig LoadConfig(uint id)
	{
		return null;
	}

	private BigHeadDataConfig LoadConfig(ResourceID resId)
	{
		return null;
	}
}
