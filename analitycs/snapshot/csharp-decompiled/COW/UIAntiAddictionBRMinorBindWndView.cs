using GCommon;
using UnityEngine;

namespace COW;

public class UIAntiAddictionBRMinorBindWndView : UIBaseView
{
	public GameObject SearchContainer;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	public GameObject SeachErrorContainer;

	public GameObject ProfileContainer;

	public GameObject EmptyContainer;

	public UILabel EmptyNoticeLabel;

	public GameObject HeadContainer;

	public UIEffectSprite HeadSprite;

	public UILabel NameLabel;

	public UILabel AccountIdLabel;

	public UIButton ConfirmBtn;

	public UILabel ConfirmBtnNoticeLabel;

	public UIEffectSprite BannerBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
