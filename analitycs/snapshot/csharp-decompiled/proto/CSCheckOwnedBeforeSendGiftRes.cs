using System.Collections.Generic;

namespace proto;

public class CSCheckOwnedBeforeSendGiftRes
{
	public class ItemSource
	{
		public uint item_id;

		public uint commodity_id;

		public GiftSource source;
	}

	public class ItemsSource
	{
		public List<ItemSource> items;
	}

	public enum GiftSource
	{
		GiftSource_None,
		GiftSource_INVENTORY,
		GiftSource_MAIL
	}

	public List<ItemsSource> accs_owned_list;
}
