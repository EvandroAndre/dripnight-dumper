using proto;

namespace COW;

public class ItemProbabilityInfo
{
	public uint Id;

	public string Name;

	public EInventory.RareType Rare;

	public uint Count;

	public uint ExpireTime;

	public bool IsUnique;

	public uint Probability;

	public uint jackpotID;
}
