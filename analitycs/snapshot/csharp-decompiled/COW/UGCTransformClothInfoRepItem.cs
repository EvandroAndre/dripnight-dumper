using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTransformClothInfoRepItem
{
	public const int PROP_ID_CURWEAPONSKINID = -428000;

	public const int PROP_ID_BAGSKINID = -428001;

	public const int PROP_ID_CUSTOMCLOTHSETID = -428002;

	public const int PROP_ID_CUSTOMCLOTHHAIRID = -428003;

	public const int PROP_ID_CUSTOMCLOTHHEADADDITIVEID = -428004;

	public const int PROP_ID_CUSTOMCLOTHFACEID = -428005;

	public const int PROP_ID_CUSTOMCLOTHCHESTID = -428006;

	public const int PROP_ID_CUSTOMCLOTHLEGSID = -428007;

	public const int PROP_ID_CUSTOMCLOTHFEETID = -428008;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnCurWeaponSkinIDChangeEvent;

	public Action<int> OnBagSkinIDChangeEvent;

	public Action<int> OnCustomClothSetIDChangeEvent;

	public Action<int> OnCustomClothHairIDChangeEvent;

	public Action<int> OnCustomClothHeadAdditiveIDChangeEvent;

	public Action<int> OnCustomClothFaceIDChangeEvent;

	public Action<int> OnCustomClothChestIDChangeEvent;

	public Action<int> OnCustomClothLegsIDChangeEvent;

	public Action<int> OnCustomClothFeetIDChangeEvent;

	private int _003CCurWeaponSkinID_003Ek__BackingField;

	private int _003CBagSkinID_003Ek__BackingField;

	private int _003CCustomClothSetID_003Ek__BackingField;

	private int _003CCustomClothHairID_003Ek__BackingField;

	private int _003CCustomClothHeadAdditiveID_003Ek__BackingField;

	private int _003CCustomClothFaceID_003Ek__BackingField;

	private int _003CCustomClothChestID_003Ek__BackingField;

	private int _003CCustomClothLegsID_003Ek__BackingField;

	private int _003CCustomClothFeetID_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int CurWeaponSkinID
	{
		get
		{
			return _003CCurWeaponSkinID_003Ek__BackingField;
		}
		private set
		{
			_003CCurWeaponSkinID_003Ek__BackingField = value;
		}
	}

	public int BagSkinID
	{
		get
		{
			return _003CBagSkinID_003Ek__BackingField;
		}
		private set
		{
			_003CBagSkinID_003Ek__BackingField = value;
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

	public UGCTransformClothInfoRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
