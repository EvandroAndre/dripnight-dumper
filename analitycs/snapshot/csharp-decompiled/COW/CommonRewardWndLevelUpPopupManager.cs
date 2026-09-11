using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class CommonRewardWndLevelUpPopupManager : SingletonModule<CommonRewardWndLevelUpPopupManager>
{
	private class PopupInfo
	{
		public int PopUp;

		public Func<bool> IsShow;

		public Action Do;
	}

	private Queue<PopupInfo> m_PopupInfoQueue;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public void AddPopUp(int popUp, Func<bool> isShow, Action action)
	{
	}

	public void ClearPopup()
	{
	}

	public void StartPopup()
	{
	}

	public void ShowNextPopup()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
