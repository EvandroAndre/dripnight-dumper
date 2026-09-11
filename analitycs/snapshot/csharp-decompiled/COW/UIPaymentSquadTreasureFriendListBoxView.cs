using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentSquadTreasureFriendListBoxView : UIBaseView
{
	public UIButton Mask;

	public TweenPosition Main;

	public GameObject AnchorContainer;

	public GameObject BG;

	public GameObject Top;

	public UIAnchor Center;

	public GameObject TabLine;

	public GameObject EmptyTeamObj;

	public GameObject Light;

	public GameObject ScrollViewWidget;

	public UIScrollView ScrollView;

	public UIEasyList List;

	public GameObject SearchObj;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	public UIButton RefreshBtn;

	public Transform RefreshBtnRightPos;

	public Transform RefreshBtnLeftPos;

	public UIButton SearchMini;

	public TweenAlpha SearchTweenLabel;

	public GameObject SearchBtnSprite;

	public GameObject SearchClearSprite;

	public UICountDownLabel RefreshCDLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
