using COW.Gameplay.UGC;
using message;

namespace COW;

public class UIHUDUGC_ButtonWidgetController : UIHUDUGC_WidgetBaseController
{
	private UGCHudButtonWidgetRepItem m_ButtonWidgetCmpt;

	private UGCHudButton m_Button;

	private UIEventTrigger m_Trigger;

	private EventDelegate m_OnPressButton;

	private EventDelegate m_OnReleaseButton;

	private EventDelegate m_OnDoubleClickButton;

	private EventDelegate m_OnDragOutButton;

	private bool m_Pressed;

	private bool m_VirtualPressed;

	private bool m_CustomActionBind;

	private object[] m_OnEventArgs;

	protected override void InitEntityData()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void InitWidget()
	{
	}

	private void RegisterVirtualButton()
	{
	}

	private void OnPress()
	{
	}

	private void OnRelease()
	{
	}

	private void OnUniqueIDChanged(string cur)
	{
	}

	protected override void RefreshWidgetInfo()
	{
	}

	private void OnButtonIsFEButtonChanged(bool cur)
	{
	}

	private void OnButtonSpriteTypeChanged(int cur)
	{
	}

	private void OnButtonDisableColorChanged(int cur)
	{
	}

	private void OnButtonPressedColorChanged(int cur)
	{
	}

	private void OnSpriteNameChanged(string cur)
	{
	}

	public void OnClickButton()
	{
	}

	public void OnPressButton()
	{
	}

	public void OnReleaseButton()
	{
	}

	public void OnDoubleClickButton()
	{
	}

	public void OnDragOutButton()
	{
	}

	protected override void OnAlphaChanged(float cur)
	{
	}

	private void OnButtonColorChanged(int cur)
	{
	}

	private void OnFlipTypeChanged(int cur)
	{
	}

	private void OnCenterInvisibleChanged(bool cur)
	{
	}

	private void OnFillDirChanged(int cur)
	{
	}

	private void OnFillAmountChanged(float cur)
	{
	}

	private void OnInvertFillChanged(bool cur)
	{
	}

	private void OnGradientChanged(int cur)
	{
	}

	private void OnGradientTopChanged(int cur)
	{
	}

	private void OnGradientBottomChanged(int cur)
	{
	}

	private void OnGradientTopAlphaChanged(float cur)
	{
	}

	private void OnGradientBottomAlphaChanged(float cur)
	{
	}

	private void OnDisableColliderChanged(bool cur)
	{
	}

	public override void RefreshAlpha()
	{
	}

	private bool _003CRegisterVirtualButton_003Eb__14_0(CABGLPMHIOJ e)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_InitEntityData()
	{
	}

	public void _003C_003EiFixBaseProxy_InitWidget()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshWidgetInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAlphaChanged(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshAlpha()
	{
	}
}
