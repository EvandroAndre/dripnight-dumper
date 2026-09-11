using GCommon;
using UnityEngine;

namespace COW;

public class UIHDIceWallDisplay : MonoBehaviour, IUIModelDataChangeObserver
{
	private const string MODELROOTNAME = "HomeRoom_Rotating_Table";

	public Transform m_LogicRoot;

	public GameObject m_ModelRoot;

	private Transform m_IceWallRoot;

	private GameObject m_IceWallCollider;

	private GameObject m_IceWallEquipedVFX;

	private Transform m_IceTrans;

	private uint m_currenticedalaycall;

	private uint m_CurrentIceWallSkinID;

	private uint m_NeedEquipIceWallSkinID;

	private float m_CurrentIceWallRotate;

	private const string HDIceWallDISPLAYANGLE = "HDIceWallDISPLAYANGLE_";

	private bool m_IceWallAbReady;

	private PrimePrivilegeIceWallUI m_PrimeIceWallUI;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnIceWallInit(object[] data)
	{
	}

	public void EquipIceWallSkin(WeaponSkinData info, bool needSFX = false)
	{
	}

	private void TryAddPrimeSpriteToPrimePrivilege(GameObject go)
	{
	}

	private void RefreshPrimeIconForIceWall()
	{
	}

	public void DeEquipIceWallSkin()
	{
	}

	private void RemoveIceWall(object[] data)
	{
	}

	private void ChangeIceWall(object[] data)
	{
	}

	public void EquipDefaultIceWall()
	{
	}

	private float GetIceWallRotate()
	{
		return 0f;
	}

	private void RefreshIceWall()
	{
	}

	private void InitDisplayObjectInputHandler()
	{
	}

	public void SetIceWallRotate()
	{
	}

	public void SetIceWallDisplayClickState(bool flag)
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

	private void _003CEquipIceWallSkin_003Eb__17_0()
	{
	}
}
