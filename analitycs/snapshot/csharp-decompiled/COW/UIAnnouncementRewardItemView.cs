using GCommon;
using UnityEngine;

namespace COW;

public class UIAnnouncementRewardItemView : UIBaseView
{
	public UIButton ItemBtn;

	public GameObject Container;

	public GameObject CheckedContainer;

	public GameObject UnCheckedContainer;

	public BaseItemView2 BaseInfoView;

	public UILabel IndexLabel;

	public UISprite ChooseSprite;

	public UISprite IconSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
