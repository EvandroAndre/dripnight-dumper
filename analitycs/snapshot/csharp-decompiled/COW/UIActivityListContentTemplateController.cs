using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityListContentTemplateController : UIActivityContentController, IUIModelDataChangeObserver
{
	public enum TaskItemType
	{
		Normal,
		MulitTask,
		MulitAwards
	}

	protected UIActivityListContentTemplateView m_View;

	private UIModelActivity m_ModelActivity;

	private bool m_ShowModel;

	private uint m_GroupID;

	protected List<IUIActivityTask> m_ItemDescUIs;

	public Dictionary<uint, List<ClientActivityDesc>> m_ActivityDesDict;

	private List<ClientActivityDesc> m_ActivityDescList;

	private Dictionary<uint, List<IUIActivityTask>> m_TaskItemPool;

	private ActivityGroupDesc m_Descs;

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

	private void ReturnUIActivityExchangeItemControllerToPool(uint type, IUIActivityTask exchangeItem)
	{
	}

	public void ResetUI()
	{
	}

	public override void SetData(object data)
	{
	}

	private void ApplyCdnSkin()
	{
	}

	private static void SetCdnWithFallback(GameObject fallback, UINetworkTexture target, string url)
	{
	}

	private static void SetCdn(UINetworkTexture target, string url)
	{
	}

	private void CreateEventDescList(List<ClientActivityDesc> activityDescs)
	{
	}

	protected virtual void RefreshOperateState()
	{
	}

	private void OperationBtnClick()
	{
	}

	private IUIActivityTask CreateEventDesc(List<ClientActivityDesc> list, int index)
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

	private bool IsMulitAwardItem(List<ClientActivityDesc> list)
	{
		return false;
	}

	private IUIActivityTask GetUIActivityExchangeItemControllerFromPool(uint type, Transform parentTransform)
	{
		return null;
	}

	protected virtual IUIActivityTask SetNormalTaskType(Transform parentTransform)
	{
		return null;
	}

	private void SetTemplateGroupId(IUIActivityTask item, uint groupId)
	{
	}

	public override void Reload()
	{
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
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

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
