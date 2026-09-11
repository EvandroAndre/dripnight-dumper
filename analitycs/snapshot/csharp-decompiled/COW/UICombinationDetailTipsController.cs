using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICombinationDetailTipsController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<uint> _003C_003E9__14_0;

		public static Converter<uint, object> _003C_003E9__14_1;

		public static Predicate<uint> _003C_003E9__14_2;

		public static Converter<uint, object> _003C_003E9__14_3;

		internal bool _003CSetDailyFirstWinViewData_003Eb__14_0(uint i)
		{
			return false;
		}

		internal object _003CSetDailyFirstWinViewData_003Eb__14_1(uint s)
		{
			return null;
		}

		internal bool _003CSetDailyFirstWinViewData_003Eb__14_2(uint i)
		{
			return false;
		}

		internal object _003CSetDailyFirstWinViewData_003Eb__14_3(uint s)
		{
			return null;
		}
	}

	private sealed class _003CSetPosition_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICombinationDetailTipsController _003C_003E4__this;

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

	private UICombinationDetailTipsView m_View;

	private List<UILabel> m_Labels;

	private List<GameObject> m_LabelContainer;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelLadderMatch m_ModelLadderMatch;

	private List<UIStandardItemMiniController> m_RewardItemCtrlList;

	private const float m_HeightSpace = 40f;

	private UIRoot m_UIRoot;

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

	public void SetViewData(uint matchMode, bool needFirstWinTip, bool needDoubleWinTip, Dictionary<uint, string> labelDescrips, Dictionary<uint, List<ResourceID>> spriteResIds, Vector3 itempos, uint maxCount, bool showSlayDragBuff = false)
	{
	}

	private void SetDoubleWinViewData(bool needDoubleWinTip, uint matchMode)
	{
	}

	private void SetDailyFirstWinViewData(bool needFirstWinTip, uint matchMode)
	{
	}

	private void SetDailyTaskReward(List<BaseItemInfo> lst)
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
