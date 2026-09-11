using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudSceneEditTimelineTrackController : UIBaseController
{
	private class KeyBasePool
	{
		private List<KeyBase> pool;

		public int Count => 0;

		// C# has no syntax for parameterized property 'Item'.
		public KeyBase get_Item(int index)
		{
			return null;
		}

		public T GetOrCreate<T>(Func<T> creator) where T : KeyBase
		{
			return null;
		}

		public void DeactivateAll()
		{
		}
	}

	public abstract class KeyBase
	{
		private GameObject _003CgameObject_003Ek__BackingField;

		private UGCTimelineEditorKeyBase _003CframeData_003Ek__BackingField;

		protected UILongPress m_clipBackBtn;

		protected UGCTimelineDragClip m_dragObject;

		protected UIDragScrollView m_dragScrollView;

		public Action<UGCTimelineEditorKeyBase> OnClickKeyAction;

		public GameObject gameObject
		{
			get
			{
				return _003CgameObject_003Ek__BackingField;
			}
			private set
			{
				_003CgameObject_003Ek__BackingField = value;
			}
		}

		public UGCTimelineEditorKeyBase frameData
		{
			get
			{
				return _003CframeData_003Ek__BackingField;
			}
			private set
			{
				_003CframeData_003Ek__BackingField = value;
			}
		}

		public bool Active => false;

		public abstract Vector3 LocalPos { get; set; }

		public KeyBase(GameObject gameObject)
		{
		}

		public virtual void Bind(UGCTimelineEditorKeyBase data)
		{
		}

		public void SetActive(bool active)
		{
		}

		public virtual void Release()
		{
		}

		public virtual void SetSelected(bool value)
		{
		}

		public T GetComponentSafe<T>(GameObject go, string nodeName) where T : Component
		{
			return null;
		}

		public abstract void LockPosition(float deltaX);

		public abstract void Refresh();
	}

	public class Keyframe : KeyBase
	{
		private Transform m_selectedIcon;

		private Transform m_normalIcon;

		public Action<Keyframe, bool> OnPressKeyAction;

		public Action<Keyframe> OnDraggingAction;

		private float _003ClastPosX_003Ek__BackingField;

		private UIButton m_keyBtn;

		public float lastPosX
		{
			get
			{
				return _003ClastPosX_003Ek__BackingField;
			}
			private set
			{
				_003ClastPosX_003Ek__BackingField = value;
			}
		}

		public float currentPosX => 0f;

		public override Vector3 LocalPos
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Keyframe(GameObject gameObject)
			: base(null)
		{
		}

		private void OnLongPressHandler(bool isPress)
		{
		}

		private void OnDraggingKeyframe()
		{
		}

		public override void SetSelected(bool value)
		{
		}

		public override void LockPosition(float deltaX)
		{
		}

		protected void OnClickKeyFrame()
		{
		}

		public override void Refresh()
		{
		}

		public void _003C_003EiFixBaseProxy_SetSelected(bool P0)
		{
		}
	}

	public class KeyClip : KeyBase
	{
		private enum DragType
		{
			None,
			Clip,
			LeftSideBar,
			RightSideBar
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<UIWidget> _003C_003E9__45_0;

			internal int _003C_002Ector_003Eb__45_0(UIWidget a, UIWidget b)
			{
				return 0;
			}
		}

		private UIWidget m_clipBack;

		private UIWidget m_clipLeftSide;

		private UIWidget m_clipRightSide;

		private UISprite m_clipColor;

		private UILabel m_clipTitle;

		private UILabel m_loopTxt;

		private UISprite m_loopBG;

		private UIColor m_bgColor;

		private UIButton m_clipLeftSideBtn;

		private UIButton m_clipRightSideBtn;

		private UISprite m_clipLeftSideBG;

		private UISprite m_clipRightSideBG;

		private UGCTimelineDragClipSideBar m_clipLeftSideDrag;

		private UGCTimelineDragClipSideBar m_clipRightSideDrag;

		private UIButton m_clipBtn;

		private UISprite m_WarnIcon;

		private UIButton m_BtnWarn;

		private Color m_color;

		private static Color ClipErrorColor;

		private uint m_DelayRefreshId;

		public Action<KeyClip, bool> OnPressClipAction;

		public Action<KeyClip> OnDraggingAction;

		private List<UIWidget> uIWidgets;

		public Action<UGCTimelineDragClipSideBar.SiderBarDire, KeyClip> OnDragSideBarAction;

		public Action<UGCTimelineDragClipSideBar.SiderBarDire, KeyClip, bool> OnPressSideBarAction;

		private DragType m_dragType;

		private float _003ClastLeftPos_003Ek__BackingField;

		private float _003ClastRightPos_003Ek__BackingField;

		private bool m_isDepthIncreased;

		private List<int> m_originalDepths;

		public override Vector3 LocalPos
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float leftSidePos => 0f;

		public float rightSidePos => 0f;

		public float lastLeftPos
		{
			get
			{
				return _003ClastLeftPos_003Ek__BackingField;
			}
			private set
			{
				_003ClastLeftPos_003Ek__BackingField = value;
			}
		}

		public float lastRightPos
		{
			get
			{
				return _003ClastRightPos_003Ek__BackingField;
			}
			private set
			{
				_003ClastRightPos_003Ek__BackingField = value;
			}
		}

		public override void LockPosition(float deltaX)
		{
		}

		public override void Release()
		{
		}

		public KeyClip(GameObject gameObject)
			: base(null)
		{
		}

		private void OnDraggingClip()
		{
		}

		private void OnPressLeftSideBar(bool isPress)
		{
		}

		private void OnPressRightSideBar(bool isPress)
		{
		}

		private void OnDraggingLeftClipSide()
		{
		}

		private void OnDraggingRightClipSide()
		{
		}

		private void OnClickWarningTipHandler()
		{
		}

		private void OnClickClipHandler()
		{
		}

		private void OnLongPressHandler(bool isPress)
		{
		}

		public override void SetSelected(bool value)
		{
		}

		public override void Bind(UGCTimelineEditorKeyBase keyframe)
		{
		}

		public void SetClipColor(MHHOHPCLMFB trackType)
		{
		}

		private void RefreshClipLoopType(UGCTimelineEditorDefine.ClipLoopType loopType)
		{
		}

		public void RefreshClipWarningState()
		{
		}

		public override void Refresh()
		{
		}

		private Vector3 GetLoopBackPos(UGCTimelineEditorKeyClip keyFrame, bool visible)
		{
			return default(Vector3);
		}

		private void RefreshSide(Vector3 value)
		{
		}

		public void RevertSide(UGCTimelineDragClipSideBar.SiderBarDire dire)
		{
		}

		public void RevertPos()
		{
		}

		public void SetHigherDepth(bool isPress)
		{
		}

		private void _003CRefreshClipWarningState_003Eb__58_0()
		{
		}

		public void _003C_003EiFixBaseProxy_Release()
		{
		}

		public void _003C_003EiFixBaseProxy_SetSelected(bool P0)
		{
		}

		public void _003C_003EiFixBaseProxy_Bind(UGCTimelineEditorKeyBase P0)
		{
		}
	}

	private UIHudSceneEditTimelineTrackView m_View;

	private UGCTimelineEditorTrackBaseWarp m_TrackBaseWarp;

	private float m_TickInterval;

	private KeyBasePool m_KeyPools;

	private Action<UGCTimelineEditorTrackBaseWarp, UGCTimelineEditorKeyBase> m_action;

	private List<UIHudSceneEditTimelineTrackController> m_ChildrenCtrls;

	private bool m_IsExpand;

	private List<UGCTimelineEditorKeyBase> m_linkKeyFrame;

	public UGCTimelineEditorTrackBaseWarp CurrTrack => null;

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

	public override void Hide()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnClickBackHandler()
	{
	}

	private void OnRefreshKeyFrameValueHandler(object[] data)
	{
	}

	public void RefreshClipsWarning()
	{
	}

	public void RefreshData()
	{
	}

	public void CheckSelectKeyFrame(float time)
	{
	}

	private void OnPressSideClip(UGCTimelineDragClipSideBar.SiderBarDire dire, KeyClip keyClip, bool isPress)
	{
	}

	private void OnDraggingSideClip(UGCTimelineDragClipSideBar.SiderBarDire dire, KeyClip keyClip)
	{
	}

	private void OnPressKeyFrame(Keyframe keyframe, bool isPress)
	{
	}

	private void OnPressClip(KeyClip keyClip, bool isPress)
	{
	}

	private void OnDraggingKeyFrame(Keyframe keyframe)
	{
	}

	private void OnDraggingClip(KeyClip keyClip)
	{
	}

	public void RefreshSubTrack()
	{
	}

	private void OnRecordStateHandler(bool data)
	{
	}

	public void RefreshBestTickInterval(float tickInterval)
	{
	}

	private void OnClickKeyFrame(UGCTimelineEditorKeyBase keyFrameData)
	{
	}

	public void SetUICallback(Action<UGCTimelineEditorTrackBaseWarp, UGCTimelineEditorKeyBase> action)
	{
	}

	private void SetSelectKeyFrame(UGCTimelineEditorKeyBase keyFrameData)
	{
	}

	public void SetTrackData(UGCTimelineEditorTrackBaseWarp currTrack)
	{
	}

	private float PixelToTime(float pixelX)
	{
		return 0f;
	}

	private Vector3 GetKeyFramePostion(float startTime)
	{
		return default(Vector3);
	}

	public void SetExpandSubTrack(bool expand)
	{
	}

	public UIHudSceneEditTimelineTrackController GetControllerByTrack(UGCTimelineEditorTrackBaseWarp trackWarp)
	{
		return null;
	}

	private KeyClip _003CRefreshData_003Eb__21_1()
	{
		return null;
	}

	private Keyframe _003CRefreshData_003Eb__21_0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
