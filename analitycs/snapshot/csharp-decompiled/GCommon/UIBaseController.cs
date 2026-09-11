using System;
using System.Collections.Generic;
using COW;
using UnityEngine;

namespace GCommon;

public class UIBaseController : MonoBehaviour, IShare
{
	private class CachedPosScale
	{
		public Vector3 LocalPosition;

		public Vector3 Scale;

		public Animator Aimation;

		public UIWidget[] m_CachedWidgetList;

		public bool Active;

		public UIWidget[] CachedWidgetList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}

	public class AutoRegisterItem
	{
		public EventID EventID;

		public object Handler;

		public AutoRegisterItem(EventID id, object handler)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_0
	{
		public EventID eventID;

		internal bool _003CGetAutoRegiserItem_003Eb__0(AutoRegisterItem item)
		{
			return false;
		}
	}

	private Dictionary<int, CachedPosScale> m_CachedPosition;

	private static Vector3 RemotePosition;

	protected bool m_NeedRemotePos;

	protected bool m_NeedParseWigdet;

	private UIBaseController _003CParentController_003Ek__BackingField;

	private bool _003CIsInit_003Ek__BackingField;

	private bool _003CIsOpened_003Ek__BackingField;

	private bool _003CIsClosed_003Ek__BackingField;

	public bool IsRootController;

	private UIBaseView view;

	protected List<UIBaseController> m_ChildControllers;

	protected UIPanel m_RootPanel;

	protected BitArray128 m_UIGroup128;

	private const uint VISIBILITY_STATE_GROUP = 1u;

	private const uint VISIBILITY_STATE_SHOWHIDE = 2u;

	private const uint VISIBILITY_STATE_NAVIGATION = 4u;

	private const uint VISIBILITY_STATE_EXTRAFLAG = 8u;

	private const uint VISIBILITY_STATE_GAMEPHASE = 16u;

	private const uint VISIBILITY_STATE_SETTING = 32u;

	private const uint VISIBILITY_STATE_InTrap = 64u;

	private const uint VISIBILITY_STATE_ROOMSETTING = 128u;

	private const uint VISIBILITY_STATE_UGC_VISIBILITY = 256u;

	private const uint VISIBILITY_STATE_UGC_CAMERA_HARDCODED = 512u;

	private const uint VISIBILITY_STATE_SPECTATORTARGET = 1024u;

	public const uint VISIBILITY_STATE_ROOM_HANGUP = 33554432u;

	public const uint VISIBILITY_STATE_CUSTOM5 = 67108864u;

	public const uint VISIBILITY_STATE_CUSTOM4 = 134217728u;

	public const uint VISIBILITY_STATE_CUSTOM3 = 268435456u;

	public const uint VISIBILITY_STATE_CUSTOM2 = 536870912u;

	public const uint VISIBILITY_STATE_CUSTOM1 = 1073741824u;

	protected BitArrayBoolean m_StoredActiveState;

	private List<UIBaseModel> m_RegisterModels;

	private List<AutoRegisterItem> m_RegisterEvents;

	private Action CursorEventOnShowOrCreate;

	private Action CursorEventOnHideOrDestroy;

	private Vector3 m_OrignalScale;

	private bool m_LastVisibilityState;

	private bool m_HideByMovePos;

	public UIBaseController ParentController
	{
		get
		{
			return _003CParentController_003Ek__BackingField;
		}
		set
		{
			_003CParentController_003Ek__BackingField = value;
		}
	}

	public bool IsInit
	{
		get
		{
			return _003CIsInit_003Ek__BackingField;
		}
		internal set
		{
			_003CIsInit_003Ek__BackingField = value;
		}
	}

	public bool IsOpened
	{
		get
		{
			return _003CIsOpened_003Ek__BackingField;
		}
		internal set
		{
			_003CIsOpened_003Ek__BackingField = value;
		}
	}

