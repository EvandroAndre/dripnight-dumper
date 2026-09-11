using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassEXPShareController : UIBaseController, IEasyList, IUIModelDataChangeObserver, IGuideQueueContainer
{
	public enum ESendOrClaimBtnState
	{
		None,
		Claim,
		Send
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public ulong item;

		internal bool _003CShowExpShareItemClaimVfx_003Eb__0(BooyahPassShareExpData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_1
	{
		public int idIndex;

		public UIBooyahPassEXPShareItemController itemCtrl;

		public BooyahPassShareExpData tmpItem;

		internal void _003CShowExpShareItemClaimVfx_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public ulong accountID;

		public int index;

		internal bool _003CRefreshUIAfterSend_003Eb__0(BooyahPassShareExpData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_1
	{
		public UIBooyahPassEXPShareItemController itemCtrl;

		public BooyahPassShareExpData tmpItem;

		public _003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals1;

		internal void _003CRefreshUIAfterSend_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public ulong item;

		internal bool _003CPlayFlyAndShiningVfx_003Eb__0(BooyahPassShareExpData x)
		{
			return false;
		}
	}

	private sealed class _003CPlayFlyAndShiningVfx_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPassEXPShareController _003C_003E4__this;

		public bool needRefreshEasyList;

		public List<ulong> realSendPlayerList;

		private float _003Cduration_003E5__2;

		private List<UIBooyahPassEXPShareItemController> _003CshareItemCtrlList_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayFlyAndShiningVfx_003Ed__41(int _003C_003E1__state)
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

	private sealed class _003CPlaySendVfx_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPassEXPShareController _003C_003E4__this;

		public bool needRefreshEasyList;

		public Action sendAction;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlaySendVfx_003Ed__40(int _003C_003E1__state)
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

	private UIModelBooyahPass m_ModelBooyahPass;

	private UIBooyahPassEXPShareView m_View;

	private GuideQueue m_GuideQueue;

	private List<BooyahPassShareExpData> m_palyerInfoList;

	private List<Action> m_ItemShareCtrlRefreshUIAction;

	private Coroutine m_PlayClaimVfxCoroutine;

	private Coroutine m_PlaySendVfxCoroutine;

	private float m_ClaimVfxTime;

	private float m_SendVfxTime;

	private float m_GainLabelVfxTime;

	private ESendOrClaimBtnState m_BtnState;

	private const string GUIDE_EXPSHARE_STEP1_KEY = "BooyahPassExpShare_Step1_Account{0}";

	private const string GUIDE_EXPSHARE_STEP2_KEY = "BooyahPassExpShare_Step2_Account{0}";

	private static string GAINED_EXP_KEY;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnCloseBntClick()
	{
	}

	private void OnMaskClick()
	{
	}

	private void OnRuleClick()
	{
	}

	private void OnLeaderBoardBtnClick()
	{
	}

	private void OnAddFriendBtnClick()
	{
	}

	private void OnAllClaimBtnClick()
	{
	}

	private void SetupDefaultStateOnInit()
	{
	}

	public void RefreshView()
	{
	}

	public void RefreshEasyList()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void SetGainLabel()
	{
	}

	private void RefreshClaimOrSendBtn()
	{
	}

	private void RefreshUIStateByFriend()
	{
	}

	private void SetGainLabelVfxTime()
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private void Update()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private bool ShowExpShareItemClaimVfx(List<ulong> claimExpPlayerList)
	{
		return false;
	}

	private void RefreshUIAfterClaim(List<ulong> claimExpPlayerList, bool needRefreshEasyList, List<ulong> realSendPlayerList = null)
	{
	}

	private void RefreshUIAfterSend(ulong accountID, bool needRefreshEasyList)
	{
	}

	private IEnumerator PlaySendVfx(Action sendAction, bool needRefreshEasyList)
	{
		return null;
	}

	private IEnumerator PlayFlyAndShiningVfx(bool needRefreshEasyList, List<ulong> realSendPlayerList)
	{
		return null;
	}

	private void RefreshShareItemUI()
	{
	}

	public GameObject GetGuideMask()
	{
		return null;
	}

	public UICommonGuideController OpenGuideController(string stepKey)
	{
		return null;
	}

	public bool IsAvailable()
	{
		return false;
	}

	public bool IsStepAvailable(string stepKey, out UIWidget targetWidget, out UIButton finishButton)
	{
		targetWidget = null;
		finishButton = null;
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
