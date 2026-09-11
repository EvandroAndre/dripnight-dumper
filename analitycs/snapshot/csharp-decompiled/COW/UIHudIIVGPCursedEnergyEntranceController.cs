using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudIIVGPCursedEnergyEntranceController : UIBaseController
{
	private sealed class _003CPlayChangeAnim_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudIIVGPCursedEnergyEntranceController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayChangeAnim_003Ed__18(int _003C_003E1__state)
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

	private sealed class _003CPlayNoticeAnim_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudIIVGPCursedEnergyEntranceController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayNoticeAnim_003Ed__15(int _003C_003E1__state)
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

	private Coroutine m_ChangeAnimCor;

	private Coroutine m_NoticeAnimCor;

	private float m_LastPlayUnlockSkillTipsTime;

	private HashSet<uint> m_UnlockSkillLevelTips;

	private VisualInstanceHolder m_UnlockHolder;

	private UIHudIIVGPCursedEnergyEntranceView m_View;

	private readonly Dictionary<int, string> m_ReasonKeyDict;

	private int m_Reason;

	private int m_ChangeNum;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void OnCurSelectSkillChange(uint skill)
	{
	}

	private void OnEquipChange(GEvent data)
	{
	}

	private void PlayNotice(string str)
	{
	}

	private IEnumerator PlayNoticeAnim()
	{
		return null;
	}

	private void ShowReason(int reason, int changeNum)
	{
	}

	private void PlayBurnEffect()
	{
	}

	private IEnumerator PlayChangeAnim()
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	private void ShowGuide()
	{
	}

	private void OnObserverChanged(object[] data)
	{
	}

	private void RefreshCursedEnergyNum(uint oldValue, uint newValue)
	{
	}

	private void RefreshUnlockSkillLevelTips()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnBtnEntranceClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
