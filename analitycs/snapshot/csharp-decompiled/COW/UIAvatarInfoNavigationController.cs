using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIAvatarInfoNavigationController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<AvatarSuit> _003C_003E9__33_0;

		public static Predicate<Item> _003C_003E9__41_0;

		internal bool _003CRefreshPreviewAvatar_003Eb__33_0(AvatarSuit x)
		{
			return false;
		}

		internal bool _003CRefreshExpireTime_003Eb__41_0(Item temp)
		{
			return false;
		}
	}

	private sealed class _003CDelayCreatAvatarInfoLeft_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarInfoNavigationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCreatAvatarInfoLeft_003Ed__32(int _003C_003E1__state)
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

	private UIModelEvoPass m_ModelEvoPass;

	private Vector3 AvatarModelPosOnExpand;

	private Vector3 AvatarModelPosOnShrink;

	private Vector3 PresetAgentPosOnExpand;

	private Vector3 PresetAgentPosOnShrink;

	private UIPresetAgentController m_PresetAgentCtrl;

	private uint m_CurrentShowAvatarID;

	private uint m_LastSelectAvatarID;

	public const string FIRST_CHARA_KEY = "HAS_SEEN_CHARACTER";

	private uint m_PlayVoiceDelayCall;

	private UIAvatarInfoNavigationView m_View;

	private UIAvatarInfoLeftController m_AvatarInfoLeftCtrl;

	private UIAvatarInfoRightController m_AvatarInfoRightCtrl;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelLoadout m_ModelLoadout;

	private TweenPosition m_TweenPosition;

	private Coroutine DelayCreatAvatarInfoLeftCor;

	private bool m_IsLeftExtend => false;

	public uint GetCurrentShowAvatar => 0u;

	public uint GetLastSelectAvatar => 0u;

	private UIAvatarInfoLeftController AvatarInfoLeftCtrl => null;

	private UIAvatarInfoRightController AvatarInfoRightCtrl => null;

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

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void UrgentCreateAvatarInfoLeft()
	{
	}

	private IEnumerator DelayCreatAvatarInfoLeft()
	{
		return null;
	}

	private void RefreshPreviewAvatar(object[] param)
	{
	}

	private void RefreshPresetAgent()
	{
	}

	private void RefreshPresetAgentPos()
	{
	}

	private void UpdateAvatarPos()
	{
	}

	public void UpdateAvatarSkinColor(float value)
	{
	}

	public void LeftFolderBtnClicked(bool isExtend)
	{
	}

	private void OnOriginalOrAwakenAvatarSwitch(object[] data)
	{
	}

	private void OnSwitchShowAvatar(uint newCurShowAvatarID)
	{
	}

	private void RefreshExpireTime()
	{
	}

	private void RefreshEvopassTip()
	{
	}

	private void OnEvoPassTipClick()
	{
	}

	private void OnAvatarEquip(object[] param)
	{
	}

	private void OnAvatarSelect(object[] param)
	{
	}

	private void OnVaultBtnClick()
	{
	}

	private void RefreshAvatarInfoNavi(bool forceRefreshLeft = false, bool forceRefreshRight = false)
	{
	}

	private void UploadAvatarSkinColor()
	{
	}

	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	public override void OnNavigationClosed()
	{
	}

	public void SendSelectedMsg()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
