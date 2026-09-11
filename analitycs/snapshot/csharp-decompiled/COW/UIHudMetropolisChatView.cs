using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisChatView : UIBaseView
{
	public UIButton MuteBtn;

	public UISprite MuteBtnSprite;

	public UIButton BtnCloseMask;

	public UIButton CloseBtn;

	public UIButton WorldTab;

	public GameObject WorldTabSelect;

	public GameObject WorldTabNormal;

	public UIButton FactionTab;

	public GameObject FactionTabSelect;

	public GameObject FactionTabNormal;

	public UIScrollView ItemListScrollView;

	public UIEasyList ItemList;

	public UIButton ChatBtn;

	public UILabel AfterInputTxt;

	public GameObject AfterInput;

	public GameObject BeforeInput;

	public UIButton BubbleBtn;

	public UIButton UnMuteBtn;

	public UISprite FactionTabSelectIcon;

	public UISprite FactionTabNormalIcon;

	public GameObject InputContent;

	public GameObject MuteContent;

	public UIButton SendBtn;

	public UILabel TitleTxt;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
