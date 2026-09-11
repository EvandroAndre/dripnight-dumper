using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudMetropolisHPController : UIHudNameBaseController
{
	private UIHudMetropolisHPView m_View;

	private BHGGAEEHJCO m_BindPlayerID;

	public float Counter;

	private Player m_BindPlayer;

	private List<UIHudMetropolisFactionStar> m_StarList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	private void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	public void UnbindPlayer()
	{
	}

	public void OnHpChanged(BHGGAEEHJCO id, int oldHP, int curHP, int maxHP)
	{
	}

	private void Update()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}
}
