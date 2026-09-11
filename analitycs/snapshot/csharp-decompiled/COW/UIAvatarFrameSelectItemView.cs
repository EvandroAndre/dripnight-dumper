using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarFrameSelectItemView : UIBaseView
{
	public Transform AvatarFramePos;

	public UILabel AvatarFrameName;

	public GameObject NotDisplayIcon;

	public GameObject SelectHighlight;

	public UIButton ItemButton;

	public GameObject NotOwnedMask;

	public GameObject notOwnedAvatarFrameName;

	public UILabel GotoLabel;

	public GameObject Line;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
