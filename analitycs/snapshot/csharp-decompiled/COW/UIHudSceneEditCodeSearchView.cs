using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditCodeSearchView : UIBaseView
{
	public GameObject InfoPanel;

	public UISceneEditSlotInfoView SlotInfoView;

	public UISprite MapIcon;

	public UINetworkTexture CDNMap;

	public UILabel CodeTxt;

	public UIGrid InfoGrid;

	public UIButton BtnReport;

	public UIButton BtnPreview;

	public UIButton BtnSubscribe;

	public GameObject GMPreview;

	public UIButton BtnGMVerifyLast;

	public UIButton BtnGMVerifyNext;

	public UILabel GMExaminationResultTxt;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
