using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIAchievementDetailController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public uint achievementId;

		internal bool _003CSetViewData_003Eb__0(uint value)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public uint achievementId;

		internal bool _003CSetPopupViewData_003Eb__0(uint value)
		{
			return false;
		}
	}

	private sealed class _003CPlayAllItemAnim_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAchievementDetailController _003C_003E4__this;

		private WaitForSeconds _003CwaitSecond_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAllItemAnim_003Ed__27(int _003C_003E1__state)
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

	private UIAchievementDetailView m_View;

	private const int MAX_ITEM_COUNT = 3;

	private UIAchievementDetailItemController[] itemCtrls;

	private UIAchievementDetailBigEventItemController m_BigEventDetailCtrl;

	private List<uint> m_SortedIds;

	private List<AchievementEntryInfo> m_SortedInfos;

	private int m_CurAchievementIdSortedIndex;

	private UIModelAchievement m_Model;

	private Coroutine m_AnimCor;

	private uint m_AchievementId;

	private EAchievement.Type m_CurType;

	private UIAnniversaryRemindWndController m_AnniversaryRemindWndCtrl;

	private bool m_IsOther;

	private int m_BaseDepth;

	public uint AchievementId => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitChildCtrls()
	{
	}

	public void SetViewData(uint achievementId, List<uint> sortedIds, EAchievement.Type curType)
	{
	}

	public void SetPopupViewData(uint achievementId, List<uint> sortedIds, List<AchievementEntryInfo> sortedInfos, EAchievement.Type curType)
	{
	}

	private void SetViewDataBySortedIndex(int sortedIndex, bool isPre)
	{
	}

	private void RefreshMainUI()
	{
	}

	private void RefreshPopupMainUI()
	{
	}

	private void RefreshMainUIInternal(AchievementEntryInfo entryInfo, List<AchievementEntryDesc> entryDescList, uint curLevel, bool isCompleted, bool isBigEvent, bool isPopup)
	{
	}

	private void InitView()
	{
	}

	public void RefreshFriendAchievementLabel(uint achId)
	{
	}

	private IEnumerator PlayAllItemAnim()
	{
		return null;
	}

	private void SetScreenshotObjActive(object[] param)
	{
	}

	private void RefreshAnniversaryEntrance()
	{
	}

	private void OnBtnPreAchievementClick()
	{
	}

	private void OnBtnNextAchievementClick()
	{
	}

	private void OnBtnAnniversaryClick()
	{
	}

	private bool _003CRefreshPopupMainUI_003Eb__23_0(AchievementEntryInfo info)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
