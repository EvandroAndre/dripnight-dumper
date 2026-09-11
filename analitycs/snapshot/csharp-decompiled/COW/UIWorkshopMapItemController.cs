using System;
using GCommon;

namespace COW;

internal class UIWorkshopMapItemController : UIBaseController
{
	private UIWorkshopMapItemView m_View;

	public int ItemIdx;

	private Action m_ClickCallBack;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetUISize(int width, int height)
	{
	}

	public void SetCDNData(string url)
	{
	}

	public void SetCDNData(byte[] cdnData)
	{
	}

	public void SetGameMapData(SceneEditSlotInfo info, string defaultUrl)
	{
	}

	public void SetBtnClick(Action callback)
	{
	}

	public void OnClick()
	{
	}

	private void _003CSetCDNData_003Eb__9_0()
	{
	}

	private void _003CSetGameMapData_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
