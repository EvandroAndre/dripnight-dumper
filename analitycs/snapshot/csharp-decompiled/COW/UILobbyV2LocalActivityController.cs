using System;
using GCommon;
using proto;

namespace COW;

public class UILobbyV2LocalActivityController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__10_0;

		internal void _003CRefreshLocalActivityCountDown_003Eb__10_0()
		{
		}
	}

	private UILobbyV2LocalActivityView m_View;

	private UICountDownController m_LocalActivityCountDownCtrl;

	private string m_OpenUrl;

	private LocalEventEntranceDesc m_EntranceDesc;

	private UITipsNormalController m_TipV2Ctrl;

	private UIModelActivity m_ModelActivity;

	private uint m_TipTypeValue;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetDataAndView(LocalEventEntranceDesc EntranceDesc)
	{
	}

	private void RefreshLocalActivityCountDown()
	{
	}

	private void RefreshV2RedPoint()
	{
	}

	protected virtual bool ShowV2GiftIcon()
	{
		return false;
	}

	protected virtual bool ShowV2RedPoint()
	{
		return false;
	}

	public virtual bool IsShowRedPointTip()
	{
		return false;
	}

	public void ResetCountdownContainer(bool isShow)
	{
	}

	private void GotoLocalActivity()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
