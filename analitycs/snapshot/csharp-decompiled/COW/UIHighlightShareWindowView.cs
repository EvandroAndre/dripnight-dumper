using GCommon;
using UnityEngine;

namespace COW;

public class UIHighlightShareWindowView : UIBaseView
{
	public UIButton BtnClose;

	public UIWidget CloseWidget;

	public UIToggleButtonGroup ToggleGroup;

	public UITable ToggleTable;

	public UIWidget ToggleWidget;

	public UIToggleButton ToggleVideo;

	public UIToggleButton TogglePhoto;

	public UIToggleButton ToggleResult;

	public Transform VideoPreviewContainer;

	public UIToggleButton ToggleScore;

	public Transform HighlightTipsVideoBtnContainer;

	public Transform ImagePreviewContainer;

	public UIPanel ExtralContainer;

	public UILabel PhotoLabel;

	public UILabel PhotoUnselectLabel;

	public UIToggleButton ToggleRoom;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
