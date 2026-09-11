using COW.Gameplay.UGC;
using UnityEngine;

namespace COW;

public class UIHUDUGC_JoystickController : UIHUDUGC_WidgetBaseController
{
	private UGCHudJoystickRepItem m_JoystickCmpt;

	private UGCHudJoystick m_Joystick;

	protected override void InitEntityData()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void DestroyEntity()
	{
	}

	public override void BindWidget(UGCHudWidget widget)
	{
	}

	protected override void InitWidget()
	{
	}

	protected override void RefreshWidgetInfo()
	{
	}

	private void OnOffsetChanged(Vector2 cur)
	{
	}

	private void OnBackGroundImageChanged(string cur)
	{
	}

	private void OnBackGroundRadiusChanged(int cur)
	{
	}

	private void OnJoystickCapImageChanged(string cur)
	{
	}

	private void OnJoystickCapRadiusChanged(int cur)
	{
	}

	private void OnJoystickCapDragRadiusChanged(int cur)
	{
	}

	private void OnArrowImageChanged(string cur)
	{
	}

	private void OnArrowSizeChanged(Vector2 cur)
	{
	}

	private void OnArrowOffsetChanged(int cur)
	{
	}

	private void OnActivatedAlphaChanged(float cur)
	{
	}

	private void OnInactivatedAlphaChanged(float cur)
	{
	}

	private void OnDisableColliderChanged(bool cur)
	{
	}

	public override void RefreshAlpha()
	{
	}

	public void _003C_003EiFixBaseProxy_InitEntityData()
	{
	}

	public new void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_BindWidget(UGCHudWidget P0)
	{
	}

	public void _003C_003EiFixBaseProxy_InitWidget()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshWidgetInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshAlpha()
	{
	}
}
