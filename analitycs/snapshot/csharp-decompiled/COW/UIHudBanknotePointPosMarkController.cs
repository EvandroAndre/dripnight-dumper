using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBanknotePointPosMarkController : UIHudNameBaseController
{
	private UIHudBanknotePointPosMarkView m_View;

	private Vector3 m_ControlPointPos;

	private uint m_CurrentPointID;

	private UIModelMatch m_ModelMatch;

	private const int NO_OCCUPY_COLOR = 2130706517;

	private const int LOCAL_OCCUPY_COLOR = 2131790519;

	private const int OPP_OCCUPY_COLOR = 2145343516;

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

	protected override bool NeedShowDistance()
	{
		return false;
	}

	private void OnOccupateTeamChange(object[] data)
	{
	}

	private void OnRestAmountChange(object[] data)
	{
	}

	private void OnControlPointChange(object[] data)
	{
	}

	private void ClearHudShow()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
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

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}
}
