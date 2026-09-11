using GCommon;

namespace COW;

public class UIFlashStoreGmesShortagePopWndController : UIPopupWindowController
{
	private const string NAME = "ShortagePopWnd";

	protected const string FLASH_GEMS_ICON = "FF_UI_FlashStore_PurpleDiamond";

	protected const string GEMS_ICON = "FF_UI_FlashStore_Diamond";

	protected UIFlashStoreShortagePopWndView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void InitViewData()
	{
	}

	public void ShowFlashGemsAndGemsInsufficientData(uint flashGemsShortageCnt = 0u, uint gemsShortageCnt = 0u)
	{
	}

	public void ShowFlashGemsInsufficientData(uint shortageCnt = 0u)
	{
	}

	public void ShowGemsInsufficientData(uint shortageCnt = 0u)
	{
	}

	private void OnGemsObtainBtnClick()
	{
	}

	private void OnPeriodicGemsObtainBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
