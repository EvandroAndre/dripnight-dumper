using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudRevivePointActionBtnController : UIBaseController
{
	private UIHudRevivePointActionBtnView m_View;

	private BitArrayBoolean m_Visible;

	private const uint ISVISIBLE_INREVIVEPOINT = 1u;

	private const uint ISVISIBLE_SHOWACTION = 2u;

	private int reviveCardItemId;

	private BGMFPPDLCBB m_ReviveCardItem;

	private int m_TokenCount;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void OnClickBtn()
	{
	}

	public void OnActionBtnVisibleChange(bool visible)
	{
	}

	private void OnEnterRevivePointBuffShop(bool isEnter)
	{
	}

	private void SetBtnVisibility(uint flag, bool visible)
	{
	}

	private void RefreshVFX()
	{
	}

	private void RefreshItemData()
	{
	}

	private void OnTokenChanged(int data)
	{
	}

	private void _003COnUIInit_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
