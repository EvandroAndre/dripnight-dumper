using GCommon;
using UnityEngine;

namespace COW;

public class UIWorkshopLeaderboardItemView : UIBaseView
{
	public UISprite Bg01;

	public UISprite CupIcon;

	public UISprite CupIconTop;

	public GameObject PlayerProfile;

	public UIGrid Content;

	public UILabel RankLabel;

	public Transform RankRoot;

	public Transform ProfileRoot;

	public UIWidget ItemRoot;

	public WidgetAutoScrollLabel LabelTemplate;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
