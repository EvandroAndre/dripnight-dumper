using GCommon;
using UnityEngine;

namespace COW;

public class UIImageCoverPreviewWindowView : UIBaseView
{
	public UIPopupGlassBG UIImageCoverPreviewWindow;

	public UIButton BtnClose;

	public UITexture CoverPreview;

	public UIGrid Grid;

	public UIButton BtnShare;

	public UIButton BtnSetAsCover;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
