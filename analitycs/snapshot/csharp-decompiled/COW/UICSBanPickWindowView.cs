using GCommon;
using UnityEngine;

namespace COW;

public class UICSBanPickWindowView : UIBaseView
{
	public GameObject PhaseChange;

	public Animation PhaseChangeAnimation;

	public UILabel PhaseLabel;

	public UILabel BanResult;

	public GameObject Top;

	public Animation TopAnimation;

	public UILabel StageLabel;

	public UILabel TimeLabel;

	public UILabel SingleStageLabel;

	public GameObject BottomLeft;

	public GameObject ChatContainer;

	public UIButton CommonChatBtn;

	public UIButton MicToggle;

	public UISprite MicMask;

	public UISprite MicSprite;

	public UISprite MicBan;

	public UIButton SpeakerToggle;

	public UISprite SpeakerSprite;

	public UISprite SpeakerMask;

	public UILabel ChatTips;

	public UIButton LoadoutBtn;

	public UIToggleButtonGroup TagContainer;

	public UIToggleButton AllBtn;

	public UIToggleButton GroupBtn;

	public UIToggleButton SurviveBtn;

	public UIToggleButton AttackBtn;

	public UIToggleButton InfoBtn;

	public UIScrollView CenterScrollView;

	public UIEasyList CenterEasyList;

	public UISprite LockSkillIcon;

	public GameObject LeftBanSkillResult;

	public GameObject RightBanSkillResult;

	public UIButton BtnLock;

	public UIButton BtnBan;

	public UIButton BtnRequest;

	public UIButton BtnRequestCoolDown;

	public UILabel RequestCoolDownLabel;

	public GameObject SkillChangeBubble;

	public UITable BanResultTable;

	public GameObject LeftPlayer1;

	public GameObject LeftPlayer2;

	public GameObject LeftPlayer3;

	public GameObject LeftPlayer4;

	public GameObject RightPlayer1;

	public GameObject RightPlayer2;

	public GameObject RightPlayer3;

	public GameObject RightPlayer4;

	public UIButton BtnBack;

	public UIButton BtnRequestBan;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
