using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIDrawShopUnlimitedTokenTowerProgressItemController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CCompletedAnimationCoroutine_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDrawShopUnlimitedTokenTowerProgressItemController _003C_003E4__this;

		private float _003Celapsed_003E5__2;

		private Vector3 _003CoriginalScale_003E5__3;

		private Vector3 _003CtargetScale_003E5__4;

		private float _003ChalfDuration_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCompletedAnimationCoroutine_003Ed__65(int _003C_003E1__state)
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

	private sealed class _003CRedDotPulseCoroutine_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDrawShopUnlimitedTokenTowerProgressItemController _003C_003E4__this;

		private float _003Celapsed_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRedDotPulseCoroutine_003Ed__68(int _003C_003E1__state)
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

	private const float NORMAL_ITEM_SCALE = 1f;

	private const float RARE_ITEM_SCALE = 1.1f;

	private const float SHAKE_AMPLITUDE = 5f;

	private const float SHAKE_DURATION = 0.5f;

	private const float SHAKE_FREQUENCY = 10f;

	private const float COMPLETED_ANIM_SCALE = 1.2f;

	private const float ITEM_ICON_SCALE = 1.2f;

	private const float COMPLETED_ANIM_DURATION = 0.3f;

	private const float REDDOT_PULSE_MIN = 0.8f;

	private const float REDDOT_PULSE_MAX = 1f;

	private const float REDDOT_PULSE_DURATION = 0.5f;

	private DrawShopTowerRewardDesc m_RewardDesc;

	private uint m_ChestId;

	private uint m_CdtValue;

	private bool m_IsCompleted;

	private bool m_IsClaimed;

	private bool m_IsClaimable;

	private bool m_IsRareReward;

	private int m_ProgressBarIndex;

	private UIModelDrawShop m_ModelDrawShop;

	private BaseItemInfo m_ItemInfo;

	protected UIDrawShopUnlimitedCardPoolItemView m_View;

	private Coroutine m_ShakeCoroutine;

	private Coroutine m_RedDotPulseCoroutine;

	private Coroutine m_CompletedAnimCoroutine;

	private Vector3 m_OriginalLocalPosition;

	private Vector3 m_OriginalLocalScale;

	private Action<int, DrawShopTowerRewardDesc> m_ClickCallback;

	private GameObject m_CompletedVFX;

	private GameObject m_RareRewardVFX;

	private GameObject m_ClaimableVFX;

	private bool m_IsPendingClaim;

	public bool IsClaimable => false;

	public bool IsClaimed => false;

	public bool IsRareReward => false;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetItemIndex(int index)
	{
	}

	public void SetClickCallback(Action<int, DrawShopTowerRewardDesc> callback)
	{
	}

	public void SetViewData(DrawShopTowerRewardDesc rewardDesc, uint chestId)
	{
	}

	private void RefreshMaxState()
	{
	}

	private void RefreshBigRewardState()
	{
	}

	private void RefreshRedDotState()
	{
	}

	protected virtual void RefreshQualityBG(uint quality)
	{
	}

	private void RefreshItemSelectedState(bool isSelected)
	{
	}

	public void UpdateProgressState(bool isCompleted)
	{
	}

	public void SetClaimableState(bool isClaimable, bool isClaimed)
	{
	}

	public void PlayShakeAnimation()
	{
	}

	public void StopShakeAnimation()
	{
	}

	public void PlayCompletedAnimation()
	{
	}

	public void HideRareRewardVfx()
	{
	}

	private void RefreshItemShow()
	{
	}

	protected virtual BaseItemInfo CreateBaseItemInfo(DrawShopTowerRewardDesc rewardDesc)
	{
		return null;
	}

	private void RefreshItemScale()
	{
	}

	private void RefreshClaimableState()
	{
	}

	private void RefreshProgressState()
	{
	}

	private void OnAwardBtnClick()
	{
	}

	private void ClaimTowerReward()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnTowerRewardClaimed()
	{
	}

	private IEnumerator CompletedAnimationCoroutine()
	{
		return null;
	}

	private void StartRedDotPulse()
	{
	}

	private void StopRedDotPulse()
	{
	}

	private IEnumerator RedDotPulseCoroutine()
	{
		return null;
	}

	private void ShowCompletedVFX()
	{
	}

	private void ShowRareRewardVFX()
	{
	}

	private void ShowClaimableVFX()
	{
	}

	private void HideClaimableVFX()
	{
	}

	private void ClearVFX()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
