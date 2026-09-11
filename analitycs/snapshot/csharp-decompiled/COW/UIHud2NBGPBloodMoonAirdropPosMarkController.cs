using GCommon;
using UnityEngine;

namespace COW;

public class UIHud2NBGPBloodMoonAirdropPosMarkController : UIHudNameBaseController
{
	private UIHud2NBGPBloodMoonAirdropPosMarkView m_View;

	private uint m_TargetAirdropObjectID;

	private Vector3 m_TargetWorldPosition;

	private Vector2 m_RelativeWidgetBoundsSize;

	private bool _003CIsTracking_003Ek__BackingField;

	public bool IsTracking
	{
		get
		{
			return _003CIsTracking_003Ek__BackingField;
		}
		private set
		{
			_003CIsTracking_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	private void OnObserverChanged(object[] data)
	{
	}

	private void OnLocalPlayerDead(object[] data)
	{
	}

	private void RegisterEvents()
	{
	}

	private void UpdateTrackingState(bool tracking)
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetupWidgetBounds()
	{
	}

	public void TrackTarget(uint airdropObjectID, Vector3 worldPosition)
	{
	}

	public void RestorePropertiesBeforeRecycled()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}
}
