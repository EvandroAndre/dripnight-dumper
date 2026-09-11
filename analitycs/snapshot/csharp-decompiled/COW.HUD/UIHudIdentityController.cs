using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

public class UIHudIdentityController : UIHudNameBaseController, IHudNameController
{
	private UIHudIdentityView m_View;

	private BHGGAEEHJCO m_BindPlayer;

	private int m_EndServerTime;

	private int m_Identity;

	public bool IsUsing;

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

	private Vector3 GetRefPos(Player p)
	{
		return default(Vector3);
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	public void UnbindPlayer()
	{
	}

	protected override void OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE OutType)
	{
	}

	private void SetViewData(int identity)
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

	public void _003C_003EiFixBaseProxy_OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE P0)
	{
	}
}
