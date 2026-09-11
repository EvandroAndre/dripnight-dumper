using proto;

namespace COW;

public class CustomCard_CardData
{
	public enum CardCNDType
	{
		Normal,
		Big,
		Small
	}

	private uint _003Cid_003Ek__BackingField;

	private uint _003Cquality_003Ek__BackingField;

	private uint _003Ctitle_loc_key_003Ek__BackingField;

	private uint _003Cdesc_loc_key_003Ek__BackingField;

	private uint unlock_cdn_id;

	private uint unlock_small_cdn_id;

	private uint unlock_big_cdn_id;

	private uint lock_cdn_id;

	private uint lock_small_cdn_id;

	private uint lock_big_cdn_id;

	private uint _003CwishValue_003Ek__BackingField;

	private uint _003CpurchaseValue_003Ek__BackingField;

	private uint _003CpurchaseLimit_003Ek__BackingField;

	private CustomCardInfo.WishState _003Cstate_003Ek__BackingField;

	private uint _003Camount_003Ek__BackingField;

	private uint _003CinventoryAmount_003Ek__BackingField;

	public uint id
	{
		get
		{
			return _003Cid_003Ek__BackingField;
		}
		private set
		{
			_003Cid_003Ek__BackingField = value;
		}
	}

	public uint quality
	{
		get
		{
			return _003Cquality_003Ek__BackingField;
		}
		private set
		{
			_003Cquality_003Ek__BackingField = value;
		}
	}

	public uint title_loc_key
	{
		get
		{
			return _003Ctitle_loc_key_003Ek__BackingField;
		}
		private set
		{
			_003Ctitle_loc_key_003Ek__BackingField = value;
		}
	}

	public uint desc_loc_key
	{
		get
		{
			return _003Cdesc_loc_key_003Ek__BackingField;
		}
		private set
		{
			_003Cdesc_loc_key_003Ek__BackingField = value;
		}
	}

	public uint wishValue
	{
		get
		{
			return _003CwishValue_003Ek__BackingField;
		}
		private set
		{
			_003CwishValue_003Ek__BackingField = value;
		}
	}

	public uint purchaseValue
	{
		get
		{
			return _003CpurchaseValue_003Ek__BackingField;
		}
		private set
		{
			_003CpurchaseValue_003Ek__BackingField = value;
		}
	}

	public uint purchaseLimit
	{
		get
		{
			return _003CpurchaseLimit_003Ek__BackingField;
		}
		private set
		{
			_003CpurchaseLimit_003Ek__BackingField = value;
		}
	}

	public CustomCardInfo.WishState state
	{
		get
		{
			return _003Cstate_003Ek__BackingField;
		}
		private set
		{
			_003Cstate_003Ek__BackingField = value;
		}
	}

	public uint amount
	{
		get
		{
			return _003Camount_003Ek__BackingField;
		}
		private set
		{
			_003Camount_003Ek__BackingField = value;
		}
	}

	public uint inventoryAmount
	{
		get
		{
			return _003CinventoryAmount_003Ek__BackingField;
		}
		private set
		{
			_003CinventoryAmount_003Ek__BackingField = value;
		}
	}

	public CustomCDNItemInfo ToBaseItemInfo(uint number = 0u)
	{
		return null;
	}

	public static CustomCDNItemInfo CopyToItem(AwardDesc awardItem)
	{
		return null;
	}

	public static implicit operator CustomCard_CardData(CustomCardInfoDesc item)
	{
		return null;
	}

	public void Remove(uint number = 1u)
	{
	}

	public void Add(uint number = 1u)
	{
	}

	public void SetCurrentAmount(uint number)
	{
	}

	public void SetInventoryAmount(uint number)
	{
	}

	public int ForceSetWishState(CustomCardInfo.WishState result)
	{
		return 0;
	}

	public int SetWishScuess()
	{
		return 0;
	}

	public int CancelWishScuess()
	{
		return 0;
	}

	public int ReceiveCardScuess()
	{
		return 0;
	}

	public int ReceiveCardNotify()
	{
		return 0;
	}

	public uint GetCdnUrl(CardCNDType cnd_type, bool unlock = true)
	{
		return 0u;
	}
}
