using System.Collections.Generic;

namespace proto;

public class CSGetFlashStoreAccountInfoRes
{
	public ulong account_id;

	public uint flash_store_id;

	public List<AccountFlashStorePurchase> account_flash_store_purchase;
}
