using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisMapAreaIconController : UIBaseController
{
	private sealed class _003CShowNoticeEffect_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMetropolisMapAreaIconController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowNoticeEffect_003Ed__12(int _003C_003E1__state)
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

	private UIHudMetropolisMapAreaIconView m_View;

	private UITimeLabelHelper m_TimeHelper;

	private CLKBJIJFFOK m_Info;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private bool m_ShowProgress;

	private Coroutine m_NoticeCoroutine;

	public uint AreaID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetAreaInfo(CLKBJIJFFOK info, UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void PlayNoticeEffect()
	{
	}

	private IEnumerator ShowNoticeEffect()
	{
		return null;
	}

	public void ShowTrackLoopEffect(bool isShow)
	{
	}

	public void HideMarkingEffect()
	{
	}

	public void UpdateState()
	{
	}

	public void UpdateAreaStateEndTime()
	{
	}

	public void UpdatePlayerCount()
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	public void SelectArea(bool select)
	{
	}

	public bool IsSelected()
	{
		return false;
	}

	public void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
