using GCommon;

namespace COW;

internal class UIHudGrenadeSubBtnController : UIBaseController
{
	private UIHudGrenadeSubBtnView m_View;

	private UIHudGrenadeBtnController.ButtonType m_BtnType;

	private int m_Count;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnClick()
	{
	}

	public void SetData(UIHudGrenadeBtnController.ButtonType curType, int count, int itemType)
	{
	}

	private void RefreshCountLabel(UIHudGrenadeBtnController.ButtonType btnType, int count)
	{
	}

	private void RefreshInfinityIcon()
	{
	}

	protected void OnStartInfiniteIceWall(GEvent data)
	{
	}

	private void Update()
	{
	}

	private void UpdateDisableUseState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
