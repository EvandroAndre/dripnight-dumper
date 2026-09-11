using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudBombZoneMarkController : UIHudNameBaseController
{
	private UIHudBombZoneMarkView m_View;

	private SafeZone.CLGEFLMMOJJ m_BombZoneInfo;

	private Color bombColor;

	public SafeZone.CLGEFLMMOJJ BombZoneInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override bool NeedShowDistance()
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

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	private void OnBombRoundChange(object[] data)
	{
	}

	private void OnEnterBombArea(object[] data)
	{
	}

	private void OnBombSettled(object[] data)
	{
	}

	private void OnBombRemoved(object[] data)
	{
	}

	private void SetBombArrowStatus(bool hasBomb)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
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

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}
}
