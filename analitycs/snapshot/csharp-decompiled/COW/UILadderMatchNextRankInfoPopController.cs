using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UILadderMatchNextRankInfoPopController : UIPopupWindowController
{
	private sealed class _003CSetPosition_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILadderMatchNextRankInfoPopController _003C_003E4__this;

		public Vector3 itempos;

		private Transform _003CcontentTr_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__16(int _003C_003E1__state)
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

	private UILadderMatchNextRankInfoPopView m_View;

	private UIRoot m_UIRoot;

	private const float m_HeightSpace = 40f;

	private UIModelLadderMatch m_ModelLadderBR;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelHippoCrisisLadderMatch m_ModelHippoCrisis;

	private LadderConfigDataManager m_LadderConfigDataManager;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetViewData(uint curRank, uint curPeakRankPos, DLBMPCCFKKM ladderMatchType, Vector3 itempos)
	{
	}

	private void RefreshBRData(uint curRank, uint curPeakRankPos)
	{
	}

	private void RefreshCSData(uint curRank, uint curPeakRankPos)
	{
	}

	private void RefreshHippoCrisisData(uint curRank)
	{
	}

	private void OnRankInfoBtnClick()
	{
	}

	private IEnumerator SetPosition(Vector3 itempos)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
