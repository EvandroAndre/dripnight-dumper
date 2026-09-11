using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UIGachaTreatureBoxV2AnimationAssist : MonoBehaviour
{
	private sealed class _003CPlayIdelSound_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayIdelSound_003Ed__11(int _003C_003E1__state)
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

	public Animator ChestAnimator;

	public Animator CameraAnimator;

	public Transform CameraTransform;

	public Animator PanelAnimator;

	public Animator VFXAnimator;

	public GameObject VFXRoot;

	public GameObject TrailRoot;

	public List<GameObject> Corners;

	private uint m_MaxQuality;

	private bool m_PowerLoop;

	public void InityChestAnime()
	{
	}

	private IEnumerator PlayIdelSound()
	{
		return null;
	}

	public void PlayStartUnlockAnime()
	{
	}

	public void PlayEndUnlockAnime()
	{
	}

	internal void StartPowerLoop()
	{
	}

	public void PlayEndUnlockVFX()
	{
	}

	public void PlayBrushVFX()
	{
	}

	public void SetBoxQualitis(List<uint> Qualitis)
	{
	}

	private void SetVFXQuality(GameObject cornerRoot, uint quality)
	{
	}

	private void SetTrailQuality(GameObject cornerRoot, uint quality)
	{
	}

	private void SetCornerQuality(GameObject cornerRoot, uint quality)
	{
	}
}
