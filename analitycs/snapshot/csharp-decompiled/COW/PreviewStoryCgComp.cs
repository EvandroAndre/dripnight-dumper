using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class PreviewStoryCgComp : PreviewBaseComponent
{
	public enum FULLCG
	{
		IceAge = 101,
		BioManiac,
		FlyWing
	}

	private sealed class _003CSkipCg_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PreviewStoryCgComp _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSkipCg_003Ed__35(int _003C_003E1__state)
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

	private bool m_CgStart;

	private GameObject m_CurrentCg;

	private Camera m_CurrentCgCamera;

	public Transform CgAnimTrans;

	public Transform CGShowUITrans;

	public float LastFrame;

	public GameObject BgMask;

	public GameObject ShowMask;

	public UIButton ReturnBtn_LowerLeft;

	public UIButton ReturnBtn_UpperRight;

	private UIButton CurrentButton;

	private PreviewStoryCgShowUIComp m_previewcomp;

	private bool m_IsSubtitleBlocked;

	private bool m_IsAudioContinue;

	public UITexture BgPanel;

	public Camera m_CurrentBgCamera;

	private Dictionary<ParticleSystem, ParticleSystem.MinMaxCurve> m_CGLoopParticleSystemDelayTable;

	private uint m_type;

	private bool m_IsInSkip;

	private Action m_callback;

	public uint CurrentType => 0u;

	public Camera CurrentCGCamera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject CurrentCG
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void SetReturnBtnVisble(bool enabled)
	{
	}

	protected void Awake()
	{
	}

	public override void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	public void SetCgCameraEnable(bool enabled)
	{
	}

	private void OnbtnReturn()
	{
	}

	private void SkipAnim()
	{
	}

	private IEnumerator SkipCg()
	{
		return null;
	}

	public bool GetCgInSkip()
	{
		return false;
	}

	public void ReplayCg()
	{
	}

	private void ClearMask()
	{
	}

	public void InitCgConf(ResourceID cgresid, uint uitype, bool isHas, bool isAudioContinue = false, bool showFuncBtn = true)
	{
	}

	public void PlaySubtitle(object[] data)
	{
	}

	public void StopSubtitle(object[] data)
	{
	}

	public void ClearCG()
	{
	}

	public void PlayCg()
	{
	}

	private void DispatchEventStoryOver()
	{
	}

	public void OnCGOver(object[] data)
	{
	}

	public void StopCg(object[] data)
	{
	}

	private void SetCgMeshEffect(bool enabled)
	{
	}

	private void SetPreviewCgSpeed(int speed)
	{
	}

	private void ResetParticleSystemSpeed()
	{
	}

	private void Executecallback()
	{
	}

	private void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetFrontEndPreviewComponent(FrontEndPreviewComponent P0)
	{
	}
}
