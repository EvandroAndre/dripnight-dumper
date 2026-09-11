using GCommon;
using UnityEngine;

namespace COW;

public class UIHudGameVoiceView : UIBaseView
{
	public GameObject TeammateVoiceTemp;

	public GameObject VoiceMutePanel;

	public UIButton VoicePanelMaskBtn;

	public UIButton MuteAllBtn;

	public UISprite MutedAllSprite;

	public UISprite NotMuteAllSprite;

	public UISprite Line;

	public GameObject TeamMateContainer;

	public UISprite MuteMask;

	public UISprite SubLine;

	public UILabel MuteAllLabel;

	public GameObject ThreeContainer;

	public UIButton NoneTab;

	public UIButton PreMatchTab;

	public UIButton AllTab;

	public UISprite NoneSprite;

	public UILabel NoneLabel;

	public UILabel PreMatchLabel;

	public UISprite PreMatchSprite;

	public UILabel AllLabel;

	public UISprite AllSprite;

	public UIButton ReportToggle;

	public UIButton ReportClose;

	public AllPlayerVoiceView AllPlayerVoiceTemp;

	public UITable AllPlayerContainer;

	public UISprite AllSpriteRoom;

	public GameObject ReportContainer;

	public UISprite MutePanelBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
