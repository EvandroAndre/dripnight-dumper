using System.Collections.Generic;
using GCommon;

namespace COW;

public class IncubatorBlueprintDataManager : SingletonModule<IncubatorBlueprintDataManager>
{
	private readonly Dictionary<uint, IncubatorBlueprintData> m_IncubatorBlueprintDataDict;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public bool IsItemBelongsToIncubator(uint bluePrintItemID)
	{
		return false;
	}

	public bool IsComposeIconNeedModification(uint bluePrintItemID)
	{
		return false;
	}

	public ResourceID GetComposeIconRes(uint bluePrintItemID)
	{
		return default(ResourceID);
	}
}
