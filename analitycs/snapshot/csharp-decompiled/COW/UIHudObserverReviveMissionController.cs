using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudObserverReviveMissionController : UIBaseController
{
	private UIHudObserverReviveMissionView m_View;

	private IPLIFLLGADH m_ReviveMission;

	private float m_TickCount;

	private Queue<TweenPositionArcWithScaleAndAlpha> m_FlyObjectPool;

	private List<TweenPositionArcWithScaleAndAlpha> m_AllFlyObj;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private void OnReviveMissionEnd(object[] data)
	{
	}

	private void OnReviveMissionBtnClick(GameObject go, bool pressed)
	{
	}

	public void SetViewData(IPLIFLLGADH mission)
	{
	}

	private UIHudInventoryTagController OpenInventoryTagFromPool(Transform transform)
	{
		return null;
	}

	public void PlayFly(float flySpeed)
	{
	}

	private void OnFlyObjEnd(TweenPositionArcWithScaleAndAlpha flyObj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
