using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIUGCCommentController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopCommentTag> _003C_003E9__13_0;

		public static Func<WorkshopCommentConfigData, uint> _003C_003E9__19_0;

		internal int _003CSetInfoData_003Eb__13_0(WorkshopCommentTag a, WorkshopCommentTag b)
		{
			return 0;
		}

		internal uint _003COnBtnConfirmClick_003Eb__19_0(WorkshopCommentConfigData e)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public List<WorkshopCommentTag> adjusted;

		public int i;

		public Predicate<WorkshopCommentConfigData> _003C_003E9__1;

		public Predicate<WorkshopCommentConfigData> _003C_003E9__2;

		internal bool _003CSetInfoData_003Eb__1(WorkshopCommentConfigData e)
		{
			return false;
		}

		internal bool _003CSetInfoData_003Eb__2(WorkshopCommentConfigData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public int i;

		public UIUGCCommentController _003C_003E4__this;

		internal bool _003CRefreshToBeSelectedData_003Eb__0(WorkshopCommentConfigData e)
		{
			return false;
		}

		internal bool _003CRefreshToBeSelectedData_003Eb__1(WorkshopCommentConfigData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public int i;

		public UIUGCCommentController _003C_003E4__this;

		internal bool _003CRefreshToBeSelectedData_003Eb__2(WorkshopCommentConfigData e)
		{
			return false;
		}

		internal bool _003CRefreshToBeSelectedData_003Eb__3(WorkshopCommentConfigData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public WorkshopCommentConfigData config;

		internal bool _003COnItemSelected_003Eb__0(WorkshopCommentConfigData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public WorkshopCommentConfigData config;

		internal bool _003COnItemDeleted_003Eb__0(WorkshopCommentConfigData e)
		{
			return false;
		}
	}

	private int m_CommentChoice;

	private UIUGCCommentView m_View;

	private SceneEditSlotInfo m_Info;

	private List<WorkshopCommentConfigData> m_SelectedCommentData;

	private List<UIUGCCommentItemController> m_CachedPosCommentItemList;

	private List<UIUGCCommentItemController> m_CachedNegCommentItemList;

	private List<WorkshopCommentConfigData> m_PositiveDataList;

	private List<WorkshopCommentConfigData> m_NegativeDataList;

	private bool m_Positive;

	private EUGCScene m_Src;

	private ulong m_MatchID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetInfoData(SceneEditSlotInfo info, EUGCScene src, ulong match_id = 0uL)
	{
	}

	private void InitToBeSelectedData()
	{
	}

	private void RefreshToBeSelectedData()
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void OnItemDeleted(object[] data)
	{
	}

	private void RefreshBtn()
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	private void OnMaskClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