	public bool IsClosed
	{
		get
		{
			return _003CIsClosed_003Ek__BackingField;
		}
		internal set
		{
			_003CIsClosed_003Ek__BackingField = value;
		}
	}

	public List<UIBaseController> ChildControllers => null;

	protected void AutoRegisterEvent(EventID eventID, EventDispatcher.EventHandler eventHandler)
	{
	}

	private void RegistEventInternal(EventID eventID, object eventHandler)
	{
	}

	protected void AutoRegisterGEvent(EventID eventID, EventDispatcher.GEventHandler eventHandler)
	{
	}

	protected void AutoRegisterFEvent(EventID eventID, EventDispatcher.FEventHandler eventHandler)
	{
	}

	protected void AutoRegisterBEvent(EventID eventID, EventDispatcher.BEventHandler eventHandler)
	{
	}

	protected void AutoRegisterVEvent(EventID eventID, EventDispatcher.VEventHandler eventHandler)
	{
	}

	protected void AutoRegisterUEvent(EventID eventID, EventDispatcher.UEventHandler eventHandler)
	{
	}

	protected void AutoRegisterUEvent(EventID eventID, EventDispatcher.UUEventHandler eventHandler)
	{
	}

	protected void AutoRegisterIEvent(EventID eventID, EventDispatcher.IEventHandler eventHandler)
	{
	}

	protected void AutoRegisterIEvent(EventID eventID, EventDispatcher.IIEventHandler eventHandler)
	{
	}

	protected void AutoRegisterUlEvent(EventID eventID, EventDispatcher.UlEventHandler eventHandler)
	{
	}

	protected void AutoRegisterIIEvent(EventID eventID, EventDispatcher.IIEventHandler eventHandler)
	{
	}

	private void UnregisterAllEvent()
	{
	}

	protected void AutoRegisterModel(UIBaseModel model, IUIModelDataChangeObserver observer)
	{
	}

	private void UnregisterAllModel()
	{
	}

	public virtual bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	public virtual bool RecyleDontDestroy()
	{
		return false;
	}

	public virtual bool IsSuspendingEnabled()
	{
		return false;
	}

	protected virtual void Awake()
	{
	}

	public void Close()
	{
	}

	protected virtual void OnSuspend()
	{
	}

	protected virtual void OnResume()
	{
	}

	public virtual bool Suspend()
	{
		return false;
	}

	public virtual bool Resume()
	{
		return false;
	}

	public virtual bool IsSuspended()
	{
		return false;
	}

	public void Recyle()
	{
	}

	internal void Destroy()
	{
	}

	internal void UIOpen()
	{
	}

	internal void UIActiveGroupSwitch(UInt128 activeGroup, bool immediate = false)
	{
	}

	public virtual GameObject GetViewRootObject()
	{
		return null;
	}

	public Transform GetViewRootTransform()
	{
		return null;
	}

	protected virtual T OpenChildControllerWith3DUI<T>(Transform parent, Vector3 localPosition = default(Vector3), EUIAnchor anchor = EUIAnchor.None) where T : UIBaseController
	{
		return null;
	}

	protected virtual T OpenChildController<T>(Transform parent, Vector3 localPosition = default(Vector3), EUIAnchor anchor = EUIAnchor.None, bool noCache = false) where T : UIBaseController
	{
		return null;
	}

	public virtual UIBaseController OpenChildController(Type uiType, Transform parent, Vector3 localPosition = default(Vector3), EUIAnchor anchor = EUIAnchor.None, bool noCache = false)
	{
		return null;
	}

	public void RemoveChild(UIBaseController controller)
	{
	}

	public void AddChild(UIBaseController controller, bool setParent = false)
	{
	}

	protected virtual void OnChildControllerOpenChildController()
	{
	}

	protected UIBaseView CreateView(Type type)
	{
		return null;
	}

	protected UIBaseView CreateView(Type type, Transform viewTransform)
	{
		return null;
	}

