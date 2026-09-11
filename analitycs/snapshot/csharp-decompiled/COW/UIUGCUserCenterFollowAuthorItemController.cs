using System;
using GCommon;
using proto;

namespace COW;

public class UIUGCUserCenterFollowAuthorItemController : UIEasyListItemController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CreatorLevelInfo> _003C_003E9__9_0;

		internal int _003CSetViewData_003Eb__9_0(CreatorLevelInfo a, CreatorLevelInfo b)
		{
			return 0;
		}
	}

	private const string CreatorUpdateHourLocKey = "T_54_SQF_WS_CREATOR_UPDATE_HOUR";

	private const string CreatorUpdateDayLocKey = "T_54_SQF_WS_CREATOR_UPDATE_DAY";

	private const string CreatorWorkCountLocKey = "T_54_SQF_WS_CRAFTLAND_MAP_COUNT";

	private UIUGCUserCenterFollowAuthorItemView m_View;

	public Action<UIButton> OnClickSetAction;

	public Action<int> OnClickSelectAction;

	private UIUGCUserCenterFollowAuthorItemData m_ItemData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object viewData, int data_index)
	{
	}

	private string FormatLatestUpdateInfo(long latestUpdateAt, uint mapCount)
	{
		return null;
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void RefreshSetBtnVisible()
	{
	}

	private void OnClickSetBtn()
	{
	}

	private void OnClickHaedBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
