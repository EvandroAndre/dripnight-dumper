using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIControllerContext : IUIModelDataChangeObserver
{
	private class EventListenerBase
	{
		public EventID ID;

		public UIControllerContext Context;

		public EEventHandleType HandleType;

		public EventListenerBase(UIControllerContext context, EventID id, EEventHandleType handleType)
		{
		}
	}

	private class EventListener : EventListenerBase
	{
		public EventListener(UIControllerContext context, EventID id)
		{
		}

		public void EventHandler(object[] data)
		{
		}
	}

	private class VEventListener : EventListenerBase
	{
		public VEventListener(UIControllerContext context, EventID id)
		{
		}

		public void VEventHandler()
		{
		}
	}

	private class UEventListener : EventListenerBase
	{
		public UEventListener(UIControllerContext context, EventID id)
		{
		}

		public void UEventHandler(uint data)
		{
		}
	}

	private class UUEventListener : EventListenerBase
	{
		public UUEventListener(UIControllerContext context, EventID id)
		{
		}

		public void UUEventHandler(uint data1, uint data2)
		{
		}
	}

	private List<NotifyBase> m_ListNotify;

	private Action m_ProtoRequest;

	private bool m_NotifyAfterOnNavigationShowed;

	private uint m_ObserveFlag;

	private List<Type> m_ListInterestedModel;

	private Queue<object[]> m_EventData;

	private Queue<uint> m_UEventData;

	private List<EventNotify> m_ListInterestedEvent;

	private List<EventListenerBase> m_ListEventListener;

	public UIControllerContext(List<Type> models, Action protoRequest, bool notifyAfterOnNavigationShowed = false)
	{
	}

	public UIControllerContext(List<Type> models, List<EventNotify> events)
	{
	}

	public void StartAndListenModelNotify()
	{
	}

	public void Listen()
	{
	}

	public void Destroy()
	{
	}

	public void CheckRegister(UIBaseController controller)
	{
	}

	public void Notify(UIBaseController baseController, bool needUnregisterAll = false)
	{
	}

	public bool NotifyAfterOnNavigationShowed()
	{
		return false;
	}

	private void ListenModel()
	{
	}

	private void CheckRegisterModel(UIBaseController controller)
	{
	}

	private void NotifyModelChange(UIBaseController baseController, NotifyBase notifyDataBase)
	{
	}

	private void UnRegisterAllModel()
	{
	}

	private void ChangeInterestedPropID(uint flag)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void CheckRegisterEvent(UIBaseController baseController)
	{
	}

	private void ListenEvent()
	{
	}

	private void NotifyEvent(UIBaseController baseController, NotifyBase notifyDataBase)
	{
	}

	private object[] GetEventData()
	{
		return null;
	}

	private uint GetUEventData()
	{
		return 0u;
	}

	private void SetEventData(object[] eventData)
	{
	}

	private void SetEventData(uint eventData)
	{
	}

	private void SetEventData(uint eventData1, uint eventData2)
	{
	}

	private void GetEventDataContainerCheck<T>(Queue<T> eventData)
	{
	}

	private void EventDataIsNullException()
	{
	}

	private void EventDataIsEmptyException()
	{
	}

	private void UnRegisterAllEvent()
	{
	}
}
