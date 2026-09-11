using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIVirtualBrandShowCaseObtainSetController : UIBaseController
{
	private sealed class _003CPlayAnim_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIVirtualBrandShowCaseObtainSetController _003C_003E4__this;

		public bool isIn;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAnim_003Ed__14(int _003C_003E1__state)
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

	private UIVirtualBrandShowCaseObtainSetView m_View;

	private BrandShowCaseTabType m_TabType;

	private GameObject m_GainAnim;

	private const string IN_ANIM = "UIVirtualBrandShowCaseObtainSet_In";

	private const string OUT_ANIM = "UIVirtualBrandShowCaseObtainSet_Out";

	private const string WIDE_IN_ANIM = "UIVirtualBrandShowCaseObtainSet_Wide_In";

	private const string WIDE_OUT_ANIM = "UIVirtualBrandShowCaseObtainSet_Wide_Out";

	private const string ANIM_PARAM = "IsIn";

	private const float OUT_ANIM_TIME = 0.5f;

	private Coroutine m_AnimCor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint brandId, uint setId)
	{
	}

	private void OnBtnSkipClick()
	{
	}

	private IEnumerator PlayAnim(bool isIn)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
