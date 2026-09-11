using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityMulitTaskItemController : UIActivityOperationController, IUIActivityTask
{
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public AwardDesc awardDesc;

		internal void _003CSetData_003Eb__0()
		{
		}
	}

	private List<ClientActivityDesc> m_DescList;

	private UIActivityMulitTaskItemView m_View;

	private UIModelActivity m_Model;

	private List<UIStandardItemMiniController> m_ItemList;

	private EActivity.State m_State;

	private UIModelActivity.ActivityOperateStatus m_OperateStatus;

	private uint DelayCallID;

	private OperationGo m_OperationGo;

	private OperationGo m_OperationGo1;

	private OperationGo m_OperationGo2;

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

	public void RefreshItemState()
	{
	}

	public void ResetUI()
	{
	}

	protected void OnOperate1()
	{
	}

	protected void OnOperate2()
	{
	}

	protected void OnOperate()
	{
	}

	public void SetScrollView(UIScrollView scrollView)
	{
	}

	private void _003CPlayShowAnimation_003Eb__23_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
