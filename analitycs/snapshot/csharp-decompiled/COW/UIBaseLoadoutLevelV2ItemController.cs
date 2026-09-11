using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal abstract class UIBaseLoadoutLevelV2ItemController : UIEasyListItemController
{
	private sealed class _003CStartPlayArrowEffect_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int index;

		public UIBaseLoadoutLevelV2ItemController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartPlayArrowEffect_003Ed__11(int _003C_003E1__state)
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

	protected UISprite m_Icon;

	protected UILabel m_Desc;

	protected Transform m_Level;

	protected GameObject m_LockContainer;

	private UIModelLoadout m_Model;

	private uint m_Ability;

	private UILoadoutV2ItemLevelProgressController m_LevelProgressCtrl;

	protected override void OnUIInit()
	{
	}

	protected abstract void InitView();

	public override void SetViewData(object data, int data_index)
	{
	}

	public void PlayArrowEffect(int index)
	{
	}

	private IEnumerator StartPlayArrowEffect(int index)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
