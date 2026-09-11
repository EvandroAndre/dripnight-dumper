using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMessageView : UIBaseView
{
	public UIWidget MaskContainer;

	public GameObject QuickChatContent;

	public UIScrollView QuickChatList;

	public UIGrid QuickChatListGrid;

	public UIToggle QuickChatBlockToggle;

	public UISprite QuickChatSprite;

	public UIWidget QuickChatSoundBlock;

	public GameObject StickerContent;

	public UIScrollView ScrollViewSticker;

	public UIGrid StickerGrid;

	public StickerSpriteView StickerInstance;

	public GameObject TrainingModeMessageContent;

	public UIInput MessageInput;

	public UIButton SendBtn;

	public UIToggleButtonGroup ToggleBtnGroup;

	public UIGrid BtnGrid;

	public UIToggleButton StickerToggle;

	public UISprite StickerChosen;

	public UISprite StickerNormal;

	public UIToggleButton QuickChatToggle;

	public UISprite QuickChatToggleIconSelect;

	public UISprite QuickChatToggleIconUnSelect;

	public UIToggleButton ForbidToggle;

	public GameObject ForbidContent;

	public UIButton AllMuteBtn;

	public GameObject AllNotMute;

	public GameObject AllMute;

	public ForbidQuickChatView ForbidItem1;

	public ForbidQuickChatView ForbidItem2;

	public ForbidQuickChatView ForbidItem3;

	public ForbidQuickChatView ForbidItem4;

	public ForbidQuickChatView ForbidItem5;

	public UIGrid ForbidGrid;

	public UIToggleButton LeaderboardTitleToggle;

	public GameObject LeaderboardTitleGameObject;

	public UISprite LeaderboardTitleChosen;

	public UISprite LeaderboardTitleNormal;

	public GameObject LeaderboardTitleContent;

	public Transform LeaderboardTitlePos;

	public GameObject ToggleContent;

	public GameObject TextChatBlockQuickChatShort;

	public UIButton TextChatShortQuickChatBtn;

	public GameObject VoiceToTextBlockQuickChatShort;

	public UIButton VoiceToTextShortQuickChatBtn;

	public GameObject SingleButtonQickChatQuickChatContainer;

	public GameObject TextChatQuickChatBlock;

	public UIButton TextChatQuickChatBtn;

	public GameObject DoubleButtonQickChatContainer;

	public GameObject VoiceToTextQuickChatBlock;

	public UIButton VoiceToTextQuickChatBtn;

	public UIToggleButton HistoryMessageToggle;

	public GameObject HistoryMessageContent;

	public UIScrollView HistoryMessageScrollView;

	public GameObject DoubleButtonHistoryMessageContainer;

	public GameObject TextChatBlockHistoryMessageShort;

	public UIButton TextChatShortHistoryMessageBtn;

	public GameObject VoiceToTextBlockHistoryMessageShort;

	public UIButton VoiceToTextShortHistoryMessageBtn;

	public GameObject SingleButtonQickHistoryMessageChatContainer;

	public GameObject TextChatHistoryMessageBlock;

	public UIButton TextChatHistoryMessageBtn;

	public GameObject VoiceToTextHistoryMessageBlock;

	public UIButton VoiceToTextHistoryMessageBtn;

	public UIEasyList HistoryMessageEasyList;

	public GameObject HistoryMessagEmptyView;

	public GameObject SocialInviteContent;

	public UIScrollView SocialInviteScrollView;

	public UITable2 SocialInviteList;

	public GameObject SocialInviteBlock;

	public UIToggle SocialInviteBlockToggle;

	public UIToggleButton SocialInviteToggle;

	public UIToggle QuickChatSoundBlockToggle;

	public GameObject UnSelected;

	public UISprite QuickChatSoundSprite;

	public UILabel QuickChatSoundBlockLabel;

	public UISprite QuickChatSoundBG;

	public GameObject SocialInviteUnreadTip;

	public GameObject ScoialInviteEmptyView;

	public UILabel ScoialInviteEmptyLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
