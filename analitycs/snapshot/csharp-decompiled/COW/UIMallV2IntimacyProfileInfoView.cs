using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2IntimacyProfileInfoView : UIBaseView
{
	public UIEffectSprite BG;

	public GameObject FakeBG;

	public UINetworkTexture HeadIcon;

	public UIEffectSprite HeadSprite;

	public GameObject FakeSprite;

	public UILabel NicknameLabel;

	public UILabel IntimacyValueLabel;

	public GameObject InfoContainer;

	public UIButton InfoBtn;

	public BoxCollider InfoCollider;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
