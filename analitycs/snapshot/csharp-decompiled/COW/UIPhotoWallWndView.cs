using GCommon;
using UnityEngine;

namespace COW;

public class UIPhotoWallWndView : UIBaseView
{
	public GameObject ListScrollView;

	public GameObject DropdownRoot;

	public UIButton StickerBtn;

	public UIButton SaveBtn;

	public UIButton ExitBtn;

	public UIButton ResetBtn;

	public UIEasyList EasyList;

	public UIPanel EditPanel;

	public UIButton ClickPanel;

	public Transform DragPanel;

	public Transform StickerPanelRoot;

	public GameObject EmptyListNode;

	public UILabel ImageNumLabel;

	public Camera CaptureCamera;

	public UILabel EmptyEditPanelLabel;

	public GameObject LoadingBG;

	public UINetworkTexture BG;

	public UINetworkTexture FrameBg;

	public UIPanel PanelMask;

	public GameObject GrayoutSaveBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
