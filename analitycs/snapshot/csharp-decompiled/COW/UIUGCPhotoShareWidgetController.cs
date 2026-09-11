using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCPhotoShareWidgetController : UIBaseController
{
	private UIUGCPhotoShareWidgetView m_View;

	private UIQRCodeController m_QRCodeCtrl;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelQRCode m_ModelQRCode;

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

	private void SetUILayer(uint layer, GameObject go)
	{
	}

	private void RefreshMapInfo()
	{
	}

	private void UpdateUIWithSlotInfo(SceneEditSlotInfo slotInfo)
	{
	}

	public void UpdateUIInfo(string mapName, string authorName, string modeName, string workshopCode)
	{
	}

	public void DoUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
