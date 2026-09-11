using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeNewPlayerUnlockFeatureView : UIBaseView
{
	public GameObject TitleContainer;

	public UILabel Title;

	public UILabel UnlockDesc;

	public GameObject UnlockFeatureDetailContainer;

	public UITable2 Table2;

	public UIButton DetailBtn;

	public UIButton CloseBtn;

	public UISprite ActivityIcon;

	public Transform PreviewDisplayContainer;

	public Transform MainContainer;

	public UISprite TitleBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
