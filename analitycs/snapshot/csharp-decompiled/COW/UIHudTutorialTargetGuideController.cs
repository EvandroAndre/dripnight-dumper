using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTutorialTargetGuideController : UIBaseController
{
	private readonly Color TARGETCOLOR;

	private readonly int TARGETOFFSET;

	private UIHudTutorialTargetGuideView m_View;

	private Camera m_FollowCamera;

	private FollowCamera m_FollowCameraComponent;

	private Camera m_UICamera;

	private UIForceTutorialGameScene m_InGameScene;

	private int m_PrevDistance;

	private StringBuilder m_Distance;

	private BHGGAEEHJCO m_BindPlayer;

	private Vector3 m_BindTargetPos;

	private bool m_IsTargetPlayer;

	private bool m_IsActivated;

	private float m_ViewPortBoundary;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitCamera()
	{
	}

	private void LateUpdate()
	{
	}

	private Vector3 GetPosFromPlayer()
	{
		return default(Vector3);
	}

	private void UpdateTargetPosition(Vector3 namePos)
	{
	}

	private void SetDistance(int distance)
	{
	}

	public void BindPlayer(BHGGAEEHJCO pID, bool isEnemy = true)
	{
	}

	public void UnbindPlayer()
	{
	}

	public void BindPos(Vector3 pos)
	{
	}

	public void UnbindPos()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
