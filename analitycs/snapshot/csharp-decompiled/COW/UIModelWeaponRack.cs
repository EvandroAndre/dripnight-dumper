using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelWeaponRack : UIBaseModel
{
	public List<uint> EquipedWeapponIds;

	public List<uint> LastEquipedWeaponIds;

	public const uint PropID_Add_Success = 2u;

	public const uint PropID_Del_Success = 4u;

	public const int SLOTCOUNT = 3;

	public const string HDWEAPONRACKGUIDE = "HDWEAPONRACKGUIDE_";

	private bool _003CGetDataAfterLogin_003Ek__BackingField;

	public bool GetDataAfterLogin
	{
		get
		{
			return _003CGetDataAfterLogin_003Ek__BackingField;
		}
		private set
		{
			_003CGetDataAfterLogin_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void AddWeapon(uint slot, uint weapon_id)
	{
	}

	public void DelWeapon(uint slot, uint weapon_id)
	{
	}

	public void ProcessDesc(WeaponRackRes res)
	{
	}

	public void RequestUpdateWeaponList()
	{
	}

	public bool HasWeaponEquipped()
	{
		return false;
	}

	public void RefreshDataAfterUpdateWeaponSkin(uint lastID, uint currentID)
	{
	}

	private void _003CRequestUpdateWeaponList_003Eb__15_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
