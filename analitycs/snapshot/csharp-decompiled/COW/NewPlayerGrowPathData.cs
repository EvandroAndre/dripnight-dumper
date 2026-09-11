using System.Collections.Generic;
using proto;

namespace COW;

public class NewPlayerGrowPathData
{
	public int Index;

	public uint Level;

	public float Progress;

	public NewPlayerGrowPathNodeState NodeState;

	public NewPlayerGrowPathDataType Type;

	public AwardDesc AwardItemDisplay;

	public List<AwardDesc> AwardItemList;

	public string AwardIcon;

	public string AwardIconBig;

	public string SystemIconName;

	public string SystemTitle;

	public string SystemDetail;

	public EInventory.AwardType AwardType => EInventory.AwardType.AwardType_NONE;
}
