using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_CustomHudController : UIBaseController, IUIHUDBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UIHUDUGC_BaseController> _003C_003E9__46_1;

		public static Comparison<UIHUDUGC_BaseController> _003C_003E9__46_0;

		public static Comparison<UIHUDUGC_BaseController> _003C_003E9__47_0;

		public static Comparison<UIHUDUGC_BaseController> _003C_003E9__48_0;

		internal int _003CRefreshDepthAndSize_003Eb__46_1(UIHUDUGC_BaseController a, UIHUDUGC_BaseController b)
		{
			return 0;
		}

		internal int _003CRefreshDepthAndSize_003Eb__46_0(UIHUDUGC_BaseController a, UIHUDUGC_BaseController b)
		{
			return 0;
		}

		internal int _003CInorderSetDepth_003Eb__47_0(UIHUDUGC_BaseController a, UIHUDUGC_BaseController b)
		{
			return 0;
		}

		internal int _003CInorderSetSizeAndPosition_003Eb__48_0(UIHUDUGC_BaseController a, UIHUDUGC_BaseController b)
		{
			return 0;
		}
	}

	private UGCHudPrefabRoot m_PrefabRoot;

	private UGCCustomHudRepItem m_ViewData;

	private UGCEntityRepItem m_UGCEntityRepItem;

	public UIPanel m_Panel;

	private Dictionary<string, UIHUDUGC_BaseController> m_AllChildrenWidgets;

	private string m_EntityID;

	private uint m_HudId;

	private int m_InitDepth;

	public List<UIHUDUGC_BaseController> Children;

	public bool NeedRefreshDepth;

	public bool NeedRefreshSizeAndPosition;

	public bool NeedRefreshLayer;

	private bool m_OpenPlayerView;

	private bool m_InScene;

	private int m_CachedLayer;

	private Camera m_FollowCamera;

	private Camera m_UICamera;

	private bool m_ForcedHiddenByCameraMode;

	private int prefabIDOldValue;

	public UGCHudPrefabRoot PrefabRoot => null;

	private int ExpectedLayer => 0;

	public void AddChildWidget(string entityID, UIHUDUGC_BaseController ctrl)
	{
	}

	public static UIHUDUGC_CustomHudController Rebuild(string entityID, Transform parent, int layer, int initDepth)
	{
		return null;
	}

	public static UIHUDUGC_CustomHudController GetOrAdd(GameObject go)
	{
		return null;
	}

	protected override void OnUIDestroy()
	{
	}

	private void Init(int initDepth)
	{
	}

	public void InitHudInfo()
	{
	}

	public void SetEntityID(string entityID)
	{
	}

	public void DestroyEntity()
	{
	}

	public void RemoveWidgetEntity(string entityID)
	{
	}

	protected virtual void OnOpenStateChanged(bool value)
	{
	}

	private void OnPrefabIDChanged(int cur)
	{
	}

	public void RebuildRoot()
	{
	}

	private void OnDepthChanged(int cur)
	{
	}

	private void OnOpenPlayerViewChanged(bool cur)
	{
	}

	private void OnWorldPositionChanged(Vector3 cur)
	{
	}

	private void RefreshPlayerViewPosition(Vector3 cur)
	{
	}

	private void OnRotationChanged(Vector3 cur)
	{
	}

	private void OnScaleChanged(Vector3 cur)
	{
	}

	private void OnInSceneChanged(bool cur)
	{
	}

	private void RefreshLayer()
	{
	}

	private void InorderSetLayer(UIHUDUGC_BaseController ctrl, int layer)
	{
	}

	public UGCUIBehaviour FindWidget(string widgetId)
	{
		return null;
	}

	private void Update()
	{
	}

	public void RefreshDepthAndSize()
	{
	}

	private Vector2Int InorderSetDepth(UIHUDUGC_BaseController ctrl, Vector2Int depth, int stepDepth)
	{
		return default(Vector2Int);
	}

	public void InorderSetSizeAndPosition(UIHUDUGC_BaseController ctrl, bool parentDirty)
	{
	}

	public void SetForcedHiddenByCameraMode(bool forceHidden)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
