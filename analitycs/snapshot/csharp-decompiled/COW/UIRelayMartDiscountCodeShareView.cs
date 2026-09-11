using GCommon;
using UnityEngine;

namespace COW;

public class UIRelayMartDiscountCodeShareView : UIBaseView
{
	public UIButton Mask;

	public GameObject EmptyTeamObj;

	public UIEasyList List;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	public UIButton RefreshBtn;

	public TweenAlpha SearchTweenLabel;

	public GameObject SearchBtnSprite;

	public GameObject SearchClearSprite;

	public UICountDownLabel RefreshCDLabel;

	public GameObject RefreshNormalObj;

	public UIButton BtnLineShare;

	public UIButton BtnFBShare;

	public UIButton BtnWhatsAppShare;

	public UIButton BtnInstgramShare;

	public UIGrid Grid;

	public UIScrollView ScrollView;

	public UIPanel ScrollViewPanel;

	public UISprite FBMessageIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
