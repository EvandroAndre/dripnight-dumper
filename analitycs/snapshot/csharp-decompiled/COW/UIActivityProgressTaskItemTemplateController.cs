using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityProgressTaskItemTemplateController : UIActivityOperationCdnController, IUIScoreActivityTask, IUIActivityTask
{
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public ulong startTime;

		public UIActivityProgressTaskItemTemplateController _003C_003E4__this;

		internal void _003CStartCountdownTick_003Eb__0()
		{
		}
	}

	private uint _003CTemplateGroupId_003Ek__BackingField;

	private ClientActivityDesc m_Desc;

	private UIActivityProgressTaskItemTemplateView m_View;

	private UIModelActivity m_Model;

	private UIModelActivity.ActivityOperateStatus m_OperateStatus;

	private UIStandardItemMiniController m_ScoreItem;

	private EActivity.State m_State;

	private uint DelayCallID;

	private uint m_CountdownTickId;

	private bool m_Complete;

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

	public Vector3 GetRewardPostion()
	{
		return default(Vector3);
	}

	public void SetViewData(ClientActivityDesc desc)
	{
	}

	private void BuildOperationCdnGo()
	{
	}

	private void ApplyMissionBgCdn()
	{
	}

	public void RefreshItemState()
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

	public void Reload(bool complete)
	{
	}

	private void StartCountdownTick(ulong startTime)
	{
	}

	private void StopCountdownTick()
	{
	}

	private void _003CPlayShowAnimation_003Eb__27_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
