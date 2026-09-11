using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoView : UIBaseView
{
	public UIButton GroupPhotoBtn;

	public UIButton EmoteBtn;

	public UIButton VerticalBtn;

	public Transform EmotePanelPos;

	public UIButton CloseBtn;

	public UIButton SettingBtn;

	public UIGrid UIGrid;

	public Transform OperateBtnContainer;

	public Transform SettingPanelContainer;

	public GameObject IsOpen;

	public Transform ButtonClose;

	public Transform EmoteListContainer;

	public GameObject EmoteBtnIsOpen;

	public Transform GroupPhotoBtnTipsContainer;

	public GameObject ItemRotateTouchArea_Profile;

	public GameObject PetEmotePanel_Profile;

	public GameObject FilterListContainer;

	public GameObject FilterBtnIsOpen;

	public UIButton FilterBtn;

	public UIWidget FilterBtnWidget;

	public UIAnchor Left;

	public UIAnchor Right;

	public UIAnchor TopRight;

	public UILabel FilterBtnLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
