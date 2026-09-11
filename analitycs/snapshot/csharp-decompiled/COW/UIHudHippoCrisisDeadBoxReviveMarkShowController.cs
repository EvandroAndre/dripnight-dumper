using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisDeadBoxReviveMarkShowController : UIHudNameBaseController
{
	private static float Y_OFFSET;

	private UIHudHippoCrisisDeadBoxReviveMarkShowView m_View;

	private IOENNEBCHBF m_DeadBox;

	private uint m_PlayerId;

	private uint m_DelayHideCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected override Vector4 GetWidgetDirOffset()
	{
		return default(Vector4);
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	public void SetBindDeadBox(IOENNEBCHBF deadBox)
	{
	}

	private void OnPlayerRequestRevive(object[] data)
	{
	}

	private void HideRequestReviveEffect()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}

	public Vector4 _003C_003EiFixBaseProxy_GetWidgetDirOffset()
	{
		return default(Vector4);
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}
}
