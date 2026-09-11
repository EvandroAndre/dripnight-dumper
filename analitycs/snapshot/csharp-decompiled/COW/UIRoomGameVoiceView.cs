using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomGameVoiceView : UIBaseView
{
	public GameObject TeammateVoiceTemp;

	public GameObject VoiceMutePanel;

	public UISprite Line;

	public UITable TeamMateContainer;

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

	public UIButton VoicePanelMaskBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
