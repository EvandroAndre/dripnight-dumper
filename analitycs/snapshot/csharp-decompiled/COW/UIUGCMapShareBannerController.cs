using GCommon;
using proto;

namespace COW;

public class UIUGCMapShareBannerController : UIBaseController
{
	private UIUGCMapShareBannerView m_View;

	private UIWorkshopMapItemController m_MapItemCtrl;

	private UIUGCHotIndicatorController m_IndicatorCtrl;

	private UIModelSceneEdit m_Model;

	private string m_Code;

	private ulong m_SenderId;

	private SceneEditSlotInfo m_Info;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(MessageInfo msgInfo)
	{
	}

	public void SetMapPanelDepth(int depth)
	{
	}

	private void OnRecvMapInfo(WorkshopBasicInfo info)
	{
	}

	private void OnLinkClik()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
