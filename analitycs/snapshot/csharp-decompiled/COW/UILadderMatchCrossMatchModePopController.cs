using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UILadderMatchCrossMatchModePopController : UIPopupWindowController
{
	private sealed class _003CSetPosition_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILadderMatchCrossMatchModePopController _003C_003E4__this;

		public Vector3 itempos;

		private Transform _003CcontentTr_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__12(int _003C_003E1__state)
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

	private UILadderMatchCrossMatchModePopView m_View;

	private const float m_HeightSpace = 40f;

	private UIRoot m_UIRoot;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelLadderMatch m_ModelLadderBR;

	private UICrossMatchModeRankInfoController m_HeroicCrossModeInfoCtrl;

	private UICrossMatchModeRankInfoController m_MasterCrossModeInfoCtrl;

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

	public void SetViewData(uint curRank, DLBMPCCFKKM ladderMatchType, Vector3 itempos)
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
