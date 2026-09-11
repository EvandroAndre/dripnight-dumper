using System;
using System.Collections;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentSquadTreasureShareController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private enum PendingShareType
	{
		None,
		Line,
		WhatsApp,
		Instagram,
		BindInvite,
		Other
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TopUpMember> _003C_003E9__42_0;

		public static Action<HttpErrorCode, object> _003C_003E9__51_0;

		internal int _003CRefreshTeamInfo_003Eb__42_0(TopUpMember a, TopUpMember b)
		{
			return 0;
		}

		internal void _003CSendShareEvent_003Eb__51_0(HttpErrorCode errCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public byte[] pngBytes;

		public UIPaymentSquadTreasureShareController _003C_003E4__this;

		public Action<byte[], string, string> _003C_003E9__1;

		internal void _003CSaveToAlbum_003Eb__0(MediaMgr.MediaType media, MediaMgr.MediaAccessType access, MediaMgr.MediaAuthStatus auth, string error)
		{
		}

		internal void _003CSaveToAlbum_003Eb__1(byte[] data, string nativeId, string saveError)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_1
	{
		public string nativeId;

		public string saveError;

		public _003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals1;

		internal void _003CSaveToAlbum_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public bool isTitleDownloaded;

		public UIPaymentSquadTreasureShareController _003C_003E4__this;

		public bool isShareDownloaded;

		internal void _003CRefreshTeamInfo_003Eb__0()
		{
		}

		internal void _003CRefreshTeamInfo_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public UIPaymentSquadTreasureShareController _003C_003E4__this;

		public string name;

		internal void _003COnSearchBtnClick_003Eb__0()
		{
		}

		internal bool _003COnSearchBtnClick_003Eb__1(FriendAccountInfo a)
		{
			return false;
		}
	}

	private sealed class _003CCaptureNGUIWidget_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPaymentSquadTreasureShareController _003C_003E4__this;

		public UIWidget widget;

		public Action<byte[]> callback;

		private Vector3 _003CoriginalLocalPosition_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCaptureNGUIWidget_003Ed__38(int _003C_003E1__state)
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

	private UIPaymentSquadTreasureShareView m_View;

	private UIQRCodeController m_QRCodeCtrl;

	private UIUtils.ShareUrlType m_ShareUrlType;

	private UIModelShare m_ModelShare;

	private UIModelFriends m_ModelFriends;

	private UIModelQRCode m_ModelQRCode;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private TopUpTeam m_Info;

	private string m_Code;

	private bool m_HasSearch;

	private uint m_WinkCall;

	private List<FriendAccountInfo> m_CachedFriends;

	private List<object> m_CachedShareInfos;

	public bool TriggerShareActivity;

	private ulong m_GroupId;

	private uint m_SettingSquadNumber;

	private bool m_HasLoadShareBg;

	private List<UIPaymentSquadTreasureTeammateItemController> m_MemberItemList;

	private PendingShareType m_PendingShareType;

	private bool m_Shared;

	public string ShareCode => null;

	public ulong GroupId => 0uL;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(TopUpTeam info)
	{
	}

	private void CheckAndRequestInTeamAccountIds()
	{
	}

	private void RefreshShareInfoList()
	{
	}

	private void CopyToClipBoard()
	{
	}

	private void OnSaveMapQRCode()
	{
	}

	private void SaveToAlbum(byte[] pngBytes)
	{
	}

	private void ShareToPlatform(byte[] pngBytes)
	{
	}

	private void OnSaveMapQRCodeDone(string nativeId, string saveError)
	{
	}

	public IEnumerator CaptureNGUIWidget(UIWidget widget, Action<byte[]> callback)
	{
		return null;
	}

	private void RefreshTeamInfo()
	{
	}

	private void RefreshTeamStateView()
	{
	}

	private void InitTeammateItem(uint teammateNum)
	{
	}

	private void RefreshTeamInfo(TopUpTeam topUpTeam)
	{
	}

	private void OnShareClick(PendingShareType type)
	{
	}

	private void OnLineClick()
	{
	}

	private void OnWhatsAppClick()
	{
	}

	private void OnInstagramClick()
	{
	}

	private void OnBindInviteClick()
	{
	}

	private void OnOtherClick()
	{
	}

	private void OnCopyLink()
	{
	}

	private void DoneShare(bool success, EventLogger.SharePlatform sharePlatform)
	{
	}

	private void SendShareEvent()
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnSearchInputChange()
	{
	}

	private void ResetSearchInput()
	{
	}

	private void OnSearchInputGetFocus()
	{
	}

	private void RefreshFriendState()
	{
	}

	private List<object> GetShareChannelInfos()
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void ShareBindInviteWithPlatformType(ShareSettingDesc share)
	{
	}

	private void _003COnUIInit_003Eb__26_0()
	{
	}

	private void _003COnUIInit_003Eb__26_1()
	{
	}

	private void _003COnUIInit_003Eb__26_2()
	{
	}

	private void _003COnUIInit_003Eb__26_3()
	{
	}

	private void _003COnUIInit_003Eb__26_4()
	{
	}

	private void _003COnSaveMapQRCode_003Eb__34_0(byte[] pngBytes)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
