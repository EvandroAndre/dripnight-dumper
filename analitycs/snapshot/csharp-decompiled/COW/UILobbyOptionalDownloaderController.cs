using GCommon;

namespace COW;

public class UILobbyOptionalDownloaderController : UIBaseController, IUIModelDataChangeObserver
{
	private const float CIRCLE_SPEED = 0.2f;

	private UIModelOptionalDownload m_Model;

	private UILobbyOptionalDownloaderView m_View;

	private bool m_isShowTips;

	private bool m_ContentShow;

	private bool m_NeedCheckTips;

	private UITipsNormalController m_GiftTipsCtrl;

	private EDownloadContextState lastMode;

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

	private void Update()
	{
	}

	private void UpdateGiftTips()
	{
	}

	private void OnControlBtnClick()
	{
	}

	private void OnTipsClose(object[] data)
	{
	}

	private void OnFlyInNotify(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
