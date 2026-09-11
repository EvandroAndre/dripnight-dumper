using System;
using GCommon;
using proto;

namespace COW;

public class UISecondRechargeRewardItemController : UIBaseController
{
	private enum OperateStatus
	{
		None,
		GoTo,
		UnFinished,
		Available,
		Received
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__14_0;

		internal BaseItemInfo _003COnClickCliam_003Eb__14_0(AwardDesc s)
		{
			return null;
		}
	}

	private UISecondRechargeRewardItemView m_View;

	private uint m_DelayCallID;

	private bool m_IsRequestResponse;

	private BaseItemInfo m_BaseItemInfo;

	private int m_Index;

	private uint m_ItemId;

	private ClientActivityDesc m_ActivityDesc;

	private OperateStatus m_OpState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(ClientActivityDesc activity, int index)
	{
	}

	private void ShowPreviewBtn(bool flag)
	{
	}

	public void OnClickCliam()
	{
	}

	private void OnClickItem()
	{
	}

	private void OnPreviewBtnClick()
	{
	}

	public void SetSelectState(bool select)
	{
	}

	public int GetIndex()
	{
		return 0;
	}

	private void RequestAward()
	{
	}

	public void UpdateUI(uint state)
	{
	}

	private void _003CRequestAward_003Eb__19_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
