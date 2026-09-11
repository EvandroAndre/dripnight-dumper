using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarV2RoundChangeView : UIBaseView
{
	public UIButton CloseBtn;

	public GameObject RoundChange;

	public GameObject SeasonChange;

	public UILabel SeasonTitleOld;

	public UILabel SeasonTipsOld;

	public UILabel SeasonTitleNew;

	public UILabel SeasonTimeNew;

	public UILabel SeasonTipsNew;

	public UILabel RoundTitleOld;

	public UILabel RoundTitleNew;

	public Animation Anim;

	public UINetworkTexture ClanIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