	protected T CreateView<T>() where T : UIBaseView, new()
	{
		return null;
	}

	public void ReInitView()
	{
	}

	protected virtual void OnUIInit()
	{
	}

	public virtual void OnUIReInit()
	{
	}

	protected virtual void OnUIOpen()
	{
	}

	protected virtual void OnUIOpenAsChild()
	{
	}

	public virtual void OnRecyle()
	{
	}

	protected virtual void OnUIClose()
	{
	}

	protected virtual void OnUIDestory()
	{
	}

	protected virtual void OnUIDestroy()
	{
	}

	protected virtual void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	protected virtual void OnVisibilityByPosChanged(bool visibility)
	{
	}

	protected virtual void OnVisibilityChanged()
	{
	}

	protected virtual void SetControllerCursorEvent(Action OnShowOrCreate = null, Action OnHideOrDestory = null)
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void Show()
	{
	}

	public virtual void Hide()
	{
	}

	public void SetVisibility(bool v)
	{
	}

	public void SetNavigationVisibility(bool v)
	{
	}

	public void SetExtraFlagVisibility(bool v)
	{
	}

	public void SetGamePhaseVisibility(bool v)
	{
	}

	public void SetInTrapVisibility(bool v)
	{
	}

	public void SetSettingVisibility(bool v)
	{
	}

	public void SetRoomSettingVisibility(bool v)
	{
	}

	public virtual void SetUGCVisibility(bool v)
	{
	}

	public void SetUGCCameraHardCodedVisibility(bool v)
	{
	}

	public void SetSpectatorTargetVisibility(bool v)
	{
	}

	public void SetActiveState(uint flag, bool v)
	{
	}

	public bool GetShowHideState()
	{
		return false;
	}

	private bool GetActiveState(uint flag)
	{
		return false;
	}

	public void SwitchGroup(ulong activeGroup)
	{
	}

	public virtual bool IsVisible()
	{
		return false;
	}

	public UIBaseController SetUIGroup(UInt128 groupFlags)
	{
		return null;
	}

	public AutoRegisterItem GetAutoRegiserItem(EventID eventID)
	{
		return null;
	}

	public void ResetVisible()
	{
	}

	public void MovePanel()
	{
	}

	public void RecoverPanel()
	{
	}

	protected virtual void RefreshVisibility(bool move = false)
	{
	}

	public void RefreshVisibilityForHide()
	{
	}

	public static void SetGameObjectsActive(bool flag, MonoBehaviour[] monoBehaviours)
	{
	}

	public static void SetGameObjectActive(MonoBehaviour monoBehaviour, bool flag, Action<bool> changed = null)
	{
	}

	public static void SetGameObjectActive(GameObject go, bool flag, Action<bool> changed = null)
	{
	}

	public static void SetGameObjectsActive(bool flag, GameObject[] gameObjects)
	{
	}

	public static void SetBehaviorActive(Behaviour go, bool flag, Action<bool> changed = null)
	{
	}

	public virtual void BeforeScreenshot()
	{
	}

	public virtual void AfterScreenshot()
	{
	}

	public virtual void BeforeSharePreview()
	{
	}

	public virtual void AfterSharePreview()
	{
	}

	public virtual void OnShare(bool success, int platform)
	{
	}

	public virtual void OnSaveSharePhoto(bool success)
	{
	}

	public virtual void OnCopyShareLink(bool success)
	{
	}

	protected virtual ResourceID GetResID()
	{
		return default(ResourceID);
	}

	protected virtual void OnRecycleUIGameObject()
	{
	}

	private bool NeedReturn2Pool()
	{
		return false;
	}

	private void Return2Pool()
	{
	}

	protected void StopCoroutineEx(ref Coroutine co)
	{
	}

	public UIBaseView GetBaseView()
	{
		return null;
	}

	public string DoLoc(string key)
	{
		return null;
	}

	public void CancelDelayCallByGameEngine(ref uint delayCall)
	{
	}
}
