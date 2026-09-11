using System.Collections.Generic;

namespace tcp;

public class InventoryTailorChangeNtf
{
	public class ChangeUnlockInfo
	{
		public uint tailor_id;

		public uint unlock_id;

		public UnlockType type;
	}

	public enum UnlockType
	{
		UnlockTypeNone,
		UnlockTypeBuy,
		UnlockTypeUnlock,
		UnlockTypeExistsReward,
		UnlockTypeBase
	}

	public uint[] tailor_ids;

	public List<ChangeUnlockInfo> unlocks;
}
