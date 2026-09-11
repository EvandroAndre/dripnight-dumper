using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHGTokenFlyController : UIBaseController
{
	private UIHudHGTokenFlyView m_View;

	private Queue<TweenPositionArc> m_FlyObjectPool;

	private List<TweenPositionArc> m_AllFlyObj;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void PlayFly(Vector3 endPos, float flySpeed = 1f)
	{
	}

	private void OnFlyObjEnd(TweenPositionArc flyObj)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
