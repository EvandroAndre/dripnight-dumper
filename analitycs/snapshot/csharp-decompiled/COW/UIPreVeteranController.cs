using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIPreVeteranController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public uint taskId;

		internal bool _003COnDataChanged_003Eb__0(ClientVeteranTaskDesc desc)
		{
			return false;
		}
	}

	private UIPreVeteranView m_View;

	private uint m_DelayCallClose;

	private const int TASK_NUM = 4;

	private List<UIPreVeteranRewardItemController> m_RewardItemCtrlList;

	private UIModelPreVeteran m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitRewardItem()
	{
	}

	public void SetViewData(object[] data)
	{
	}

	private void CloseWindow()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
