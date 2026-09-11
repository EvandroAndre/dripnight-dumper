namespace proto;

public class TailorUnlockDesc
{
	public enum CdtType
	{
		CdtTypeInit,
		CdtTypeToken,
		CdtTypeClothesSet,
		CdtTypeItem,
		CdtTypeGems
	}

	public enum UnlockType
	{
		UnlockTypeNone,
		UnlockTypeClothesSet,
		UnlockTypeClothes,
		UnlockTypeEffectItem,
		UnlockTypeCollectionItem
	}

	public uint tailor_id;

	public uint unlock_index;

	public uint cdt_type;

	public uint cdt_amount;

	public uint[] cdt_ids;

	public uint unlock_type;

	public uint unlock_item;

	public string cdt_key;

	public uint bundle_id;

	public long unlock_start_time;

	public long unlock_end_time;
}
