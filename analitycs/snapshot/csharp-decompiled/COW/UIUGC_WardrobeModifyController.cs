using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIUGC_WardrobeModifyController : UIPopupWindowController
{
	private UIUGC_WardrobeModifyView m_View;

	private LCBJLLIGMCP curStyle;

	private NFDDMIMFPID lastStyle;

	private UIUGC_WardrobeConfig defaultStyle;

	private int curPartIndex;

	private Color curColor1;

	private Color curColor2;

	private Color pantsColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private new void Awake()
	{
	}

	protected override void OnUIInit()
	{
	}

	private void OnStyleSelect(UIToggleButton selectButton)
	{
	}

	private void OnPartSelect(UIToggleButton t)
	{
	}

	private void UpdateColorSelector(Color curColor)
	{
	}

	private void OnColorSelect(UIToggleButton t)
	{
	}

	private void OnRandom()
	{
	}

	public void SetCloth(NFDDMIMFPID cloth)
	{
	}

	private void OnLastStyle()
	{
	}

	private void RefreshPreview()
	{
	}

	private void OnConfirm()
	{
	}

	private void OnClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
