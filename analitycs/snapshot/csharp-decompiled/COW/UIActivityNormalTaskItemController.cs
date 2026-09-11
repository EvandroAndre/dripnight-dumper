using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityNormalTaskItemController : UIActivityOperationController, IUIActivityTask
{
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public AwardDesc awardDesc;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	protected ClientActivityDesc m_Desc;

	private UIActivityNormalTaskItemView m_View;

	protected UIModelActivity m_Model;

	private List<UIStandardItemMiniController> m_ItemList;

	protected UIModelActivity.ActivityOperateStatus m_OperateStatus;

	private EActivity.State m_State;

	private uint DelayCallID;

	private bool _003CShowModel_003Ek__BackingField;

	public GameObject RootObject => null;

	public uint ItemType => 0u;

	public bool ShowModel
	{
		get
		{
			return _003CShowModel_003Ek__BackingField;
		}
		set
		{
			_003CShowModel_003Ek__BackingField = value;
		}
	}

	public EActivity.State GetState()
	{
		return EActivity.State.State_RECEIVED;
	}

	public uint GetRewardActivityId()
	{
		return 0u;
	}

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

	public void PlayShowAnimation(int index)
	{
	}

	public void SetData(List<ClientActivityDesc> list, int index)
	{
	}

	public void Reload()
	{
	}

	public void SetViewData(ClientActivityDesc desc)
	{
	}

	public void RefreshItemState()
	{
	}

	public virtual void GetOperateStatus()
	{
	}

	public void ResetUI()
	{
	}

	protected virtual void OnOperate()
	{
	}

	public void SetScrollView(UIScrollView scrollView)
	{
	}

	private void _003CPlayShowAnimation_003Eb__20_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
