using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarAwakenController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__23_0;

		internal void _003CRefreshTaskConfirm_003Eb__23_0()
		{
		}
	}

	private sealed class _003CShowComicProgressAnim_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarAwakenController _003C_003E4__this;

		private float _003CanimationTime_003E5__2;

		private float _003ColdValue_003E5__3;

		private float _003CnewValue_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowComicProgressAnim_003Ed__48(int _003C_003E1__state)
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

	private sealed class _003CShowUnlockComicEffect_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarAwakenController _003C_003E4__this;

		public uint unlockNum;

		private int _003CCurShowIndex_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowUnlockComicEffect_003Ed__47(int _003C_003E1__state)
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

	private sealed class _003CWaitForAnimationFinish_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float animationTime;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForAnimationFinish_003Ed__49(int _003C_003E1__state)
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

	private UIAvatarAwakenView m_View;

	private UIModelAvatarProfile m_Model;

	private AvatarProfile m_CurrentShowAvatar;

	private List<UIAvatarAwakenTaskItemController> m_CacheTaskItemList;

	private List<UIAvatarAwakenStoryItemController> m_CacheStoryItemList;

	private List<GameObject> m_TaskPosList;

	private List<GameObject> m_TaskEffectList;

	private List<GameObject> m_ComicEffectList;

	private List<GameObject> m_ComicCanUnlockEffectList;

	private List<GameObject> m_ComicUnlockEffectList;

	private int ComicCntMax;

	private int m_CurrentIndex;

	private uint m_CurrentFinishTaskID;

	private bool m_IsNewAwaken;

	private bool m_IsNeedGuideShow;

	private IEnumerator m_CurrentAnim;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnShowAwardTips()
	{
	}

	private void OnMoveToNextComic()
	{
	}

	private void OnMoveToLastComic()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RefreshTaskConfirm()
	{
	}

	public void SetAvatar(uint curAvatarID, bool isNewAwaken)
	{
	}

	private void SetCDNList()
	{
	}

	private void InitStoryList()
	{
	}

	private void MoveIndexCount(int moveCnt)
	{
	}

	private void RefreshStoryList()
	{
	}

	private void ShowCurrentComicEffect()
	{
	}

	private void RefreshFinishProgress()
	{
	}

	private void RefreshAwakenBtnState()
	{
	}

	private void RefreshTaskResetBtnState()
	{
	}

	private void InitUI()
	{
	}

	private void SetDescription()
	{
	}

	private void RefreshUI()
	{
	}

	private void CheckLockState()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnGainAvatarBtnClick()
	{
	}

	private void OnAwakenDisableBtnClick()
	{
	}

	private void OnClaimAwakenAvatarBtnClick()
	{
	}

	private void RefreshTaskList()
	{
	}

	private int SortItem(AvatarAwakenComicData a, AvatarAwakenComicData b)
	{
		return 0;
	}

	private void OnAwakenRewardClaim(object[] data)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private IEnumerator ShowUnlockComicEffect(uint unlockNum)
	{
		return null;
	}

	private IEnumerator ShowComicProgressAnim()
	{
		return null;
	}

	private IEnumerator WaitForAnimationFinish(float animationTime)
	{
		return null;
	}

	private void ShowTaskClaimEffect()
	{
	}

	private void ShowUnlockOnceEffect(uint unlockNum)
	{
	}

	private void ShowComicClaimEffect(uint unlockNum)
	{
	}

	private void _003COnClaimAwakenAvatarBtnClick_003Eb__41_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
