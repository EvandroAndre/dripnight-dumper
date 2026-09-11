using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudMatchResultBaseRewardController : UIBaseController
{
	private sealed class _003CScrollCount_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<uint> targetCounts;

		public List<UILabel> targetLabels;

		public UIHudMatchResultBaseRewardController _003C_003E4__this;

		public List<TweenScale> tweenScales;

		public List<TweenColor> tweenColors;

		public List<GameObject> vfxs;

		private int _003CscrollCount_003E5__2;

		private StringBuilder[] _003Csb_003E5__3;

		private string[] _003ColdValue_003E5__4;

		private string[] _003CnewValue_003E5__5;

		private int[] _003CcurNum_003E5__6;

		private float _003ClerpValue_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollCount_003Ed__7(int _003C_003E1__state)
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

	private UIHudMatchResultBaseRewardView m_View;

	private UIHudMatchResultDetailController m_DetailCtrl;

	private MatchIncome m_MatchIncome;

	private MatchStats m_MatchStats;

	private ulong m_MatchEndTimeStamp;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void ShowRewardData(MatchIncome income, MatchStats stats, ulong timeStamp)
	{
	}

	private IEnumerator ScrollCount(List<uint> targetCounts, List<UILabel> targetLabels, List<GameObject> vfxs, List<TweenColor> tweenColors, List<TweenScale> tweenScales)
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnClickDetailBtn()
	{
	}

	private void OnClickDetailMaskBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
