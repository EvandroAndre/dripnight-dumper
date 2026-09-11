using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchTeamCreateFormView : UIBaseView
{
	public UIButton Confirm;

	public UIButton Cancel;

	public UITable Content;

	public UILabel Name;

	public UIInput NameInput;

	public GameObject NationalFlag;

	public UISprite Flag;

	public UIButton FlagSelect;

	public GameObject ClanAvatar;

	public UIEffectSprite Avatar;

	public UIButton AvatarSelect;

	public GameObject ClanBanner;

	public UIEffectSprite Banner;

	public UISprite MiniBanner;

	public UIButton BannerSelect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
