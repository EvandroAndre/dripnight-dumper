using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDAirTransporterNameController : UIHudNameBaseController
{
	private UIHUDAirTransporterNameView m_View;

	private Camera m_FollowCamera;

	private new FollowCamera m_FollowCameraComponent;

	private Camera m_UICamera;

	private AirTransporter m_AirTransporter;

	private GameObject[] m_GameObjects;

	private UISprite[] m_Sprites;

	private float viewPortBoundary;

	private int m_CurShow;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnRoomOBIsCamTypeFree(bool isFree)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void LateUpdate()
	{
	}

	protected void Refresh()
	{
	}

	private void RefreshRoomOBColor(BHGGAEEHJCO playerId)
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}
}
