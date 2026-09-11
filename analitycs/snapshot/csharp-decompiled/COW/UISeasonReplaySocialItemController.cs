using GCommon;

namespace COW;

public class UISeasonReplaySocialItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public SeasonReplayFriendData data;

		internal bool _003CSetData_003Eb__0(ulong id)
		{
			return false;
		}
	}

	private UISeasonReplaySocialItemView m_View;

	private SeasonReplayFriendData m_Data;

	private UIModelProfile m_ModelProfile;

	private int m_Index;

	private bool m_IsBR;

	private bool m_IsLoneWolf;

	private bool m_IsSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public UIWidget GetSelectWidget()
	{
		return null;
	}

	public void SetData(SeasonReplayFriendData data, int index, bool isBR, bool IsLoneWolf, int posIndex)
	{
	}

	private void OnAddFriendBtnClick()
	{
	}

	public void Selected()
	{
	}

	public void UnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
