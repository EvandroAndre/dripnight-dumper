using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPDMRankController : UIBaseController
{
	private UIHudPDMRankView m_View;

	private UIHudPDMRankItemController m_SelfController;

	private Dictionary<BHGGAEEHJCO, UIHudPDMRankItemController> m_DicControllers;

	private int m_CurrentRank;

	private int m_LastRank;

	private bool m_IsAnimPlaying;

	private bool m_NeedRefresh;

	private bool m_IsAnimUp;

	private bool m_IsSecondAnim;

	private bool m_IsSelfInAnim;

	private TweenPosition m_SelfTweenPosition;

	private Vector3 m_AnimTarget;

	private Vector3 m_AnimVelocity;

	private Action m_AnimAction;

	private Action m_Anim2Action;

	private float m_WaitTime;

	private Queue<BHGGAEEHJCO> m_AddPlayerQueue;

	private Vector3 m_ShadowScale;

	private const int WaitFrame = 2;

	private int m_WaitFrame;

	private List<Transform> cachedTransforms;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void OnAddPlayer(GEvent param)
	{
	}

	private void SetPlayerInfo(BHGGAEEHJCO pId)
	{
	}

	private void OnCommonPlayerStatsChanged(object[] param)
	{
	}

	private void RefreshView(bool needAnim = false)
	{
	}

	private void OnSelfChanged()
	{
	}

	private void OnAnimEnd()
	{
	}

	private void PlayRankAnim()
	{
	}

	private void PlayTweenPosition(Vector3 to, float duration, EventDelegate.Callback end)
	{
	}

	private void OnTotalAnimFinished()
	{
	}

	private void OnMiddleAnimFunc()
	{
	}

	private void RefreshRank(bool dataChanged = false)
	{
	}

	private int ItemCompareWithPlayerID(Transform item1, Transform item2)
	{
		return 0;
	}

	private Vector3 CalculateMiddlePosition()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
