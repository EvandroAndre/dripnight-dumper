using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

public class UIHudRevengeInfoPointController : UIHudNameBaseController
{
	private UIHudRevengeInfoPointView m_View;

	private BHGGAEEHJCO m_BindPlayer;

	private bool _003CNeedUpdate_003Ek__BackingField;

	public bool NeedUpdate
	{
		get
		{
			return _003CNeedUpdate_003Ek__BackingField;
		}
		set
		{
			_003CNeedUpdate_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindEnermy(BHGGAEEHJCO pID)
	{
	}

	public void UnBindEnermy()
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

	private Vector3 GetRefPos(Player p)
	{
		return default(Vector3);
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
}
