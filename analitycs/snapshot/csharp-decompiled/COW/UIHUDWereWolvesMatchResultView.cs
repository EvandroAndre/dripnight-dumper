using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDWereWolvesMatchResultView : UIBaseView
{
	public GameObject RewardRoot;

	public UITable RewardTabel;

	public UILabel GoldCount;

	public UILabel ExpCount;

	public UISprite PetExpIcon;

	public UILabel PetExpCount;

	public UIButton ShareBtn;

	public UIButton QuitBtn;

	public UILabel QuitTimeLabel;

	public UIHUDWereWolvesPlayerResultItem PlayerInfoTemplate;

	public GameObject WinRoot;

	public GameObject DefeatRoot;

	public GameObject WolfRolIconRoot;

	public GameObject WolfRoleWinIcon;

	public GameObject WolfRoleDefeatIcon;

	public GameObject HumanRoleIconRoot;

	public GameObject HumanRoleWinIcon;

	public GameObject HumanRoleDefeatIcon;

	public UILabel GameOverReasonLabel;

	public UIGrid LeftDataGrid;

	public UIGrid RightDataGrid;

	public UIEasyList ChatEasyList;

	public UIInput ChatInput;

	public UIButton BtnSendChat;

	public UIButton BtnVoice;

	public GameObject VoiceOn;

	public GameObject VoiceOff;

	public GameObject MicBan;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
