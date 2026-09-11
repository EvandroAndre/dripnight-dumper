using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetSharePopupWndView : UIBaseView
{
	public UINetworkTexture BGTexture;

	public UIAnchor LeftAnchor;

	public UIAnchor RightTopAnchor;

	public Camera ExtraCamera;

	public UILabel ConsecutiveDaysDescLabel;

	public UILabel ConsecutiveDaysNumLabel;

	public UILabel ConsecutiveDaysContentLabel;

	public Transform AvatarAnchor;

	public GameObject SelfSparkPetInfoContainer;

	public GameObject CollabSparkPetInfoContainer;

	public UILabel SelfSparkPetOwnerNameLabel;

	public Transform SelfSparkPetAnchor;

	public UILabel CollabSparkPetOwnerNameLabel;

	public Transform CollabSparkPetAnchor;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
