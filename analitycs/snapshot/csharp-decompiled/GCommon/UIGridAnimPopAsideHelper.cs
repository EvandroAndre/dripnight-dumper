using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIGridAnimPopAsideHelper : UIGrid
{
	public delegate void OnItemShow(int index);

	public delegate void OnItemFinish();

	private sealed class _003CMoveAfterDelay_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGridAnimPopAsideHelper _003C_003E4__this;

		public Transform t;

		public Vector3 pos;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveAfterDelay_003Ed__17(int _003C_003E1__state)
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

	public float PlayInterval;

	public AsideStyle asideStyle;

	private List<Vector3> PosChangeList;

	private List<Transform> m_aniamtions;

	private float m_LastPlayTime;

	private int m_TotalItemCnt;

	private int m_LastPlayIndex;

	private Coroutine m_ScrollCor;

	public OnItemShow onItemShow;

	public OnItemFinish onItemFinish;

	public Vector3 OutOffPos;

	public EvenStyle evenStyle;

	private bool needAnimation;

	public override void ResetPosition(List<Transform> list)
	{
	}

	private void StartAnimation(int step)
	{
	}

	private void SetItemPosition(int step, bool forcePos = false)
	{
	}

	private IEnumerator MoveAfterDelay(Transform t, Vector3 pos)
	{
		return null;
	}

	private void ApplyOriginOffset(Transform t, Vector3 pos)
	{
	}

	public override void Reposition()
	{
	}

	protected override void Start()
	{
	}

	protected override void Update()
	{
	}

	public void PlayListItemAnimQueue(UIGridAnimPopAsideItem[] itemCtrls = null)
	{
	}

	private void OnEnable()
	{
	}

	private void BeforeAnimReset(int totalItemCnt, int realIndex)
	{
	}
}
