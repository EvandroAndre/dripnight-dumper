using System;
using System.Collections.Generic;
using System.Text;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIChatController : UIBaseChatController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<ChatChannelInfo> _003C_003E9__28_1;

		internal bool _003CGotoChannel_003Eb__28_1(ChatChannelInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public EChannel.ChannelType type;

		internal bool _003CGotoChannel_003Eb__0(ChatChannelInfo x)
		{
			return false;
		}
	}

	private UIChatView m_View;

	private List<ChatChannelInfo> m_ShowChannelList;

	private uint m_WorldCDCallID;

	private StringBuilder m_WorldCDText;

	private Dictionary<int, UIChatBaseContainerController> m_ChannelType2Container;

	private ulong m_StartShowTime;

	private uint m_BubbleVFXDelayCallId;

	private ulong m_LastWorldVFXPlayTs;

	private ParticleSystem[] SloganVFXs;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelUser m_ModelUser;

	public ulong StartShowTime
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void AfterInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public int GetMessageListDepth()
	{
		return 0;
	}

	public float GetMessageListPanelWidth()
	{
		return 0f;
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override ChatChannelInfo GetCurShowChannel()
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnChatDataChanged(uint propID, object[] param)
	{
	}

	private void RefreshChannelList()
	{
	}

	public override void RefreshContentNode()
	{
	}

	private UIChatBaseContainerController GetOrCreateContainerCtrl(EChannel.ChannelType m_ChannelType)
	{
		return null;
	}

	public void GotoChannel(EChannel.ChannelType type, ulong roomid = 0uL, bool forceToFriendTab = true)
	{
	}

	private void OnSwitchChannel(object[] data)
	{
	}

	private UIChatBaseContainerController GetContainerCtrl(EChannel.ChannelType m_ChannelType)
	{
		return null;
	}

	public UIChatBaseContainerController GetCurContainerCtrl()
	{
		return null;
	}

	private void OnBaseProfileUpdate(object[] data)
	{
	}

	protected override uint GetChatInterestedPropID()
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void AfterSendSuccess()
	{
	}

	private bool IsLikeWorldChannel(EChannel.ChannelType type)
	{
		return false;
	}

	private ulong GetCurrentChannelLastSendTs()
	{
		return 0uL;
	}

	private bool IsCurrentChannelInCD()
	{
		return false;
	}

	private void StopInputCDTick()
	{
	}

	private void ApplyInputDefaultText()
	{
	}

	private void RefreshCurrentChannelInputState()
	{
	}

	private void RefreshDefaultInputValue()
	{
	}

	private void ResetDefaultInputValue()
	{
	}

	private bool CanShowClanChannel()
	{
		return false;
	}

	private void PlayAllVFX()
	{
	}

	public void PlayBubbleVFX(bool isImmediately)
	{
	}

	private void ChangeActivityInfoState(uint id)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public ChatChannelInfo _003C_003EiFixBaseProxy_GetCurShowChannel()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnChatDataChanged(uint P0, object[] P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContentNode()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetChatInterestedPropID()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_AfterSendSuccess()
	{
	}
}
