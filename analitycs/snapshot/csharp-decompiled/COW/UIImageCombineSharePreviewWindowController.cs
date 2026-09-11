using GCommon;
using UnityEngine;

namespace COW;

internal class UIImageCombineSharePreviewWindowController : UIImageSharePreviewWindowBaseController
{
	private UIImageCombineSharePreviewWindowView m_View;

	private UIWidget SharePreviewWidget;

	private UIPanel SharePreviewPanel;

	private Texture2D m_ShareTex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void UpdateShareImage()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
