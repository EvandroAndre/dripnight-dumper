using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisLobbyGroupStartGameView : UIBaseView
{
	public UIButton readyBtn;

	public UILabel readyLabel;

	public GameObject Ready;

	public UILabel ReadyText;

	public GameObject CancelReady;

	public UILabel CancelReadyText;

	public UISprite readyBtnSprite;

	public UIButton playBtn;

	public UILabel StartLabel;

	public UISprite AllReadySprite;

	public UISprite NotReadySprite;

	public GameObject ReadyEffect;

	public GameObject Guide_start_Anim_Ready_Effect;

	public GameObject MatchMaking;

	public UILabel MulMatchLabel;

	public UISprite MulMatchIcon;

	public GameObject HDInCaptainLobby;

	public UILabel CaptainName;

	public UIButton BtnTeamInfo;

	public Transform ReadyEffectVFX;

	public GameObject ReadyVfxSkinChange;

	public GameObject StartIconVFX;

	public GameObject NotReadyNotify;

	public UITable InfoGrid;

	public UISprite TeamStatusLight;

	public UISprite TeamStatus;

	public GameObject Remind;

	public Animation BellAnim;

	public UILabel RemindStartLabel;

	public Animation RemindProgressAnim;

	public UISprite GameBufIconBg;

	public GameObject TeamCodeUpdateTips;

	public GameObject VFXEffectRoot;

	public UILabel TeamInfoLabel;

	public GameObject Recruiting;

	public UIPanel UIHippoCrisisLobbyGroupStartGame;

	public GameObject NormalContainer;

	public UIButton PreStartBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
