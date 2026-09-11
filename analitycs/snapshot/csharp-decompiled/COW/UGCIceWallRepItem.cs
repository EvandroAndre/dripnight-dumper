using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCIceWallRepItem
{
	public const int PROP_ID_MAXHP = -235000;

	public const int PROP_ID_LIFETIME = -235001;

	public const int PROP_ID_MAXCOUNT = -235002;

	public const int PROP_ID_ASSETCONFIGID = -235003;

	public const int PROP_ID_OVERLOADBYPLAYERWEAPONSKIN = -235004;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnAssetConfigIDChangeEvent;

	public Action<bool> OnOverloadByPlayerWeaponSkinChangeEvent;

	private int _003CAssetConfigID_003Ek__BackingField;

	private bool _003COverloadByPlayerWeaponSkin_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int AssetConfigID
	{
		get
		{
			return _003CAssetConfigID_003Ek__BackingField;
		}
		private set
		{
			_003CAssetConfigID_003Ek__BackingField = value;
		}
	}

	public bool OverloadByPlayerWeaponSkin
	{
		get
		{
			return _003COverloadByPlayerWeaponSkin_003Ek__BackingField;
		}
		private set
		{
			_003COverloadByPlayerWeaponSkin_003Ek__BackingField = value;
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

	public UGCIceWallRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
