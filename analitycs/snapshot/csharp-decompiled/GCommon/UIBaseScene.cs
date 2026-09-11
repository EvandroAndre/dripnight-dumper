using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using COW;
using UnityEngine;

namespace GCommon;

public class UIBaseScene
{
	public delegate bool EscapeHandle();

	public delegate bool EnterHandle();

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public Type uiType;

		internal bool _003CGetOpenUIByType_003Eb__0(UIBaseController c)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public UInt128 requestCurGroup128;

		internal bool _003CSetPreviousActiveGroup_003Eb__0(UInt128 a)
		{
			return false;
		}
	}

	private sealed class _003CSetActiveGroupFCoroutine_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBaseScene _003C_003E4__this;

		private List<UIBaseController>.Enumerator _003C_003E7__wrap1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetActiveGroupFCoroutine_003Ed__86(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CSetActiveGroupInternalFCO_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBaseScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetActiveGroupInternalFCO_003Ed__91(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const int DefaultUIWidth = 1334;

	private const int DefaultUIHeight = 750;

	private const string NavigationTransferPanelName = "NavigationTransferPanel";

	private const string NavigationTransferMaskName = "NavigationTransferMask";

	public static Transform UIRoot;

	public static UICamera HUD_UICamera;

	public static UIBaseScene Instance;

	public static UISprite TransferMask;

	protected List<UIBaseController> m_RootControllers;

	protected List<UIBaseNavigationController> m_NavigationControllers;

	protected List<UIPopupWindowController> m_InGamePopupWindows;

	protected HashSet<UIPanel> m_IndependentPanels;

	private Dictionary<Type, ResourceID> m_ControllerResourceIDs;

	private Dictionary<Type, bool> m_ControllerDontDestroy;

	private List<UInt128> m_ActiveGroupStack;

	protected Vector2 m_WindowsSize;

	protected bool isDuringSceneDestroy;

	private UIPopupWindowBGBlur cbBlur;

	private bool m_EnableInitControllerReflectionData;

	private bool mIsInitialzied;

	private bool _003CIsPrePopNavigationCleanAssets_003Ek__BackingField;

	private List<EscapeHandle> m_EscapeHandles;

	private List<EnterHandle> m_EnterHandles;

	private static Stopwatch m_StopWatch;

	private IEnumerator m_SetActiveGroupCoroutine;

	private IEnumerator m_UIGroupSwitchOptCoroutine;

	private UInt128 m_InActiveGroup;

	private bool m_Immediate;

	public bool Initialized => false;

	public bool IsPrePopNavigationCleanAssets
	{
		get
		{
			return _003CIsPrePopNavigationCleanAssets_003Ek__BackingField;
		}
		private set
		{
			_003CIsPrePopNavigationCleanAssets_003Ek__BackingField = value;
		}
	}

	public Vector2 WindowsSize => default(Vector2);

	public UIPopupWindowController CurrentPopupController => null;

	public Type CurrentNavigationType => null;

	public void Init()
	{
	}

	protected void AddBgBlur()
	{
	}

	public virtual void Destory()
	{
	}

	private void InitControllerData()
	{
	}

	private void InitControllerResourceID()
	{
	}

	private void AddControllerResourceID(Type controllerType, ResourceID rerourceID)
	{
	}

	private void InitControllerDontDestroy()
	{
	}

	private void AddControllerDontDestroy(Type controllerType, bool dontDestroy)
	{
	}

	public bool IsDuringSceneDestroy()
	{
		return false;
	}

	public virtual UIBaseNavigationController PushNavigation(Type type, UINavigationData navigationData, bool isRoot = false, UIControllerContext listener = null)
	{
		return null;
	}

	private void NotifyContext(UIControllerContext listener, UIBaseNavigationController navigationController, bool afterOpenOrNavigationShowed)
	{
	}

	public virtual bool NavigationCanAccess(string navigationName)
	{
		return false;
	}

	public void PopNavigationsCannotAccess()
	{
	}

	public virtual UINavigationData PopNavigation()
	{
		return null;
	}

	public void CloseNavigation(Type type)
	{
	}

	public void PopToNavigation(Type type)
	{
	}

	private UIBaseNavigationController GetPreviousUINavigationController()
	{
		return null;
	}

	public bool HasNavigation(Type type)
	{
		return false;
	}

	public UINavigationData GetCurrentUINavigationData()
	{
		return null;
	}

	public UIBaseNavigationController GetCurrentUINavigationController()
	{
		return null;
	}

	public List<UIPopupWindowController> GetInGamePopupWindows()
	{
		return null;
	}

	public virtual UIPopupWindowController ShowPopupWindow(Type type, Transform root = null)
	{
		return null;
	}

	public void CloseAllPopups()
	{
	}

	public void CloseAllPopups(Type type)
	{
	}

	public void CloseInGamePopup(Type type)
	{
	}

	public bool IsIndependentPanel(UIPanel panel)
	{
		return false;
	}

	public void SetIndependentPanel(UIPanel panel)
	{
	}

	public void RemoveIndependentPanel(UIPanel panel)
	{
	}

	public T Open3DUI<T>(Transform parent, bool isChildCon = false, bool isQueued = false, Type forceType = null) where T : UIBaseController
	{
		return null;
	}

	public T Open3DUI<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, bool isChildCon = false, bool isQueued = false) where T : UIBaseController
	{
		return null;
	}

	public T OpenUI<T>(Transform parent, bool isChildCon = false, bool noCache = false) where T : UIBaseController
	{
		return null;
	}

	public UIBaseController OpenUI(Type uiBaseControllerType, Transform parent, bool isChildCon = false, bool noCache = false)
	{
		return null;
	}

	public UIBaseController OpenUI(Type type, Transform parent, Vector3 localPosition, EUIAnchor anchor, bool isChildCon = false, bool noCache = false)
	{
		return null;
	}

	public T OpenUI<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, bool isChildCon = false, bool noCache = false) where T : UIBaseController
	{
		return null;
	}

	public virtual void RemoveRootController(UIBaseController uiController)
	{
	}

	public Transform GetAnchor(Transform parent, EUIAnchor anchor, bool autoCreate = true)
	{
		return null;
	}

	public void AddUINavigationController(UIBaseNavigationController navigation)
	{
	}

	public void RemoveUINavigationController(UIBaseNavigationController navigation)
	{
	}

	public void RemovePopupWindow(UIPopupWindowController popupWindow)
	{
	}

	public void AddPopupWindow(UIPopupWindowController popupWindow)
	{
	}

	private T CreateUI<T>(bool isChildCon, bool noCache = false) where T : UIBaseController
	{
		return null;
	}

	private UIBaseController CreateUI(Type uiBaseControllerType, bool isChildCon, bool noCache = false)
	{
		return null;
	}

	public GameObject InstantiateUIPrefab(ResourceID InPrefabResID, bool noCache = false, Type type = null, bool dontDestroy = false)
	{
		return null;
	}

	protected virtual Transform FindUIRoot()
	{
		return null;
	}

	private UISprite GetNavigationTransferMask()
	{
		return null;
	}

	public bool PlayTransferTweenAlpha()
	{
		return false;
	}

	public void SetPreviousActiveGroup(ulong requestCurGroup = 0uL, byte groupSort = 0)
	{
	}

	public virtual void SetActiveGroup(ulong InActiveGroupParam, bool immediate = false, bool isForceRefresh = false, byte groupSort = 0)
	{
	}

	protected IEnumerator SetActiveGroupFCoroutine()
	{
		return null;
	}

	private void SetActiveGroupInternal(UInt128 InActiveGroup, bool immediate = false)
	{
	}

	private IEnumerator SetActiveGroupInternalFCO()
	{
		return null;
	}

	public UInt128 CurActiveGroup()
	{
		return default(UInt128);
	}

	public bool IsGroupActive(UInt128 flag)
	{
		return false;
	}

	protected virtual void OnInit()
	{
	}

	protected virtual void OnDestory()
	{
	}

	public virtual bool UseUIPreInstancePool()
	{
		return false;
	}

	public float GetPixelSizeAdjustment()
	{
		return 0f;
	}

	public void RegisterEscapeHandle(EscapeHandle handle)
	{
	}

	public void UnRegisterEscapeHandle(EscapeHandle handle)
	{
	}

	public bool DispatchEscapeHandle()
	{
		return false;
	}

	public float GetDefaultScreenRatio()
	{
		return 0f;
	}

	public void RegisterEnterHandle(EnterHandle handle)
	{
	}

	public void UnRegisterEnterHandle(EnterHandle handle)
	{
	}

	public bool DispatchEnterHandle()
	{
		return false;
	}

	public void SetBGBlur(UIPopupWindowBGBlur blur)
	{
	}

	public void ExecuteBGBlur(GameObject root)
	{
	}

	public void ExecuteBGBlur(List<GameObject> roots)
	{
	}

	public void ForceExecuteBGBlur()
	{
	}

	public UIBaseController GetOpenUIByType(Type uiType)
	{
		return null;
	}

	public bool PlayUIFly(string fromUIName, string fromViewName, string toUIName, string toViewName, ResourceID fxResource, Action endCallBack, float speed = 1f, float fromAlpha = 1f, float toAlpha = 1f, float fromScale = 1f, float toScale = 1f)
	{
		return false;
	}

	public bool PlayUIFly(Vector3 fromPoint, Vector3 toPoint, ResourceID fxResource, Action endCallBack, float speed = 1f, float fromAlpha = 1f, float toAlpha = 1f, float fromScale = 1f, float toScale = 1f)
	{
		return false;
	}
}
