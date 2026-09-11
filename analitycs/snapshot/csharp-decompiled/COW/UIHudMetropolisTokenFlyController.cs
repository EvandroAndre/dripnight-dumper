using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisTokenFlyController : UIBaseController
{
	private UIHudMetropolisTokenFlyView m_View;

	private Queue<UIHudMetropolisTokenFly> m_FlyObjectPool;

	private List<UIHudMetropolisTokenFly> m_AllFlyObj;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void PlayFly(Vector3 startPos, Vector3 endPos)
	{
	}

	public void OnFlyObjEnd(UIHudMetropolisTokenFly flyObj)
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
