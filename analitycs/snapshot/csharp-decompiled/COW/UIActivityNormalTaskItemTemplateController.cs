using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityNormalTaskItemTemplateController : UIActivityOperationCdnController, IUIActivityTask
{
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public AwardDesc awardDesc;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public ulong startTime;

		public UIActivityNormalTaskItemTemplateController _003C_003E4__this;

		internal void _003CStartCountdownTick_003Eb__0()
		{
		}
	}

	private uint _003CTemplateGroupId_003Ek__BackingField;

	protected ClientActivityDesc m_Desc;

	private UIActivityNormalTaskItemTemplateView m_View;

	protected UIModelActivity m_Model;

	private List<UIStandardItemMiniController> m_ItemList;

	protected UIModelActivity.ActivityOperateStatus m_OperateStatus;

	private EActivity.State m_State;

	private uint DelayCallID;

	private uint m_CountdownTickId;

	private OperationCdnGo m_Op;

	private bool _003CShowModel_003Ek__BackingField;

	public uint TemplateGroupId
	{
		get
		{
			return _003CTemplateGroupId_003Ek__BackingField;
		}
		set
		{
			_003CTemplateGroupId_003Ek__BackingField = value;
		}
	}

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

	private void ApplyMissionBgCdn()
	{
	}

	private void BuildOperationCdnGo()
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

	private void StartCountdownTick(ulong startTime)
	{
	}

	private void StopCountdownTick()
	{
	}

	private void _003CPlayShowAnimation_003Eb__26_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
