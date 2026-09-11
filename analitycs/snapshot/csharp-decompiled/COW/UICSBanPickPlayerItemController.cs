using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UICSBanPickPlayerItemController : UIBaseController
{
	private UICSBanPickPlayerItemView m_View;

	private ECSBPPhase m_BPStatus;

	private ulong m_PlayerID;

	private uint m_SkillID;

	private ulong m_TeamID;

	private bool m_IsSelf;

	private bool m_IsObserver;

	private bool m_IsSameTeam;

	private bool m_IsChoosing;

	private bool m_IsLocked;

	private bool m_IsNextPick;

	private int m_PlayerIndex;

	private bool m_IsPreSelect;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private List<UICSBanPickPassiveSkillItemController> m_PassiveSkillItemList;

	private float m_ChatBubbleTime;

	private float m_ChangeSkillCoolDownTime;

	protected uint m_DelayHideBubbleID;

	protected uint m_DelayAnswerExchangeSkillID;

	protected uint m_DelayHelpPickAnswerID;

	private float m_AnswerExchangeSkillTimeEnd;

	private List<uint> m_PassiveSkillIDList;

	private uint m_PetID;

	private uint m_LoadoutID;

	private UIModelBanPick m_ModelBanPick;

	private RoomPlayerInfo m_OriginalPlayerInfo;

	private CSBPContext m_Context;

	private ulong m_RequestHelpPickPlayerId;

	private ulong m_RequestExchangeSkillPlayerId;

	protected uint m_DelayRefreshOrderTimeID;

	private List<uint> m_AvailableSkills;

	private Color m_OriginalSkillIconColor;

	private bool m_PlayedLockVfx;

	private static Color m_BlueTeamSelectColor;

	private static Color m_SelfSelectColor;

	private uint m_RequestBanSkillID;

	private const string ORDER_TIME_NORMAL_ANIMATION = "UIFX_UICSBanPickPlayerItemRightEnemy_loop";

	private const string ORDER_TIME_COUNTDOWN_ANIMATION = "UIFX_UICSBanPickPlayerItemRightEnemy_play";

	private bool m_PlayedOrderTimeAnimation;

	public ulong PlayerID => 0uL;

	public uint SkillID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void ResetBGUI()
	{
	}

	public void ChangeBPStatus(ECSBPPhase status)
	{
	}

	public void SetRoomPlayerInfo(RoomPlayerInfo playerInfo, int playerIndex)
	{
	}

	public void SetChoosing(bool isChoosing)
	{
	}

	public void SetLocked(bool isLocked)
	{
	}

	public void SetNextPick(bool isNextPick)
	{
	}

	public void SetIsPreSelect(bool isPreSelect)
	{
	}

	public void SetIsSpeaking(bool isSpeaking)
	{
	}

	private void OnBPVoiceVadStateChange(object[] data)
	{
	}

	public void RefreshBGUI()
	{
	}

	private void RefreshOrderTime()
	{
	}

	private void RefreshPreSelectUI()
	{
	}

	public void SetPlayerInfo(ulong playerID, ulong teamID, bool isSelf, bool isObserver, bool isSameTeam, string playerName, int playerIndex)
	{
	}

	public string GetPlayerName()
	{
		return null;
	}

	public void SetPlayerName(string playerName)
	{
	}

	public void SetSkillInfo(uint skillID)
	{
	}

	public void RefreshPassiveSkillInfo(List<uint> skillIDList, uint petID, uint loadoutID)
	{
	}

	public void RefreshPassiveSkillData()
	{
	}

	public void SetPassiveSkillInfo(List<uint> skillIDList, uint PetId = 0u, uint LoadouId = 0u)
	{
	}

	public void SetChatBubble(string chatText)
	{
	}

	public void ChangePickRequest(bool showRequest)
	{
	}

	public void ChangePickAnswer(bool showAnswer, ulong requestPlayerId)
	{
	}

	public void OnRefuseHelpPick()
	{
	}

	public void OnAcceptHelpPick()
	{
	}

	public void ShowChangeSkillButton(bool showButton)
	{
	}

	public void RefrseshChangeSkillStatus(ulong requesterId, ulong answerId)
	{
	}

	public void InitChangeSkillStatus()
	{
	}

	private bool IsCoatinSkill(List<uint> skillIDList, uint selectSkillID)
	{
		return false;
	}

	public void ShowExchangeSkillCountDown(ulong answerCd)
	{
	}

	public void RefreshRequestPlayerChangeSkillStatus(ulong requestPlayerId, ulong answerPlayerId, uint targetSkillID, uint requestSkillID)
	{
	}

	private void OnClickChangeSkill()
	{
	}

	public void ShowRequestChangeSkillPanel(uint skillID, ulong RequestplayerID, ulong AnswerplayerID)
	{
	}

	public void ExchangeSkillBubbleOepn(uint skillID, ulong RequestplayerID, ulong AnswerplayerID, ulong answerCd)
	{
	}

	public void TeammateRequestChangeSkill(uint skillID, ulong RequestplayerID, ulong AnswerplayerID, ulong answerCd)
	{
	}

	public void OnOtherExchangeSkill()
	{
	}

	private void ShowExchangeSkillIcon(uint skillID)
	{
	}

	public void CloseExchangeSkillPanel()
	{
	}

	public void CloseAllExchangeSkillButton()
	{
	}

	public void CloseAllHelpPickButton()
	{
	}

	private void OnClickAgreeExchangeSkill()
	{
	}

	private void OnClickRefuseExchangeSkill()
	{
	}

	public void ShowRequestBanButton(uint skillID, bool showButton)
	{
	}

	public void HideRequestBanButton()
	{
	}

	private void OnClickHelpBan()
	{
	}

	private void _003CSetChatBubble_003Eb__65_0()
	{
	}

	private void _003CShowExchangeSkillCountDown_003Eb__74_0()
	{
	}

	private void _003CTeammateRequestChangeSkill_003Eb__79_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
