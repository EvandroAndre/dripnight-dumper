using GCommon;
using UnityEngine;

namespace COW;

internal class UIGameModeBaseItemView : MonoBehaviour
{
	public UIToggleButton ModeBtn;

	public Transform ModeInfo;

	public UISprite ModeSprite;

	public UINetworkTexture NetworkTexture;

	public UINetworkTexture UINetworkTexture02;

	public Transform TopLeft;

	public UITexture clippedNetworkTexture;

	public GameObject clickEffect;

	public GameObject download;

	public UIPanel liveEffectsPanel;

	public GameObject bg;

	public UIPanel panelOverLiveEffects;

	public UIPanel Lock;

	public UILabel LevelLabel;

	public GameObject staticPic;

	public GameObject HLEffect;

	public GameObject GuideTip;

	public GameObject Selected;

	public UIPanel DuoVersionNode;

	public GameObject DuoVersion_UpdateNotAvailiable;

	public GameObject DuoVersion_UpdateAvailiable;

	public UIButton DuoVersionBtn;

	public GameObject NormalMatchBG;

	public UIPanel SeasonSwitchNode;

	public UILabel SeasonSwitchLabel;

	public UICountDownLabel SeasonSwitchCountDownLabel;

	public UIButton SeasonSwitchBtn;

	public GameObject PickHighLight;

	public UIWidget ModeBtnWidget;

	public Transform Top;

	public Transform TopRight;

	public UIButton GameplayAffixTipsBtn;

	public GameObject GotoBindContainer;

	public UILabel GotoBindLabel;

	public Transform RankTrans;

	public UIPanel BanMatchContainer;

	public UILabel BanMatchLabel;

	public Transform BanMatchTime;

	public UIButton BanMatchBtn;

	public GameObject ActivityDownloadMask;

	public GameObject BasicDownloadMask;
}
