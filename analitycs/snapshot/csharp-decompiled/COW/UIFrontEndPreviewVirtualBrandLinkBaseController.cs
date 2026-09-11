using System;
using UnityEngine;

namespace COW;

public abstract class UIFrontEndPreviewVirtualBrandLinkBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewVirtualBrandLinkBaseView>
{
	private UIModelVirtualBrand m_ModedlVirtualBrand;

	private uint m_BrandID;

	private Action m_GotoCallBack;

	public Vector3 m_MoveUpPos;

	public const uint BRANDLINK_CHECK_BACKPACK = 2u;

	public const uint BRANDLINK_CHECK_HAIRSTYLE = 4u;

	protected override void InitView()
	{
	}

	public void RefreshBrand(uint brandID)
	{
	}

	public void SetPos(bool needMoveUp)
	{
	}

	public void SetGotoCallback(Action action)
	{
	}

	private void ClearGotoCallback()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	public void SetMainPanelDepth(int depth)
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
