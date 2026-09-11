using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GameAssistHighlightMomentItemView : UIBaseView
{
	public GameObject Container;

	public GameObject BgContainer;

	public GameObject Line;

	public UISprite HighlightIcon;

	public UILabel ModeName;

	public UILabel HighLightLabel;

	public UIButton HighLightGotoBtn;

	public UIButton GotoPostReviewBtn;

	public UILabel TIme;

	public GameObject HighLightNotRead;

	public GameObject HighLightHasRead;

	public GameObject ReviewHasRead;

	public GameObject ReviewNotRead;

	public GameObject Mask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
