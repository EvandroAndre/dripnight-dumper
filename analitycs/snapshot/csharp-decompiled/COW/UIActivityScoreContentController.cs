using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIActivityScoreContentController : UIActivityContentController, IUIModelDataChangeObserver
{
	public enum TaskItemType
	{
		Normal,
		MulitTask
	}

	private const int TOTALWIDTH = 560;

	private const int FIRSTOFFSET = 55;

	private ActivityGroupDesc m_GroupDesc;

	private List<UIActivityAccumulateItemController> m_ProgressItemControllers;

	private UIActivityScoreContentView m_View;

	private UIModelActivity m_Model;

	private uint m_MaxAccumulate;

	private List<ClientActivityDesc> m_ScoreList;

	private List<ClientActivityDesc> m_NormalList;

	private List<IUIScoreActivityTask> m_ItemDescUIs;

	public Dictionary<uint, List<ClientActivityDesc>> m_ActivityDesDict;

	private bool m_ShowModel;

	private bool m_OnRequestScore;

	private bool m_HasComplete;

	private uint m_ReqestCD;

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

	public override void SetData(object data)
	{
	}

	private void SetDailyLabel()
	{
	}

	private void FlyEffect(object[] param)
	{
	}

	private void CreateEventDescList(List<ClientActivityDesc> activityDescs)
	{
	}

	private IUIScoreActivityTask CreateEventDesc(List<ClientActivityDesc> list, int index)
	{
		return null;
	}

	public override void OnVisibilityChange(bool isVisible, bool needRefresh)
	{
	}

	private void PlayItemAnimation()
	{
	}

	private bool IsMulitTaskItem(List<ClientActivityDesc> list)
	{
		return false;
	}

	private bool IsSameAward(List<AwardDesc> awards1, List<AwardDesc> awards2)
	{
		return false;
	}

	private EActivity.State GetActivityInfo(List<ClientActivityDesc> list)
	{
		return EActivity.State.State_RECEIVED;
	}

	private int SortByCondtionValue(ClientActivityDesc a, ClientActivityDesc b)
	{
		return 0;
	}

	public void RefreshActivityInfo()
	{
	}

	private void RefreshOperateState()
	{
	}

	private void OperationBtnClick()
	{
	}

	private void RequestReward()
	{
	}

	private bool RequestScoreItem()
	{
		return false;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChange(bool P0, bool P1)
	{
	}
}
