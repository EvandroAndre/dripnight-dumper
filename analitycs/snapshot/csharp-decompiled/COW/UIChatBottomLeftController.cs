using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIChatBottomLeftController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CCoCheckHintLabelScroll_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIChatBottomLeftController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoCheckHintLabelScroll_003Ed__38(int _003C_003E1__state)
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

	public const int BOTTOM_LEFT_PANEL_DEPTH_OFFSET = 2;

	private UIChatBottomLeftView m_View;

	private UIModelChat m_ModelChat;

	private UIModelAntiAddiction m_ModelAntiAddiction;

	private UIModelGroup m_ModelGroup;

	protected UICountDownController m_MutedCDCtrl;

	private UIChatFastMessagePanelController m_FastMessagePanelCtrl;

	private UIChatStickerController m_StickerController;

	private Vector3 m_NewMessageNodeOrgPos;

	private const int NEW_MESSAGE_NODE_OFFSET_Y = 90;

	private Coroutine m_CheckHintScrollCo;

	private HashSet<string> m_SloganSet;

	private List<string> m_SloganKeys;

	private string m_SloganKey;

	private UIBaseChatController m_ParentCtrl;

	private bool m_HasFirstShowFastMessagePanel;

	private ChatChannelInfo m_CurShowChannel;

	private UICountDownController m_SlienceCDCtrl;

	private UIBaseChatController ParentCtrl => null;

	public ChatChannelInfo CurShowChannel => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	private void RefreshSilenceView()
	{
	}

	private void OnEnterBtnClick()
	{
	}

	private void OnNewMessageBtnClick()
	{
	}

	private void OnOpenStickerBtnClick()
	{
	}

	private void OnMutedHintBtnClick()
	{
	}

	private void OnSpeakerClick()
	{
	}

	private void OnFastMessageClick()
	{
	}

	private void OnSloganBubbleBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void RefreshContentNode()
	{
	}

	private void RefreshAntiAddictionBRView()
	{
	}

	private void DeferCheckHintLabelScroll()
	{
	}

	private IEnumerator CoCheckHintLabelScroll()
	{
		return null;
	}

	private bool CheckCanChatWithWhisperTarget(ulong targetAccountId, ref ChatRestrictionReason restrictionReason)
	{
		return false;
	}

	private bool CheckGroupMemberHasOneCannotChatWith(ref ChatRestrictionReason restrictionReason, ref ulong restrictedMemberAccountId)
	{
		return false;
	}

	private string GetBRChatRestrictionText(ChatRestrictionReason reason, ulong otherAccountId)
	{
		return null;
	}

	private string GetBRChatRestrictionHintText(ChatRestrictionReason reason, ulong otherAccountId)
	{
		return null;
	}

	private string GetWhisperTargetNickname(ulong accountId)
	{
		return null;
	}

	private string GetGroupMemberNickname(ulong accountId)
	{
		return null;
	}

	private char OnInputValidate(string text, int charIndex, char addedChar)
	{
		return '\0';
	}

	public void SetNewMessageBtnVisible(bool v)
	{
	}

	private void CheckAndHideNewMessageTip()
	{
	}

	private void SetIngameHintState()
	{
	}

	public void RefreshSpeakerNum()
	{
	}

	public void RefreshInputContainer(string input)
	{
	}

	public void RefreshInputContainerDefaultText(string defaultText)
	{
	}

	private void SetSloganBubble()
	{
	}

	private string RandomSlogan()
	{
		return null;
	}

	private void RefreshSlogan()
	{
	}

	private void DisposeMessage()
	{
	}

	private bool CheckMessageInSlogan(string message)
	{
		return false;
	}

	public void UpdatePanelDepth(int depth)
	{
	}

	public void SetChannel(ChatChannelInfo chatChannelInfo)
	{
	}

	public void ShowFastMessage(bool resetFirstShow = false)
	{
	}

	private void OpenFastMessagePanel()
	{
	}

	private void LateUpdate()
	{
	}

	private void _003CRefreshSilenceView_003Eb__25_0()
	{
	}

	private void _003CRefreshContentNode_003Eb__35_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
