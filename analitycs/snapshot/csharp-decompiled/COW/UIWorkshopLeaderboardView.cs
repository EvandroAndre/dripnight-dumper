using GCommon;
using UnityEngine;

namespace COW;

public class UIWorkshopLeaderboardView : UIBaseView
{
	public UIGrid TitleGrid;

	public UIScrollView ScrollView;

	public UIEasyList Grid;

	public GameObject TailArrow;

	public UISprite SelfItem;

	public UILabel ClearTime;

	public UIButton RefreshButton;

	public UISprite Title;

	public GameObject Root;

	public Transform Waiting;

	public UILabel RefreshLabel;

	public WidgetAutoScrollLabel TitleTemplate;

	public GameObject Nodata;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
