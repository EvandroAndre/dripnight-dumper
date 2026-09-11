using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.Playables;

namespace COW;

public abstract class UIGachaContentCustomizedBackgroundBaseController : UIBaseController, IUIModelDataChangeObserver
{
	public class BackgroundVFX
	{
		public class ActiveAgent
		{
			private bool m_IsPendingActive;

			public Action ActionAfterGOInit;

			private GameObject m_GO;

			public bool IsPendingActive => false;

			public GameObject GO => null;

			public void InitGameObject(GameObject go)
			{
			}

			public bool SetActive(bool active)
			{
				return false;
			}

			public void Clear()
			{
			}
		}

		private ActiveAgent m_GO;

		private PlayableDirector m_PD;

		private double m_PDLength;

		private uint m_PDFinishDelayCall;

		public Action ActionOnShow;

		public Action ActionOnFinish;

		private ResourceID m_ResID;

		private bool _003CIsDummyVFX_003Ek__BackingField;

		private Transform m_Parent;

		private bool m_IsAsyncLoad;

		private uint m_Ticket;

		private bool m_IsPendingInitAfterDownload;

		public GameObject GO => null;

		public ResourceID ResID => default(ResourceID);

		public bool IsDummyVFX
		{
			get
			{
				return _003CIsDummyVFX_003Ek__BackingField;
			}
			private set
			{
				_003CIsDummyVFX_003Ek__BackingField = value;
			}
		}

		public BackgroundVFX(ResourceID resID, Transform parent, bool isAsyncLoad = false, bool isDelayInit = false)
		{
		}

		public BackgroundVFX(Transform parent, double length)
		{
		}

		private void InitGameObject()
		{
		}

		private void InitGameObjectInternal(GameObject go, Transform parent)
		{
		}

		public bool SetActive(bool active)
		{
			return false;
		}

		public void SetActionAfterGOInit(Action action)
		{
		}

		public void ReplayTimeline(double time = 0.0)
		{
		}

		public double GetCurTimelineTime()
		{
			return 0.0;
		}

		public void InitGameObjectAfterDownload()
		{
		}

		public void TryDestroyGameObjectWhenNeedDownloadAgain()
		{
		}

		public void Clear()
		{
		}

		private void _003CInitGameObject_003Eb__22_0(uint ticket, bool success, UnityEngine.Object obj)
		{
		}

		private void _003CReplayTimeline_003Eb__26_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public UIGachaContentCustomizedBackgroundBaseController _003C_003E4__this;

		public EGachaCustomizedBackgroundVFXType type;

		public int index;

		public bool forceRefresh;

		internal void _003CShowVFX_003Eb__0()
		{
		}
	}

	public const float END_PREVIEW_PRIVILEGE_DELAY_TIME = 3f;

	protected UIGachaContentCustomizedBackgroundView m_View;

	protected UIModelGacha m_ModelGacha;

	protected uint m_GachaID;

	protected bool m_IsNeedDownloadRes;

	protected bool m_IsPlayCGActively;

	protected bool m_IsPlayingCG;

	protected Dictionary<uint, List<BackgroundVFX>> m_VFXDict;

	protected EGachaCustomizedBackgroundVFXType m_CurVFXType;

	protected BackgroundVFX m_CurVFX;

	protected BackgroundVFX m_PendingVFX;

	protected int m_CurVFXIndex;

	protected Vector3 m_OriginalMaskLabelPosition;

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

	protected override void OnVisibilityChanged()
	{
	}

	public abstract void SetViewData(uint gachaID = 0u);

	protected abstract void OnMaskBtnClick();

	protected abstract void OnCGPlay();

	protected abstract void OnCGStop();

	protected abstract void OnVFXShow();

	protected abstract void OnVFXHide();

	public void SetMaskBtnVisible(bool visible, bool isShowLabel = true)
	{
	}

	public void SetMaskLabelPosition(Vector3 position)
	{
	}

	public void SetMaskLabelText(string key)
	{
	}

	private void OnGetLoadingCardInitPosition(object[] param)
	{
	}

	public void ShowPrivilegeMaskView(Vector3? labelPosition = null, bool isLoadingCard = false)
	{
	}

	public void HidePrivilegeMaskView()
	{
	}

	public void PlayCG(object[] param)
	{
	}

	public void StopPlayCG()
	{
	}

	private void LoadAndPrepareCG(ResourceID resID)
	{
	}

	private void OnCGPrepared()
	{
	}

	private void OnCGEnded()
	{
	}

	private void LogEventTypeFullScreenAnimation()
	{
	}

	private void SetupCGRenderer()
	{
	}

	public virtual void ShowVFX(EGachaCustomizedBackgroundVFXType type, int index = 0, bool forceRefresh = false)
	{
	}

	public void HideVFX()
	{
	}

	public List<ResourceID> GetNeedDownloadResList()
	{
		return null;
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
