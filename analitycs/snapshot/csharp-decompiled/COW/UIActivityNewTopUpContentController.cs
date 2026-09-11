using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityNewTopUpContentController : UIActivityContentController, IUIModelDataChangeObserver
{
	public enum TaskItemType
	{
		Normal,
		MulitAwards
	}

	private UIActivityNewTopUpContentView m_View;

	private UIModelActivity m_ModelActivity;

	private bool m_ShowModel;

	private const uint TOTALWIDTH = 480u;

	private UITopUpEventController.TopUpEventPageType _003CPageType_003Ek__BackingField;

	private List<IUIActivityTask> m_ItemDescUIs;

	public Dictionary<uint, List<ClientActivityDesc>> m_ActivityDesDict;

	private ActivityGroupDesc m_groupDesc;

	private List<UITopUpEventProgressItemController> m_ProgressItemControllers;

	private Dictionary<uint, List<IUIActivityTask>> m_TaskItemPool;

	public UITopUpEventController.TopUpEventPageType PageType
	{
		get
		{
			return _003CPageType_003Ek__BackingField;
		}
		set
		{
			_003CPageType_003Ek__BackingField = value;
		}
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

	public override void SetData(object data)
	{
	}

	private void CreateEventDescList(List<ClientActivityDesc> activityDescs)
	{
	}

	private EActivity.State GetActivityInfo(List<ClientActivityDesc> list)
	{
		return EActivity.State.State_RECEIVED;
	}

	public void RefreshActivityInfo()
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

	private bool IsMulitAwardItem(List<ClientActivityDesc> list)
	{
		return false;
	}

	private IUIActivityTask GetUIActivityExchangeItemControllerFromPool(uint type, Transform parentTransform)
	{
		return null;
	}

	public override void Reload()
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
