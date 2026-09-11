using GCommon;

namespace COW;

public class UIUGCStandardSubTabItemController : UIUGCStandardTabBaseItemController
{
	private UIUGCStandardSubTabItemView m_View;

	public const string CLICK_ANIM_NAME = "UIStandardTabItemRemake_Click";

	public const string ENTER_ANIM_NAME = "UIFX_UGC_SubTab_Open";

	public const string DISAPPEAR_ANIM_NAME = "UIFX_UGC_SubTab_Close";

	private bool m_NeedToPlayAnim;

	private uint m_AfterAnimDelayCall;

	private int m_WidgetHeight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override int WidgetHeight()
	{
		return 0;
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UGCStandardTabItemViewData data)
	{
	}

	public void OnBtnClick()
	{
	}

	protected void PlayTabItemClickAnimation()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	public override void Disappear()
	{
	}

	public override void Appear()
	{
	}

	public override void OnSelected()
	{
	}

	public override void OnUnSelected()
	{
	}

	private void _003CSetViewData_003Eb__10_0()
	{
	}

	private void _003CDisappear_003Eb__15_0()
	{
	}

	public int _003C_003EiFixBaseProxy_WidgetHeight()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Disappear()
	{
	}

	public void _003C_003EiFixBaseProxy_Appear()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSelected()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUnSelected()
	{
	}
}
