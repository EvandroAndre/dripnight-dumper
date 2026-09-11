using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPaymentSquadTreasureTeamCreatePopupWindowController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__15_0;

		internal int _003CInitToggleGroup_003Eb__15_0(uint a, uint b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public uint defaultSeconds;

		internal bool _003CInitToggleGroup_003Eb__1(uint seconds)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UIPaymentSquadTreasureTeamCreatePopupWindowController _003C_003E4__this;

		public UIPaymentSquadTreasureTeamSecondConfirmWindowController confirmWnd;

		internal void _003COnLeaveBtnClick_003Eb__0()
		{
		}

		internal void _003COnLeaveBtnClick_003Eb__1()
		{
		}
	}

	private UIPaymentSquadTreasureTeamCreatePopupWindowView m_View;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private ESquadTreasureTeamState m_SelectedTeamState;

	private bool m_IsCreate;

	private uint m_SelectedSeconds;

	private List<UIPaymentSquadTreasureTeamCreatePopupWindowToggleItemController> m_ToggleListItems;

	private List<UIPaymentSquadTreasureTeamCreatePopupWindowTypeItemController> m_TypeListItems;

	private string m_CreateColorStr;

	private string m_ChangeColorStr;

	private const float m_ToggleItemWidth = 136.3f;

	private const float m_ToggleItemWidthOffset = 5f;

	private UICountDownController m_TeamCreateCDCountDownCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(bool isCreate)
	{
	}

	private void InitToggleGroup()
	{
	}

	private void OnToggleItemClick(object[] data)
	{
	}

	private void InitTypeGroup()
	{
	}

	private void OnTypeItemClick(object[] data)
	{
	}

	private void RefreshTypeSelection()
	{
	}

	private void InitTeamState(bool isCreate)
	{
	}

	private void RefreshCreateStateByCD()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnLeaveBtnClick()
	{
	}

	private void OnSaveBtnClick()
	{
	}

	private void _003CRefreshCreateStateByCD_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
