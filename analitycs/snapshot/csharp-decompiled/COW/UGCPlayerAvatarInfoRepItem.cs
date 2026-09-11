using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPlayerAvatarInfoRepItem
{
	public const int PROP_ID_OWNER = -269000;

	public const int PROP_ID_CUSTOMCLOTHSETID = -269001;

	public const int PROP_ID_CUSTOMCLOTHHAIRID = -269002;

	public const int PROP_ID_CUSTOMCLOTHHEADADDITIVEID = -269003;

	public const int PROP_ID_CUSTOMCLOTHFACEID = -269004;

	public const int PROP_ID_CUSTOMCLOTHCHESTID = -269005;

	public const int PROP_ID_CUSTOMCLOTHLEGSID = -269006;

	public const int PROP_ID_CUSTOMCLOTHFEETID = -269007;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnOwnerChangeEvent;

	public Action<int> OnCustomClothSetIDChangeEvent;

	public Action<int> OnCustomClothHairIDChangeEvent;

	public Action<int> OnCustomClothHeadAdditiveIDChangeEvent;

	public Action<int> OnCustomClothFaceIDChangeEvent;

	public Action<int> OnCustomClothChestIDChangeEvent;

	public Action<int> OnCustomClothLegsIDChangeEvent;

	public Action<int> OnCustomClothFeetIDChangeEvent;

	private string _003COwner_003Ek__BackingField;

	private int _003CCustomClothSetID_003Ek__BackingField;

	private int _003CCustomClothHairID_003Ek__BackingField;

	private int _003CCustomClothHeadAdditiveID_003Ek__BackingField;

	private int _003CCustomClothFaceID_003Ek__BackingField;

	private int _003CCustomClothChestID_003Ek__BackingField;

	private int _003CCustomClothLegsID_003Ek__BackingField;

	private int _003CCustomClothFeetID_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Owner
	{
		get
		{
			return _003COwner_003Ek__BackingField;
		}
		private set
		{
			_003COwner_003Ek__BackingField = value;
		}
	}

	public int CustomClothSetID
	{
		get
		{
			return _003CCustomClothSetID_003Ek__BackingField;
		}
		private set
		{
			_003CCustomClothSetID_003Ek__BackingField = value;
		}
	}

	public int CustomClothHairID
	{
		get
		{
			return _003CCustomClothHairID_003Ek__BackingField;
		}
		private set
		{
			_003CCustomClothHairID_003Ek__BackingField = value;
		}
	}

	public int CustomClothHeadAdditiveID
	{
		get
		{
			return _003CCustomClothHeadAdditiveID_003Ek__BackingField;
		}
		private set
		{
			_003CCustomClothHeadAdditiveID_003Ek__BackingField = value;
		}
	}

	public int CustomClothFaceID
	{
		get
		{
			return _003CCustomClothFaceID_003Ek__BackingField;
		}
		private set
		{
			_003CCustomClothFaceID_003Ek__BackingField = value;
		}
	}

	public int CustomClothChestID
	{
		get
		{
			return _003CCustomClothChestID_003Ek__BackingField;
		}
		private set
		{
			_003CCustomClothChestID_003Ek__BackingField = value;
		}
	}

	public int CustomClothLegsID
	{
		get
		{
			return _003CCustomClothLegsID_003Ek__BackingField;
		}
		private set
		{
			_003CCustomClothLegsID_003Ek__BackingField = value;
		}
	}

	public int CustomClothFeetID
	{
		get
		{
			return _003CCustomClothFeetID_003Ek__BackingField;
		}
		private set
		{
			_003CCustomClothFeetID_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCPlayerAvatarInfoRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
