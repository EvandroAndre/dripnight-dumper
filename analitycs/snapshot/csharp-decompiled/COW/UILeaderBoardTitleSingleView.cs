using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardTitleSingleView : UIBaseView
{
	public UILabel LeftRegionAndNameLabel;

	public UIWidget Right;

	public UILabel RightRegionAndNameLabel;

	public UIWidget Left;

	public UISprite RightBG;

	public UISprite LeftBG;

	public Transform RightIconPos;

	public Transform LeftIconPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
