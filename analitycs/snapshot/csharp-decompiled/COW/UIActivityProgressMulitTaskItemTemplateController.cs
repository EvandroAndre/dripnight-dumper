using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityProgressMulitTaskItemTemplateController : UIActivityOperationCdnController, IUIScoreActivityTask, IUIActivityTask
{
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public ulong startTime;

		public UIActivityProgressMulitTaskItemTemplateController _003C_003E4__this;

		internal void _003CStartCountdownTick_003Eb__0()
		{
		}
	}

	private uint _003CTemplateGroupId_003Ek__BackingField;

	private List<ClientActivityDesc> m_DescList;

	private UIActivityProgressMulitTaskItemTemplateView m_View;

	private UIModelActivity m_Model;

	private UIStandardItemMiniController m_ScoreItem;

	private EActivity.State m_State;

	private UIModelActivity.ActivityOperateStatus m_OperateStatus;

	private uint DelayCallID;

	private uint m_CountdownTickId;

	private bool m_Complete;

	private UIButton m_OperationBtn;

	private UIButton m_OperationBtn1;

	private UIButton m_OperationBtn2;

	private OperationCdnGo m_Op;

	private OperationCdnGo m_Op1;

	private OperationCdnGo m_Op2;

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

	public Vector3 GetRewardPostion()
	{
		return default(Vector3);
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

	private void BuildOperationCdnGos()
	{
	}

	private void ApplyMissionBgCdn()
	{
	}

	public void Reload()
	{
	}

	public void RefreshItemState()
	{
	}

	private void ShowSubTaskOperations(bool showSecondTask)
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

	public void Reload(bool complete)
	{
	}

	private void StartCountdownTick(ulong startTime)
	{
	}

	private void StopCountdownTick()
	{
	}

	private void _003CPlayShowAnimation_003Eb__33_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
