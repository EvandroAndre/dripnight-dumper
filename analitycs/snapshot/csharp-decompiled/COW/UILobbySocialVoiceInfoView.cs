using GCommon;
using UnityEngine;

namespace COW;

public class UILobbySocialVoiceInfoView : UIBaseView
{
	public UISprite MicOff;

	public UISprite MicAll;

	public UISprite MicPrematch;

	public UIButton ToggleBtn;

	public GameObject Selected;

	public UIButton GoSettingBtn;

	public UIButton CloseMask;

	public Transform InGamePos;

	public GameObject VoiceChangerContainer;

	public UIButton PrematchBtn;

	public UIButton AllBtn;

	public UIButton OffBtn;

	public UILabel VoiceName;

	public GameObject PrematchContainer;

	public UIGrid MicGrid;

	public UILabel OffLabel;

	public UILabel AllLabel;

	public UILabel PrematchLabel;

	public UIButton SpeakerOffBtn;

	public UISprite SpeakerOff;

	public UILabel SpeakerOffLabel;

	public UISprite SpeakerAll;

	public UILabel SpeakerAllLabel;

	public UIButton SpeakerAllBtn;

	public UIButton SpeakerPrematchBtn;

	public UISprite SpeakerPrematch;

	public UILabel SpeakerPrematchLabel;

	public UIGrid SpeakerGrid;

	public GameObject MicContainer;

	public GameObject SpeakerContainer;

	public UIButton PressedPrematchBtn;

	public UIButton PressedAllBtn;

	public UIGrid PressedGrid;

	public UISprite PressedMicAll;

	public UISprite PressedMicPrematch;

	public GameObject PressedPrematchContainer;

	public GameObject PressedAllContainer;

	public UILabel PressedAllLabel;

	public UISprite MicContainerBG;

	public UILabel PressedPrematchLabel;

	public GameObject SpeakerPrematchContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
