using GCommon;
using UnityEngine;

namespace COW;

public class UIGroupRecruitHeadItemView : UIBaseView
{
	public UINetworkTexture HeadIcon;

	public UIEffectSprite HeadSprite;

	public UISprite FakeSprite;

	public UIButton headbtn;

	public UISprite RankIcon;

	public GameObject HeadContainer;

	public UIButton JoinBtn;

	public GameObject JoinContainer;

	public Transform InformationPos;

	public GameObject MySelf;

	public Transform BRRankIcon;

	public GameObject PrivilegeIcon;

	public Transform AvatarFramePos;

	public GameObject CSPeakRank;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
