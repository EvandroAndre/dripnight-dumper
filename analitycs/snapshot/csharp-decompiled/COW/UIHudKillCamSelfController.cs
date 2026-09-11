using COW.GamePlay;
using COW.HUD;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudKillCamSelfController : UIHudNameBaseController, IHudNameController
{
	private UIHudKillCamSelfView m_View;

	private BHGGAEEHJCO m_BindPlayer;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	public void UnbindPlayer()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}
}
