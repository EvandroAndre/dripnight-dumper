using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHDWeaponRack : MonoBehaviour, IUIModelDataChangeObserver
{
	private const string MODELROOTNAME = "HomeRoom_WeaponAll";

	private Transform m_LogicRoot;

	private GameObject m_ModelRoot;

	private Transform[] m_WeaponSlot;

	private GameObject[] m_WeaponOnSlotVFX;

	private GameObject[] m_WeaponEquipedVFX;

	private GameObject m_WeaponRackCollider;

	private Transform m_LogicBind;

	private Animator m_Animator;

	private Transform[] m_Weapons;

	private bool[] m_WeaponNeedRefresh;

	private uint[] m_NeedEquipWeaponSkinIds;

	private HashSet<uint> m_HDWeaponHideScabbardIDs;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void StartPlay()
	{
	}

	private void OnWeaponShowInGunDoor(object[] data)
	{
	}

	private void OnSwitchWeapons(object[] data)
	{
	}

	public void OnWeaponInit(object[] data)
	{
	}

	private void OnRemoveSlotWeapon(object[] data)
	{
	}

	private void OnDeleteSlotWeapon(int slot)
	{
	}

	public void SetSlotWeapon(int slot, WeaponSkinData skin)
	{
	}

	private Transform FindTransformInChildren(Transform root, string name)
	{
		return null;
	}

	private void OnWeaponOnSlot(object[] data)
	{
	}

	private void OnWeaponLeaveSlot(object[] data)
	{
	}

	public void ClearWeaponVFX()
	{
	}

	private bool IsWeaponOnRack()
	{
		return false;
	}

	public void EquipDefaultWeapon()
	{
	}

	public void CleanWeaponRack()
	{
	}

	public void DeEquipDefaultWeapon()
	{
	}

	public void SetWeaponRackClickState(bool flag)
	{
	}

	private void ChangeLayer(Transform trans, string layerName)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnApplicationPause(bool pauseState)
	{
	}
}
