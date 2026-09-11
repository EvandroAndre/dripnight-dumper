using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUploadSystemPopupWindowView : UIBaseView
{
	public UIToggleButtonGroup TopToggleGroup;

	public UIGrid HudNameGrid;

	public HudUploadToggle ToggleContainer;

	public UISprite Line;

	public UILabel GoPosLabel;

	public UIInput DescriptionInput;

	public BoxCollider DescriptionInputColider;

	public UIButton PublishBtnEnable;

	public UIButton PublishBtnDisable;

	public UIButton DeleteBtn;

	public UIButton EditHudBtn;

	public GameObject SensitivityContainer;

	public UIButton EditDescBtn;

	public UIButton SelectHudBtn;

	public UIWidget SelectHudWidget;

	public GameObject LikeContainer;

	public UILabel LikeCntLabel;

	public GameObject PublishBtn;

	public UIButton AddTagBtn;

	public UITable TagsTable;

	public UIScrollView TagListScrollView;

	public UIButton CancelPublishBtn;

	public Transform SelectedPreview;

	public UIButton EditPreviewBtn;

	public UIButton EditSensitivityBtn;

	public UIButton ShowSensitivityBtn;

	public UITable SensitivityTable;

	public UIPanel EditPreviewBtnPanel;

	public UILabel PublishLabelEnable;

	public UILabel PublishLabelDisable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
