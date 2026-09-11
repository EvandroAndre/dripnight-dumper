using GCommon;
using UnityEngine;

namespace COW;

public class UIBriefProfileInfoView : UIBaseView
{
	public UIButton UIBriefProfileInfo;

	public UILabel nickname;

	public UISprite BtnPinIcon;

	public GameObject Self;

	public UIButton Btnclose;

	public GameObject GameVoiceBtnGroup;

	public UIButton MicToggle;

	public UISprite MicBan;

	public UISprite MicSprite;

	public UISprite MicMask;

	public UIButton SpeakerToggle;

	public UISprite SpeakerSprite;

	public UISprite SpeakerMask;

	public Transform GroupMemeberVoice;

	public UISprite MicTeam;

	public UISprite SpeakerTeam;

	public GameObject NormalBanner;

	public GameObject RankLimitBanner;

	public GameObject RankLimitVFX;

	public GameObject PrivilegeIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
