using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisMapMarkController : UIHudNameBaseController
{
	private sealed class _003CShowNoticeEffect_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMetropolisMapMarkController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowNoticeEffect_003Ed__16(int _003C_003E1__state)
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

	private UIHudMetropolisMapMarkView m_View;

	private UITimeLabelHelper m_TimeHelper;

	private Color NORMAL_COLOR;

	private Color AREA_INUSE_COLOR;

	private Color AREA_OPEN_COLOR;

	private Color AREA_FREEZE_COLOR;

	private CLKBJIJFFOK m_Info;

	private NNIBLMANMOD m_AreaPointType;

	private bool m_ShowProgress;

	private Vector3 m_TrackPosition;

	private Coroutine m_NoticeCoroutine;

	public uint AreaID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetTrackAreaUI(CLKBJIJFFOK info, NNIBLMANMOD pointType = NNIBLMANMOD.None)
	{
	}

	public void PlayNoticeEffect()
	{
	}

	private IEnumerator ShowNoticeEffect()
	{
		return null;
	}

	public void SetTrackPosition(Vector3 pos)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	public void UpdateState()
	{
	}

	public void UpdateAreaStateEndTime()
	{
	}

	private void ChangeColor(Color color)
	{
	}

	public void Update()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}
}
