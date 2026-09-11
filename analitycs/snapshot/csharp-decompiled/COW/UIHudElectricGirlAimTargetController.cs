using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudElectricGirlAimTargetController : UIBaseController
{
	private UIHudElectricGirlAimTargetView m_View;

	private Camera m_GameCamera;

	private Transform m_GameCameraTrans;

	private Transform CachedTransform;

	private GMPGMPFNMFP m_HitObjectInfoCache;

	private bool? m_LastCanFind;

	private bool? m_LastNeedFind;

	private uint m_AimedPlayerId;

	private Queue<BHGGAEEHJCO> m_NeedCheckPlayerQueue;

	private BHGGAEEHJCO m_NearestPlayerId;

	private Vector3 m_NearestPlayerScreenPos;

	private float m_NearestPlayerDisSqr;

	private float m_CfgPlayerMaxDisSqr;

	private CBLDEJMDIFE m_ElectricGirlSkill;

	private bool m_CalNearestPlayerInScreenFrameInterval;

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

	public override void Hide()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetData(CBLDEJMDIFE skill)
	{
	}

	private void LateUpdate()
	{
	}

	private void FindPlayerToShowUI()
	{
	}

	private void FindNearestTeammateInScreen()
	{
	}

	private Vector2? GetPlayerPosInUI(BHGGAEEHJCO playerId, bool checkDisAndObstacle)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
