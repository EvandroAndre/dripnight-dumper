using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSubgameLobbyLWMatchResultView : UIBaseView
{
	public Camera AvatarCamera;

	public UIButton BtnBack;

	public UIButton BtnKeep;

	public GameObject WinnerContainer;

	public GameObject LoserContainer;

	public UILabel BtnBackLabel;

	public UIButton AddFriendBtn;

	public UISprite AddFriendIcon;

	public UILabel StreakLabelWinner;

	public GameObject AddFriendContainer;

	public UILabel StreakLabelWinnerLoser;

	public GameObject StreakContainerLoser;

	public GameObject StreakContainerWinner;

	public GameObject Win;

	public GameObject Lose;

	public GameObject StreakBg;

	public GameObject StreakBg_Special;

	public UILabel PlayerNameLabel;

	public UIButton ReportBtn;

	public UISprite ReportSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
