using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIRelayMartDiscountCodeManagerPopupWindowController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RelayMartDiscountCodeInfo, uint> _003C_003E9__18_1;

		internal uint _003CSetUIData_003Eb__18_1(RelayMartDiscountCodeInfo x)
		{
			return 0u;
		}
	}

	private sealed class _003CRollToTargetDiamondSumCoroutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRelayMartDiscountCodeManagerPopupWindowController _003C_003E4__this;

		public uint targetDiamondSum;

		private uint _003CstartValue_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRollToTargetDiamondSumCoroutine_003Ed__26(int _003C_003E1__state)
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

	private UIRelayMartDiscountCodeManagerPopupWindowView m_View;

	private UIModelRelayMart m_ModelRelayMart;

	private List<RelayMartDiscountCodeInfo> m_DiscountCodeList;

	private List<RelayMartDiscountCodeInfo> m_SortedDiscountCodeList;

	private Coroutine m_DiamondSumRollCoroutine;

	private uint m_CurrentDisplayedDiamondSum;

	private uint m_PublicTipDelayCallID;

	private int m_CurrentBubbleIndex;

	private int m_LastDismissedBubbleIndex;

	private int m_TipTargetIndex;

	private ulong m_SelfId;

	private const float FINAL_LERP_TIME = 0.3f;

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

	protected override void OnUIDestroy()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] data)
	{
	}

	private void SetUIData()
	{
	}

	private void OnRewardWndClose()
	{
	}

	private void RefreshRelayMartRebateInfo()
	{
	}

	private int GetDiscountCodeSortPriority(RelayMartDiscountCodeInfo codeInfo)
	{
		return 0;
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnClaimAllBtnClick()
	{
	}

	private void OnRuleIconClick()
	{
	}

	private void RollToTargetDiamondSum(uint targetDiamondSum)
	{
	}

	private IEnumerator RollToTargetDiamondSumCoroutine(uint targetDiamondSum)
	{
		return null;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void RegisterScrollEvents()
	{
	}

	private void UnregisterScrollEvents()
	{
	}

	private void OnScrollChanged()
	{
	}

	private void CheckAndShowPublicTip()
	{
	}

	private int FindFirstUnpublishedIndex()
	{
		return 0;
	}

	private void ShowPublicTip(int index)
	{
	}

	private void HidePublicTip()
	{
	}

	private void ClearPublicTipDelayCall()
	{
	}

	private void _003COnUIInit_003Eb__13_0(object[] data)
	{
	}

	private int _003CSetUIData_003Eb__18_0(RelayMartDiscountCodeInfo x)
	{
		return 0;
	}

	private void _003CShowPublicTip_003Eb__34_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
