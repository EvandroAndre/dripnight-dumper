using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISceneEditUGCRankRewardLevelUpController : UIPopupWindowController
{
	private enum UIRewardState
	{
		None,
		LevelShow,
		ChestShow
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__13_0;

		internal CommonRewardItemInfo _003COnClickChest_003Eb__13_0(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003CAutoCrateChest_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISceneEditUGCRankRewardLevelUpController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoCrateChest_003Ed__9(int _003C_003E1__state)
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

	private sealed class _003COpenChestCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISceneEditUGCRankRewardLevelUpController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenChestCoroutine_003Ed__17(int _003C_003E1__state)
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

	private UIRewardState m_UIState;

	private UISceneEditUGCRankRewardLevelUpView m_View;

	private GameObject m_ModelChest;

	private List<WorkshopLevelReward> m_RewardInfoList;

	private Transform[] m_AwardGridArray;

	private List<UIStandardItemMAXBController> itemCtrlList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private IEnumerator AutoCrateChest()
	{
		return null;
	}

	protected override void OnUIDestroy()
	{
	}

	private void GoToNextStep()
	{
	}

	private void OnContinueClick()
	{
	}

	private void OnClickChest()
	{
	}

	private void OnClickRewardView()
	{
	}

	public void SetViewData(CSClaimWorkshopLevelRewardRes data, uint beforeLv, uint afterLv)
	{
	}

	private void CreateChest()
	{
	}

	private IEnumerator OpenChestCoroutine()
	{
		return null;
	}

	public void ShowChestReward()
	{
	}

	private void OnPlayRewardAudio(string audioName)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
