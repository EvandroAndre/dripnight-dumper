using System;
using System.Collections;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudUGCShareController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public byte[] pngBytes;

		public UIHudUGCShareController _003C_003E4__this;

		internal void _003COnSaveMapQRCode_003Eb__1(MediaMgr.MediaType media, MediaMgr.MediaAccessType access, MediaMgr.MediaAuthStatus auth, string error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_1
	{
		public string nativeId;

		public string saveError;

		public UIHudUGCShareController _003C_003E4__this;

		internal void _003COnSaveMapQRCode_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public UIHudUGCShareController _003C_003E4__this;

		public string name;

		internal void _003COnSearchBtnClick_003Eb__0()
		{
		}

		internal bool _003COnSearchBtnClick_003Eb__1(FriendAccountInfo a)
		{
			return false;
		}
	}

	private sealed class _003CCaptureNGUIWidget_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudUGCShareController _003C_003E4__this;

		public UIWidget widget;

		public Action<byte[]> callback;

		private Vector3 _003CoriginalLocalPosition_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCaptureNGUIWidget_003Ed__30(int _003C_003E1__state)
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

	protected UIHudUGCShareView m_View;

	private UIWorkshopMapItemController m_MapItemCtrl;

	private UIQRCodeController m_QRCodeCtrl;

	private List<UIWorkshopModeTagController> m_Tags;

	private UIUtils.ShareUrlType m_ShareUrlType;

	private UIModelShare m_ModelShare;

	private UIModelFriends m_ModelFriends;

	private UIModelSceneEdit m_ModelEidt;

	private UIModelQRCode m_ModelQRCode;

	private SceneEditSlotInfo m_Info;

	private UIUGCHotIndicatorController m_ShareHotCtrl;

	private string m_Code;

	private string m_LongCode;

	private bool m_HasSearch;

	private uint m_WinkCall;

	private List<FriendAccountInfo> m_CachedFriends;

	private bool m_HasLoadShareBg;

	public bool TriggerShareActivity;

	public string ShareCode => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetViewData(SceneEditSlotInfo info)
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

	private void CopyToClipBoard()
	{
	}

	private void OnSaveMapQRCode()
	{
	}

	private void OnSaveMapQRCodeDone(string nativeId, string saveError)
	{
	}

	public IEnumerator CaptureNGUIWidget(UIWidget widget, Action<byte[]> callback)
	{
		return null;
	}

	private void RefreshCDNMap()
	{
	}

	private bool NeedSkipTag(string tagKey)
	{
		return false;
	}

	private void RefreshTags(uint[] tagsInfo, uint[] limitTagsInfo)
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

	private void DoneShare(bool success)
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

	private void _003COnUIInit_003Eb__21_0()
	{
	}

	private void _003COnSaveMapQRCode_003Eb__28_0(byte[] pngBytes)
	{
	}

	private void _003COnSaveMapQRCode_003Eb__28_2(byte[] data, string nativeId, string saveError)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
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
