using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudObGlobalEventPanelController : UIBaseController
{
	public class GlobalEventItem
	{
		public byte eventID;

		public UILabel name;

		public UICheckboxButton checkBox;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<int> _003C_003E9__20_0;

		internal bool _003CSetUIData_003Eb__20_0(int m)
		{
			return false;
		}
	}

	private const string JumpHeight = "JumpHeight";

	private const string JumpHeightOne = "JumpHeightOne";

	private const string JumpHeightTwo = "JumpHeightTwo";

	private const string MovementSpeed = "MovementSpeed";

	private const string MovementSpeedOne = "MovementSpeedOne";

	private const string MovementSpeedTwo = "MovementSpeedTwo";

	private const string MovementSpeedThree = "MovementSpeedThree";

	private UIHudObGlobalEventPanelView m_View;

	private int[] m_PollDurationOptions;

	private int[] m_PollEventCountOptions;

	private List<byte> m_EventIdListSelected;

	private List<UICheckboxButton> m_CheckBoxList;

	private bool isCD;

	private UITimeLabelHelper m_TimeHelper;

	private LGBPPLOIEON m_EventManager;

	private UIDetailTipsInGameController m_DetailTips;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void SetUIData()
	{
	}

	private void SetJumpAndMove(RoomOBEventData oBEventData)
	{
	}

	private void OnJumpSelectCallback(UIToggleButton selectButton)
	{
	}

	private void OnJumpUnSelectCallback(UIToggleButton selectButton)
	{
	}

	private void OnMoveSelectCallback(UIToggleButton selectButton)
	{
	}

	private void OnMoveUnSelectCallback(UIToggleButton selectButton)
	{
	}

	private void OnJumpCheckClick()
	{
	}

	private void OnMoveCheckClick()
	{
	}

	private void Update()
	{
	}

	private void OnEventCheckBoxClick(object obj, int idx)
	{
	}

	private void RefreshConfirmBtn()
	{
	}

	private void OnPollCheckBoxClick()
	{
	}

	private void OnSingleToggleClick()
	{
	}

	private void OnMultipleToggleClick()
	{
	}

	private void OnConfirm()
	{
	}

	private int GetMaxCheckableEventCount()
	{
		return 0;
	}

	private void RefreshCD()
	{
	}

	private void OnCDEndNtf(object[] data)
	{
	}

	private void OnClose()
	{
	}

	private void OnTipsClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
