using GCommon;
using UnityEngine;

namespace COW;

public class UICSBanPickPlayerItemRightEnemyView : UIBaseView
{
	public UISprite SelfBG;

	public GameObject SelfChoosingBG;

	public GameObject SelfLockBG;

	public UISprite BlueTeamBG;

	public GameObject BlueTeamLockBG;

	public UISprite RedTeamBG;

	public GameObject RedTeamLockBG;

	public GameObject RedTeamChoosingBG;

	public UILabel PlayerName;

	public UILabel SelfName;

	public UILabel PreSelectLabel;

	public UILabel NextPickLabel;

	public UISprite SkillIcon;

	public UISprite EmptyIcon;

	public GameObject SkillSlot;

	public UISprite SlotSpirte;

	public GameObject HelpPickRequest;

	public UILabel HelpPickLabel;

	public GameObject HelpPickAnswer;

	public UILabel HelpPickAnswerLabel;

	public UIButton HelpPickRefuseBtn;

	public UIButton HelpPickAgreeBtn;

	public UIButton ChangeSkillBtn;

	public GameObject ExchangeSkillPanel;

	public UILabel ExchangeSkillLabel;

	public UISprite ExchangeSkillIcon;

	public GameObject ExchangeSkillSlot;

	public UISprite ExchangeSlotSpirte;

	public GameObject ExchangeSkillAnswer;

	public UIButton ExchangeRefuseBtn;

	public UILabel ExchangeTimeLabel;

	public UIButton ExchangeAgreeBtn;

	public GameObject PlayerSpeak;

	public GameObject PlayerChatPanel;

	public UILabel PlayerChatLabel;

	public UITable PassiveSkillTable;

	public UIButton WaitSkillBtn;

	public UILabel OrderTime;

	public Animation OrderTimeAnimation;

	public UISprite SkillSlotBg;

	public GameObject BlueTeamChoosingBG;

	public UISprite PreSelectBG;

	public GameObject SelfLockVfx;

	public GameObject BlueLockVfx;

	public GameObject RedLockVfx;

	public GameObject HelpBan;

	public UISprite HelpBanSkillIcon;

	public UIButton CanBan;

	public GameObject ChangingSkill;

	public UIColor SelfBGColor;

	public UISprite SelfBG1;

	public UISprite SelfBG2;

	public UIColor BlueTeamBGColor;

	public UISprite BlueTeamBG1;

	public UISprite BlueTeamBG2;

	public UIColor RedTeamBGColor;

	public UISprite RedTeamBG1;

	public UISprite RedTeamBG2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
