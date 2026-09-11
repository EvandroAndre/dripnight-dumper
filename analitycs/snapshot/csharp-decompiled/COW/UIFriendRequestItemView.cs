using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendRequestItemView : UIBaseView
{
	public GameObject GameFriendProfileContainer;

	public UIButton ItemBtn;

	public GameObject RequestBtnGroupContainer;

	public UIButton BlockBtn;

	public UIButton RefuseBtn;

	public UIButton AgreeBtn;

	public UITable ExtraInfoTable;

	public UILabel CommonFriendLabel;

	public UILabel AddFromLabel;

	public GameObject ExtraInfoContainer;

	public UIButton ExtraInfoButton;

	public Transform ArrowIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
