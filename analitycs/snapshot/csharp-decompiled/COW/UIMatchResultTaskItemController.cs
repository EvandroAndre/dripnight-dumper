using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIMatchResultTaskItemController : UIEasyListItemController, UITable2.IUITable2Item
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BundleShowData, BaseItemInfo> _003C_003E9__17_0;

		internal BaseItemInfo _003CSetViewData_003Eb__17_0(BundleShowData temp)
		{
			return null;
		}
	}

	private sealed class _003CPlayAnim_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMatchResultTaskItemController _003C_003E4__this;

		public bool isShowGainedAni;

		private float _003ClerpValue_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAnim_003Ed__22(int _003C_003E1__state)
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

	private UIMatchResultTaskItemView m_View;

	private uint m_CurrentValue;

	private uint m_BeforeValue;

	private uint m_TargetValue;

	private Coroutine m_PlayAnimCoroutine;

	private bool m_PlayAnim;

	private MatchResultTaskInfo m_InfoData;

	private UIStandardItemMiniController m_AwardCtrl1;

	private UIStandardItemMiniController m_AwardCtrl2;

	private List<UIStandardItemMiniController> m_StandardItemMiniControllers;

	private bool OnDisableAlreadyHandleFlag;

	private const string TaskProgressStringFormat = "[ffffff]{0}[ababab]/{1}";

	private readonly string[] m_TaskTypeIcon;

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

	private void OnSpecialBtnClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetSlayDragonTaskView(MatchResultTaskType type)
	{
	}

	private void SetDataCommon(MatchResultTaskInfo infoData)
	{
	}

	private void SetTemplateTaskView(MatchResultTaskInfo infoData)
	{
	}

	private void SetChallengeData(MatchResultTaskInfo infoData)
	{
	}

	private IEnumerator PlayAnim(bool isShowGainedAni)
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
