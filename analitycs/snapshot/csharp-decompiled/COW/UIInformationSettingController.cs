using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIInformationSettingController : UISettingContentBase
{
	private enum SettingBlock
	{
		Visual,
		Score,
		Notification,
		BotAgent,
		AIChat
	}

	private enum InformationSettingKey
	{
		CrossHairMode,
		DamageSetting,
		BloodMode,
		HitHint,
		AutoQuickChatV2,
		NameAlphaGroup,
		HitArmorHint,
		ToggleATKContainer,
		ToggleZoneContainer,
		HideTeammateName,
		ShowPlayerOutline,
		PlayerStatsShowSP,
		ShowHint3D,
		BrScoreBoardOpenMode,
		SafezoneMode,
		StackedKillMode,
		GunshotsAlert,
		AutoQuickMessage,
		ItemFinderMode,
		InGameEmoji,
		ShowTeamOutline,
		BotAgentSwitch,
		BotAgentVoiceVolume,
		BotAgentCatFeedback,
		BotAgentCatLoot,
		BotAgentCatOperation,
		BotAgentCatGunHelper,
		BotAgentCatSurviveTip,
		BotAgentCatCooperation,
		AIChatInGameSwitch,
		AIChatInUGCSwitch,
		DamageLabelTotal,
		BotAgentCSSwitch,
		BotAgentCSVoiceVolume,
		BotAgentCSRule,
		BotAgentCSShop,
		BotAgentCSBattle,
		BotAgentCSMap
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__24_0;

		public static Action _003C_003E9__24_1;

		public static Func<int> _003C_003E9__26_0;

		public static Action _003C_003E9__26_1;

		public static Action _003C_003E9__26_2;

		public static Action _003C_003E9__59_0;

		public static Action _003C_003E9__59_1;

		public static Func<int> _003C_003E9__80_0;

		public static Func<float> _003C_003E9__82_0;

		public static Action<float> _003C_003E9__82_1;

		public static Func<float> _003C_003E9__82_2;

		public static Func<float> _003C_003E9__82_3;

		public static Action _003C_003E9__83_1;

		public static Action _003C_003E9__83_2;

		public static Func<int> _003C_003E9__83_0;

		public static Action _003C_003E9__84_1;

		public static Action _003C_003E9__84_2;

		public static Func<int> _003C_003E9__84_0;

		public static Action _003C_003E9__85_1;

		public static Action _003C_003E9__85_2;

		public static Func<int> _003C_003E9__85_0;

		public static Action _003C_003E9__86_1;

		public static Action _003C_003E9__86_2;

		public static Func<int> _003C_003E9__86_0;

		public static Action _003C_003E9__87_1;

		public static Action _003C_003E9__87_2;

		public static Func<int> _003C_003E9__87_0;

		public static Func<int> _003C_003E9__88_0;

		public static Func<float> _003C_003E9__90_0;

		public static Action<float> _003C_003E9__90_1;

		public static Func<float> _003C_003E9__90_2;

		public static Func<float> _003C_003E9__90_3;

		public static Action _003C_003E9__91_1;

		public static Action _003C_003E9__91_2;

		public static Func<int> _003C_003E9__91_0;

		public static Action _003C_003E9__92_1;

		public static Action _003C_003E9__92_2;

		public static Func<int> _003C_003E9__92_0;

		public static Action _003C_003E9__93_1;

		public static Action _003C_003E9__93_2;

		public static Func<int> _003C_003E9__93_0;

		public static Action _003C_003E9__94_1;

		public static Action _003C_003E9__94_2;

		public static Func<int> _003C_003E9__94_0;

		public static Action _003C_003E9__96_1;

		public static Action _003C_003E9__96_2;

		public static Func<int> _003C_003E9__96_0;

		public static Action _003C_003E9__97_1;

		public static Action _003C_003E9__97_2;

		public static Func<int> _003C_003E9__97_0;

		internal void _003CCreateEnemyFireData_003Eb__24_0()
		{
		}

		internal void _003CCreateEnemyFireData_003Eb__24_1()
		{
		}

		internal int _003CCreateAutoQuickMessage_003Eb__26_0()
		{
			return 0;
		}

		internal void _003CCreateAutoQuickMessage_003Eb__26_1()
		{
		}

		internal void _003CCreateAutoQuickMessage_003Eb__26_2()
		{
		}

		internal void _003CCreateAutoQuickChatV2SettingData_003Eb__59_0()
		{
		}

		internal void _003CCreateAutoQuickChatV2SettingData_003Eb__59_1()
		{
		}

		internal int _003CCreateBotAgentSwitchData_003Eb__80_0()
		{
			return 0;
		}

		internal float _003CCreateBotAgentVoiceVolumeData_003Eb__82_0()
		{
			return 0f;
		}

		internal void _003CCreateBotAgentVoiceVolumeData_003Eb__82_1(float value)
		{
		}

		internal float _003CCreateBotAgentVoiceVolumeData_003Eb__82_2()
		{
			return 0f;
		}

		internal float _003CCreateBotAgentVoiceVolumeData_003Eb__82_3()
		{
			return 0f;
		}

		internal void _003CCreateBotAgentCatLootData_003Eb__83_1()
		{
		}

		internal void _003CCreateBotAgentCatLootData_003Eb__83_2()
		{
		}

		internal int _003CCreateBotAgentCatLootData_003Eb__83_0()
		{
			return 0;
		}

		internal void _003CCreateBotAgentCatOperationData_003Eb__84_1()
		{
		}

		internal void _003CCreateBotAgentCatOperationData_003Eb__84_2()
		{
		}

		internal int _003CCreateBotAgentCatOperationData_003Eb__84_0()
		{
			return 0;
		}

		internal void _003CCreateBotAgentCatFeedbackData_003Eb__85_1()
		{
		}

		internal void _003CCreateBotAgentCatFeedbackData_003Eb__85_2()
		{
		}

		internal int _003CCreateBotAgentCatFeedbackData_003Eb__85_0()
		{
			return 0;
		}

		internal void _003CCreateBotAgentCatGunHelperData_003Eb__86_1()
		{
		}

		internal void _003CCreateBotAgentCatGunHelperData_003Eb__86_2()
		{
		}

		internal int _003CCreateBotAgentCatGunHelperData_003Eb__86_0()
		{
			return 0;
		}

		internal void _003CCreateBotAgentCatSurviveTipData_003Eb__87_1()
		{
		}

		internal void _003CCreateBotAgentCatSurviveTipData_003Eb__87_2()
		{
		}

		internal int _003CCreateBotAgentCatSurviveTipData_003Eb__87_0()
		{
			return 0;
		}

		internal int _003CCreateBotAgentCSSwitchData_003Eb__88_0()
		{
			return 0;
		}

		internal float _003CCreateBotAgentCSVoiceVolumeData_003Eb__90_0()
		{
			return 0f;
		}

		internal void _003CCreateBotAgentCSVoiceVolumeData_003Eb__90_1(float value)
		{
		}

		internal float _003CCreateBotAgentCSVoiceVolumeData_003Eb__90_2()
		{
			return 0f;
		}

		internal float _003CCreateBotAgentCSVoiceVolumeData_003Eb__90_3()
		{
			return 0f;
		}

		internal void _003CCreateBotAgentCSRuleData_003Eb__91_1()
		{
		}

		internal void _003CCreateBotAgentCSRuleData_003Eb__91_2()
		{
		}

		internal int _003CCreateBotAgentCSRuleData_003Eb__91_0()
		{
			return 0;
		}

		internal void _003CCreateBotAgentCSShopData_003Eb__92_1()
		{
		}

		internal void _003CCreateBotAgentCSShopData_003Eb__92_2()
		{
		}

		internal int _003CCreateBotAgentCSShopData_003Eb__92_0()
		{
			return 0;
		}

		internal void _003CCreateBotAgentCSBattleData_003Eb__93_1()
		{
		}

		internal void _003CCreateBotAgentCSBattleData_003Eb__93_2()
		{
		}

		internal int _003CCreateBotAgentCSBattleData_003Eb__93_0()
		{
			return 0;
		}

		internal void _003CCreateBotAgentCSMapData_003Eb__94_1()
		{
		}

		internal void _003CCreateBotAgentCSMapData_003Eb__94_2()
		{
		}

		internal int _003CCreateBotAgentCSMapData_003Eb__94_0()
		{
			return 0;
		}

		internal void _003CCreateAIChatInGameSwitchData_003Eb__96_1()
		{
		}

		internal void _003CCreateAIChatInGameSwitchData_003Eb__96_2()
		{
		}

		internal int _003CCreateAIChatInGameSwitchData_003Eb__96_0()
		{
			return 0;
		}

		internal void _003CCreateAIChatInUGCSwitchData_003Eb__97_1()
		{
		}

		internal void _003CCreateAIChatInUGCSwitchData_003Eb__97_2()
		{
		}

		internal int _003CCreateAIChatInUGCSwitchData_003Eb__97_0()
		{
			return 0;
		}
	}

	private sealed class _003CRefreshScroll_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInformationSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshScroll_003Ed__18(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private readonly List<int> m_Val10;

	private readonly List<int> m_Val01;

	private readonly List<string> m_Key;

	private UIInformationSettingView m_View;

	private Dictionary<int, UICommonSettingContentShortController> m_CtrlDict;

	private Dictionary<int, CommonSettingContentData> m_DataDict;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowDefaultCDN()
	{
	}

	public override void RefreshContent(object[] param)
	{
	}

	private void Start()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData()
	{
	}

	private void RefreshBtnsState()
	{
	}

	private IEnumerator RefreshScroll()
	{
		return null;
	}

	private CommonSettingContentData CreateNotificationBlockData()
	{
		return null;
	}

	private void ResetNotifactionToDefault()
	{
	}

	private InGameSettingItemDataToggleBtns CreateSafezoneModeData()
	{
		return null;
	}

	private void OnSafeZoneModeClick(int value)
	{
	}

	private int GetSafeZoneModeSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreateEnemyFireData()
	{
		return null;
	}

	private int GetEnemyFireSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreateAutoQuickMessage()
	{
		return null;
	}

	private CommonSettingItemDataBase CreateItemFinderModeData()
	{
		return null;
	}

	private int GetItemFindModeSelectBtn()
	{
		return 0;
	}

	private void OnItemFinderModeClick(int value)
	{
	}

	private InGameSettingItemDataToggleBtns CreateIngameEmojiData()
	{
		return null;
	}

	private void OnEmojiRecieveOn()
	{
	}

	private void OnEmojiRecieveOff()
	{
	}

	private int GetEmojiRecieveBtn()
	{
		return 0;
	}

	private CommonSettingContentData CreateScoreBlockData()
	{
		return null;
	}

	private void ResetScoreBlockToDefault()
	{
	}

	private InGameSettingItemDataToggleBtns CreateBrScoreBoardOpenModeData()
	{
		return null;
	}

	private void OnBrScoreBoardSettingClick(bool value)
	{
	}

	private void OnBrScoreBoardOpenModeClick(bool value)
	{
	}

	private int GetBrScoreBoardOpenModeBtn()
	{
		return 0;
	}

	private CommonSettingContentData CreateVisualBlockData()
	{
		return null;
	}

	private void ResetVisualBlockToDefault()
	{
	}

	private void ResetBotAgentToDefault()
	{
	}

	private void ResetBotAgentCSToDefault()
	{
	}

	private InGameSettingItemDataToggleBtns CreateCrossHairModeData()
	{
		return null;
	}

	private int GetCrossHairModeSelectBtn()
	{
		return 0;
	}

	private void OnCrossHairModeClick(int value)
	{
	}

	private InGameSettingItemDataToggleBtns CreateDamageSettingData()
	{
		return null;
	}

	private void OnDamageSettingClick(int value)
	{
	}

	private int GetDamageSettingSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreateDamageLabelTotalData()
	{
		return null;
	}

	private void OnDamageLabelTotalClick(bool open)
	{
	}

	private int GetDamageLabelTotalSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreateBloodModeData()
	{
		return null;
	}

	private void OnBloodModeClick(BloodType value)
	{
	}

	private int GetBloodModeSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreateHitHintData()
	{
		return null;
	}

	private void OnHitHintClassicClick(bool value)
	{
	}

	private int GetHitHintSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreateAutoQuickChatV2SettingData()
	{
		return null;
	}

	private int GetAutoQuickChatV2SelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreateToggleATKContainerData()
	{
		return null;
	}

	private void OnToggleATKContainerClick(bool value)
	{
	}

	private int GetToggleATKContainerSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreateToggleZoneContainerData()
	{
		return null;
	}

	private void OnToggleZoneContainerClick(bool value)
	{
	}

	private int GetToggleZoneContainerSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreatePlayerOutlineData()
	{
		return null;
	}

	private void OnShowPlayerOutlineClick(int value)
	{
	}

	private int GetShowPlayerOutlineSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreateTeamOutlineData()
	{
		return null;
	}

	private void OnShowTeamOutlineClick(int value)
	{
	}

	private int GetShowTeamOutlineSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreatePlayerStatsShowSPData()
	{
		return null;
	}

	private void OnPlayerStatsShowSPClick(int value)
	{
	}

	private int GetPlayerStatsShowSPSelectBtn()
	{
		return 0;
	}

	private InGameSettingItemDataToggleBtns CreateHint3DData()
	{
		return null;
	}

	private void OnShowHint3DClick(int value)
	{
	}

	private int GetShowHint3DSelectBtn()
	{
		return 0;
	}

	private CommonSettingContentData CreateBotAgentBlockData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentSwitchData()
	{
		return null;
	}

	private void OnBotAgentSwitchClick(bool show)
	{
	}

	private InGameSettingItemDataSlider CreateBotAgentVoiceVolumeData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentCatLootData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentCatOperationData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentCatFeedbackData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentCatGunHelperData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentCatSurviveTipData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentCSSwitchData()
	{
		return null;
	}

	private void OnBotAgentCSSwitchClick(bool show)
	{
	}

	private InGameSettingItemDataSlider CreateBotAgentCSVoiceVolumeData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentCSRuleData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentCSShopData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentCSBattleData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateBotAgentCSMapData()
	{
		return null;
	}

	private CommonSettingContentData CreateAIChatBlockData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateAIChatInGameSwitchData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateAIChatInUGCSwitchData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateCommonSettingToggleData(string CommonPrefKey, string leftLabelKey, List<int> valList, List<string> togglesKeyList, int defalutValue = 0, Action tipBtnClickCallBack = null, string newLabelPrefKey = null, Action OnCommonToggleChanged = null, uint subType = 0u)
	{
		return null;
	}

	private void ShowSettingTips(string contentStr)
	{
	}

	public override void ResetToDefault()
	{
	}

	private void ResetScrollViewWidth()
	{
	}

	private void _003CCreateSafezoneModeData_003Eb__21_0()
	{
	}

	private void _003CCreateSafezoneModeData_003Eb__21_1()
	{
	}

	private void _003CCreateItemFinderModeData_003Eb__27_0()
	{
	}

	private void _003CCreateItemFinderModeData_003Eb__27_1()
	{
	}

	private void _003CCreateItemFinderModeData_003Eb__27_2()
	{
	}

	private void _003CCreateBrScoreBoardOpenModeData_003Eb__36_0()
	{
	}

	private void _003CCreateBrScoreBoardOpenModeData_003Eb__36_1()
	{
	}

	private void _003CCreateBrScoreBoardOpenModeData_003Eb__36_2()
	{
	}

	private void _003CCreateCrossHairModeData_003Eb__44_0()
	{
	}

	private void _003CCreateCrossHairModeData_003Eb__44_1()
	{
	}

	private void _003CCreateDamageSettingData_003Eb__47_0()
	{
	}

	private void _003CCreateDamageSettingData_003Eb__47_1()
	{
	}

	private void _003CCreateDamageLabelTotalData_003Eb__50_0()
	{
	}

	private void _003CCreateDamageLabelTotalData_003Eb__50_1()
	{
	}

	private void _003CCreateBloodModeData_003Eb__53_0()
	{
	}

	private void _003CCreateBloodModeData_003Eb__53_1()
	{
	}

	private void _003CCreateBloodModeData_003Eb__53_2()
	{
	}

	private void _003CCreateHitHintData_003Eb__56_0()
	{
	}

	private void _003CCreateHitHintData_003Eb__56_1()
	{
	}

	private void _003CCreateToggleATKContainerData_003Eb__61_0()
	{
	}

	private void _003CCreateToggleATKContainerData_003Eb__61_1()
	{
	}

	private void _003CCreateToggleZoneContainerData_003Eb__64_0()
	{
	}

	private void _003CCreateToggleZoneContainerData_003Eb__64_1()
	{
	}

	private void _003CCreatePlayerOutlineData_003Eb__67_0()
	{
	}

	private void _003CCreatePlayerOutlineData_003Eb__67_1()
	{
	}

	private void _003CCreateTeamOutlineData_003Eb__70_0()
	{
	}

	private void _003CCreateTeamOutlineData_003Eb__70_1()
	{
	}

	private void _003CCreatePlayerStatsShowSPData_003Eb__73_0()
	{
	}

	private void _003CCreatePlayerStatsShowSPData_003Eb__73_1()
	{
	}

	private void _003CCreateHint3DData_003Eb__76_0()
	{
	}

	private void _003CCreateHint3DData_003Eb__76_1()
	{
	}

	private void _003CCreateBotAgentSwitchData_003Eb__80_1()
	{
	}

	private void _003CCreateBotAgentSwitchData_003Eb__80_2()
	{
	}

	private void _003CCreateBotAgentCSSwitchData_003Eb__88_1()
	{
	}

	private void _003CCreateBotAgentCSSwitchData_003Eb__88_2()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetToDefault()
	{
	}
}
