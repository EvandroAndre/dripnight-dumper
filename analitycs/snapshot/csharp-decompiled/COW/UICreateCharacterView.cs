using GCommon;
using UnityEngine;

namespace COW;

public class UICreateCharacterView : UIBaseView
{
	public Animation AnimSwitch;

	public GameObject RegisterPanel;

	public UIInput InputNickName;

	public UIButton Random;

	public UILabel NickNameLimited;

	public UIInput InputCode;

	public UIButton BtnRegister;

	public UILabel NickNameErr;

	public UIButton BtnUseRandom;

	public TweenPosition NickNameTween;

	public UILabel NickNameDuplicate;

	public UILabel RandomNickName;

	public GameObject Card;

	public UILabel NickName;

	public UILabel UID;

	public GameObject NickNameErrContainer;

	public GameObject NickNameDuplicateContainer;

	public Transform FFLogoContainer;

	public Transform FFMaxLogoContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
