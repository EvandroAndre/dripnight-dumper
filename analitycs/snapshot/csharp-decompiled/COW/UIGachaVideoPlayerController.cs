using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIGachaVideoPlayerController : UINavigationController
{
	private sealed class _003CCoDelayPlayELS_TT53CGSound_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDelayPlayELS_TT53CGSound_003Ed__31(int _003C_003E1__state)
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

	private sealed class _003CCoForcePlayerWatchVideo_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaVideoPlayerController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoForcePlayerWatchVideo_003Ed__28(int _003C_003E1__state)
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

	private UIGachaVideoNavigationView m_View;

	private UIModelGacha m_ModelGacha;

	private bool m_IsPlayActively;

	private uint m_GachaId;

	private Action m_OnFinish;

	private const string ForcePlayerWatchCG = "ForcePlayerWatchCG_{0}_{1}";

	private bool m_EnableForceWatch;

	private float m_ForceWatchTime;

	private bool m_IsPlayByGachaFeature;

	private ResourceID m_ResourceID;

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

	public override bool IgnoreEsc()
	{
		return false;
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	public void SetEnableForceWatchTime(float time)
	{
	}

	public void SetOnFinished(Action onfinish)
	{
	}

	public void SetIsPlayByGachaFeature(bool isPlayByGachaFeature)
	{
	}

	public bool IsBlockAchievementTips()
	{
		return false;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void LoadAndPrepare()
	{
	}

	private void OnVideoPrepared()
	{
	}

	private void OnVideoEnded()
	{
	}

	private void OnVideoMaskBtnClick()
	{
	}

	private void LogEventTypeFullScreenAnimation()
	{
	}

	public void OnPauseVideo(bool paused)
	{
	}

	public void StartPlay()
	{
	}

	private void ForcePlayerWatchVideo()
	{
	}

	private IEnumerator CoForcePlayerWatchVideo()
	{
		return null;
	}

	public void SetupRenderer()
	{
	}

	private void TryDelayPlayELS_TT53CGSound()
	{
	}

	private IEnumerator CoDelayPlayELS_TT53CGSound()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
