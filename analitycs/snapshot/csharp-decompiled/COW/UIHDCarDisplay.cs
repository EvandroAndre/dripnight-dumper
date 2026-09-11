using GCommon;
using UnityEngine;

namespace COW;

public class UIHDCarDisplay : MonoBehaviour, IUIModelDataChangeObserver
{
	private const string MODELROOTNAME = "HomeRoom_Mobile_Platform_Dummy";

	private const string VEHICLEOOTNAME = "HomeRoom_Mobile_Platform_Dummy01";

	private Transform m_LogicRoot;

	private GameObject m_ModelRoot;

	private GameObject m_VehicleEquipedVFX;

	private GameObject m_VehicleCollider;

	private Transform m_LogicBind;

	private Transform m_VehicleBind;

	private Animator m_Animator;

	private Transform m_VehicleTrans;

	private uint m_CurrentVehicleSkinID;

	private uint m_NeedEquipVehicleSkinID;

	private float m_CurrentVehicleRotate;

	private const string HDVEHICLEDISPLAYANGLE = "HDVEHICLEDISPLAYANGLE_";

	private bool m_VehicleAbReady;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void StartPlay()
	{
	}

	public void OnVehicleInit(object[] data)
	{
	}

	public void ShowVehicleSkinOrDefault(uint vehicleSkinId, bool needSFX = false, bool useSavedRotate = false)
	{
	}

	public void EquipDefaultVehicle()
	{
	}

	public void EquipVehicleSkin(VehicleSkinData info, bool needSFX = false)
	{
	}

	public void DeEquipVehicleSkin()
	{
	}

	private void RemoveVehicle(object[] data)
	{
	}

	private void ChangeVehicle(object[] data)
	{
	}

	private float GetVehicleRotate()
	{
		return 0f;
	}

	private void RefreshVehicleSkin()
	{
	}

	public void SetVehicleRotate()
	{
	}

	private void InitDisplayObjectInputHandler()
	{
	}

	public void SetCarDisplayClickState(bool flag)
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
}
