using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINewPlayerV3ExploreCampController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CHandleTaskItemsOnTabSelect_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool needShowDisappearAnim;

		public UINewPlayerV3ExploreCampController _003C_003E4__this;

		private List<UINewPlayerV3ExploreCampTaskItemController>.Enumerator _003C_003E7__wrap1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHandleTaskItemsOnTabSelect_003Ed__29(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CPlayTaskItemAppearAnim_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINewPlayerV3ExploreCampController _003C_003E4__this;

		private List<UINewPlayerV3ExploreCampTaskItemController>.Enumerator _003C_003E7__wrap1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayTaskItemAppearAnim_003Ed__32(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const string TIP_TEXT = "T_49_MF_EXPLORE_QUESTION";

	private const string PROGRESS_TEXT = "T_49_MF_EXPLORE_UNLOCK";

	private const float TASK_ITEM_ANIM_INTERVAL = 0.1f;

	private UINewPlayerV3ExploreCampView m_View;

	private UIModelNewPlayerV3 m_ModelNewPlayerV3;

	private bool m_HasFinishedInit;

	private Coroutine m_HandleTaskItemsCoroutine;

	private uint m_CurSectionID;

	private List<uint> m_SectionIDList;

	private List<UINewPlayerV3ExploreCampTaskTabController> m_TabList;

	private List<GameObject> m_BarFourList;

	private List<GameObject> m_BarFiveList;

	private UIStandardItemMiniController m_RewardItem;

	private List<Transform> m_TaskItemParentList;

	private List<UINewPlayerV3ExploreCampTaskItemController> m_TaskItemControllerList;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void InitView()
	{
	}

	public void SelectNewestUnlockSection()
	{
	}

	private void InitTab()
	{
	}

	public void RefreshTab()
	{
	}

	public void OnTabClick(int clickTabIndex)
	{
	}

	public void InitTaskItems()
	{
	}

	public void RefreshTaskItems()
	{
	}

	public IEnumerator HandleTaskItemsOnTabSelect(bool needShowDisappearAnim = true)
	{
		return null;
	}

	public float GetTaskItemDisappearAnimLength()
	{
		return 0f;
	}

	public void HandleTaskItemsOnUIReshow()
	{
	}

	private IEnumerator PlayTaskItemAppearAnim()
	{
		return null;
	}

	public void RefreshReward()
	{
	}

	public void OnUpdateInfo()
	{
	}

	public void ClaimReward()
	{
	}

	private void OnTipBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
