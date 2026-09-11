using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UIFixTimeCarousel : MonoBehaviour
{
	public enum TransitionDirection
	{
		Horizontal
	}

	public delegate void CarouselItemEnterHandler(int viewDataIndex, object viewData);

	private sealed class _003CLoopTransition_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFixTimeCarousel _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoopTransition_003Ed__45(int _003C_003E1__state)
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

	private sealed class _003CTickDuringInterval_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFixTimeCarousel _003C_003E4__this;

		private float _003Caccumulated_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTickDuringInterval_003Ed__44(int _003C_003E1__state)
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

	public float IntervalSecs;

	public float TransitionSecs;

	public TransitionDirection Direction;

	public UIProgressBar ProgressBar;

	private bool m_Ready;

	private bool m_IsProgressBarBind;

	private int m_Index;

	private WaitForSeconds m_WaitForIntervalSecs;

	private WaitForSeconds m_WaitForTransitionSecs;

	private UIPanel m_Panel;

	private Transform m_CarouselContainer;

	private TweenPosition m_ContainerTweenPosition;

	private IFixTimeCarouselItem m_PrevInstance;

	private IFixTimeCarouselItem m_CurInstance;

	private Coroutine m_LoopTransitionCoroutine;

	private CarouselItemGenerator m_ItemGenerator;

	private CarouselItemEnterHandler m_ItemEnterHandler;

	private List<object> m_ViewDataList;

	public bool IsReady => false;

	public bool IsPlayed => false;

	private float IntervalOffset => 0f;

	private bool IsPlaying => false;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private bool ConfigurationCheck()
	{
		return false;
	}

	private void BindComponents()
	{
	}

	private void BindGenerator(CarouselItemGenerator generator)
	{
	}

	private void SetViewData(List<object> viewDataList)
	{
	}

	private void CreateContainer()
	{
	}

	private void CreateCarouselItems()
	{
	}

	private void TryStopTweenPosition()
	{
	}

	private void ResetPositionOnStart()
	{
	}

	private void ResetPositionOnTransition()
	{
	}

	private void PopulateOnStart()
	{
	}

	private void PopulateOnTransition(object prevViewData)
	{
	}

	private void StartTweenPosition()
	{
	}

	private void RefreshLoopingComponents(bool visible)
	{
	}

	private void NotifyCarouselItemEntered()
	{
	}

	private IEnumerator TickDuringInterval()
	{
		return null;
	}

	private IEnumerator LoopTransition()
	{
		return null;
	}

	private void TryStopLoopTransition()
	{
	}

	private void StartLoopTransition()
	{
	}

	public void Prepare(CarouselItemGenerator generator)
	{
	}

	public void Play(List<object> viewDataList)
	{
	}

	public void Resume()
	{
	}

	public void Reset()
	{
	}

	public void BindItemEnterHandler(CarouselItemEnterHandler handler)
	{
	}
}
