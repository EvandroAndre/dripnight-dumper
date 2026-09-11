using GCommon;
using UnityEngine;

namespace COW;

public class UIHDSkyboardDisplay : MonoBehaviour, IUIModelDataChangeObserver
{
	private Transform m_SkyboardRoot;

	private GameObject m_SkyboardCollider;

	private GameObject m_SkyboardEquipedVFX;

	private Transform m_SkyboardTrans;

	private uint m_currentSkyboardDelaycall;

	private uint m_CurrentSkyboardSkinID;

	private uint m_NeedEquipSkyboardSkinID;

	private float m_CurrentSkyboardRotate;

	private bool m_SkyBoardAbReady;

	private const string HDSKYBOARDDISPLAYANGLE = "HDSKYBOARDDISPLAYANGLE_";

	private static uint NoneSkyboardSkinID;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnSkyboardInit(object[] data)
	{
	}

	public void EquipSkyboardSkin(SkyboardData skyboardInfo, bool needSFX = false)
	{
	}

	public void EquipDefaultSkyboard()
	{
	}

	public void DeEquipSkyboardSkin()
	{
	}

	private void RemoveSkyboard(object[] data)
	{
	}

	private void ChangeSkyboard(object[] data)
	{
	}

	private float GetSkyboardRotate()
	{
		return 0f;
	}

	private void RefreshSkyBoard()
	{
	}

	private void InitDisplayObjectInputHandler()
	{
	}

	public void SetSkyboardRotate()
	{
	}

	public void SetSkyboardDisplayClickState(bool flag)
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

	private void _003CEquipSkyboardSkin_003Eb__14_0()
	{
	}
}
