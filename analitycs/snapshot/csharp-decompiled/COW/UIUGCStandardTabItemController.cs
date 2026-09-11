using GCommon;

namespace COW;

public class UIUGCStandardTabItemController : UIUGCStandardTabBaseItemController
{
	private UIUGCStandardTabItemView m_View;

	public const string CLICK_ANIM_NAME = "UIStandardTabItemRemake_Click";

	public const string ENTER_ANIM_NAME = "UIStandardTabItemRemake_In";

	private bool m_NeedToPlayAnim;

	private int OriHeight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(object data)
	{
	}

	public override void RefreshSize()
	{
	}

	protected void PlayTabItemClickAnimation()
	{
	}

	private void Update()
	{
	}

	public void OnBtnClick()
	{
	}

	public override void OnSelected()
	{
	}

	public override void OnUnSelected()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void _003CSetViewData_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshSize()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSelected()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUnSelected()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
