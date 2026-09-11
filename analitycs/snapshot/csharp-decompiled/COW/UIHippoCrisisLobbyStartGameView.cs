using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisLobbyStartGameView : UIBaseView
{
	public Transform Main;

	public UILobbyNewSkinChangeView RightBottomView;

	public UILabel difficultyModeSelected;

	public UIButton teamModeBtn;

	public UISprite teamIcon;

	public TweenPosition TweenPosPanelRightBottom;

	public GameObject soloPanel;

	public GameObject GameObjectMatchMaking;

	public UISprite UISpriteMatchMaking;

	public UILabel SoloMatchMakingLabel;

	public UISprite LobbyStartIcon;

	public UILabel StartMatchLabel;

	public GameObject Guide_start_Anim;

	public UILabel SoloBtnEnterDisLabel;

	public Transform groupPanel;

	public GameObject LadderContainer;

	public UIButton LadderBtn;

	public Transform LadderBtnTransform;

	public UIWidget LadderBtnUIWidget;

	public UIButton EnterGameBtn;

	public UISprite MapModeBtnBg;

	public UIButton AdjustDifficultyModeBtn;

	public GameObject EnterGameDisable;

	public UILabel mapModeSelectedLabel;

	public Transform HippoCrisisRankIconContainer;

	public GameObject teamModesPanel;

	public UIPanel UIHippoCrisisLobbyStartGame;

	public UIButton AdjustPresetBtn;

	public GameObject PresetMissIcon;

	public GameObject ModeMask;

	public GameObject AdjustDifficultyModePanel;

	public Transform DifficultyPanel;

	public GameObject NormalContainer;

	public UIButton PreStartBtn;

	public GameObject NotEquipTips;

	public UIWidget EnterGameGuideWidget;

	public UIWidget PreStartGuideWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
