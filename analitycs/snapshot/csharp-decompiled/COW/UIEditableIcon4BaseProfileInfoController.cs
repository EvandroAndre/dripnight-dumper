using GCommon;
using UnityEngine;

namespace COW;

public class UIEditableIcon4BaseProfileInfoController : UIEditableIconBaseController
{
	private UIEditableIcon4BaseProfileInfoView m_View;

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

	protected override void OnUIOpen()
	{
	}

	public override void SetDepth(int depth)
	{
	}

	public override int GetDepth()
	{
		return 0;
	}

	public Vector2 GetHeadSize()
	{
		return default(Vector2);
	}

	public override int GetStickerID()
	{
		return 0;
	}

	public override void SetSelectState(bool isSelect, bool isManualSelect = false)
	{
	}

	public override void SetViewData(UIWidget widgetBound, StickerWithResConfig stickerWithResConfig, string descLabel = null, bool isVertical = false)
	{
	}

	protected override void OnDeleteBtnClick()
	{
	}

	private void UpdatePlayerBasicInfo()
	{
	}

	private void UpdateBanner(uint bannerId)
	{
	}

	public void UpdateBanner(BannerData bannerdata)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_SetDepth(int P0)
	{
	}

	public int _003C_003EiFixBaseProxy_GetDepth()
	{
		return 0;
	}

	public int _003C_003EiFixBaseProxy_GetStickerID()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_SetSelectState(bool P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(UIWidget P0, StickerWithResConfig P1, string P2, bool P3)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDeleteBtnClick()
	{
	}
}
