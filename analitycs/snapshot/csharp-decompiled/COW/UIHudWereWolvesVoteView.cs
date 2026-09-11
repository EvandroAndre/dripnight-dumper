using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWereWolvesVoteView : UIBaseView
{
	public UIScrollView ContentScrollView;

	public UIEasyList ContentList;

	public UIButton BtnVote;

	public UIButton BtnSkip;

	public UILabel CountDownLabel;

	public UIButton BtnMap;

	public GameObject MapHint;

	public UIWidget BtnMapTutorialWidget;

	public UILabel TitleLabel;

	public UILabel DescLabel;

	public UIProgressBar CountDownProgress;

	public GameObject SponsorNode;

	public UIButton BtnSpeaker;

	public GameObject SpeakerOn;

	public GameObject SpeakerOff;

	public UIWidget MicTutorialWiget;

	public GameObject SkipVoteNode;

	public UIGrid SkipNodeGrid;

	public GameObject QuickChatNode;

	public GameObject SpeakerNode;

	public UIToggleButton ChatTab;

	public UIToggleButton HistroyTab;

	public UIScrollView ChatScrollView;

	public UIEasyList ChatEasyList;

	public UIButton BtnMic;

	public GameObject MicOn;

	public GameObject MicOff;

	public GameObject MicBan;

	public GameObject ChatNode;

	public UIInput ChatInput;

	public UIButton BtnSendChat;

	public UIButton BtnQuickChat;

	public GameObject DisChatNode;

	public GameObject HistroyRoot;

	public UIScrollView HistroyScorllView;

	public UIEasyList HistroyEasyList;

	public GameObject EmptyHistroyRoot;

	public UIToggleButton TabHistroyOne;

	public UIToggleButton TabHistroyTwo;

	public UIToggleButton TabHistroyThree;

	public GameObject NoOneVoteRoot;

	public UIWidget ChatTutorialWiget;

	public UIWidget VoteAndSkipTutorialWiget;

	public UIWidget TitleTutorialWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
