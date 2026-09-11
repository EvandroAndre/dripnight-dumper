using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILadderPlayerFullScreenAnimation : MonoBehaviour
{
	public delegate void PlayNextAni();

	private sealed class _003CPlayerFullScreenAnimation_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILadderPlayerFullScreenAnimation _003C_003E4__this;

		private float _003CaniamtionTime_003E5__2;

		private AnimationClip _003Cclip_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayerFullScreenAnimation_003Ed__14(int _003C_003E1__state)
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

	private Animation m_FullScreenAnimationContainer;

	private string ANIMATION_RANK_GREATE_UP;

	private bool isBr;

	private GameObject aniGo;

	public PlayNextAni OnPlayNextAni;

	public bool beginNext;

	public float NextAniStartTime;

	public float TimePlayCrossModeAnim;

	public Action PlayCrossModeAnim;

	public bool IsPlayCrossModeAnim;

	private UILadderAnimationParam animationParam;

	public void InstantiatePrefabAni(Transform aniTrans, ResourceID resID, string clipName, int depth)
	{
	}

	public void InitAniParam(string beforeRankName, string afterRankName, ResourceID beforeRankIcon, ResourceID afterRankIcon, bool isBr = true)
	{
	}

	public IEnumerator PlayerFullScreenAnimation()
	{
		return null;
	}

	private void Update()
	{
	}
}
