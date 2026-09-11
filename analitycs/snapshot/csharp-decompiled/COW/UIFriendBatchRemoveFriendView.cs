using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendBatchRemoveFriendView : UIBaseView
{
	public UIButton DeleteBtn;

	public UIEasyList EasyList;

	public UILabel NumLabel;

	public UIButton AllSelectBtn;

	public GameObject IsAllSelected;

	public UILabel TipLabel;

	public UISprite DeleteBtnBGUnActive;

	public UISprite DeleteBtnBGActive;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
