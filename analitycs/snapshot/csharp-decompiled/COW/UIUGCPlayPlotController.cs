using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCPlayPlotController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CStartTyping_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCPlayPlotController _003C_003E4__this;

		public string content;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartTyping_003Ed__15(int _003C_003E1__state)
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

	private UIUGCPlayPlotView m_View;

	private UIModelUGCPlotEdit m_Model;

	private bool m_IsTyping;

	private string m_TypingContent;

	private bool m_HasOption;

	private Coroutine m_TypingCoroutine;

	private UIAtlas m_ActorOriginAtlas;

	private UISpriteData m_ActorOriginSpriteData;

	private List<UIUGCPlayPlotOptionItemController> m_OptionControllers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnBtnContinueClick()
	{
	}

	private void OnBtnSkipClick()
	{
	}

	private IEnumerator StartTyping(string content)
	{
		return null;
	}

	private void OnLocalPlayerDead()
	{
	}

	private void _003COnDataChanged_003Eb__12_0(UIAtlas atlas, string spriteName)
	{
	}

	private void _003COnDataChanged_003Eb__12_1(UIAtlas atlas, string spriteName)
	{
	}

	private void _003COnDataChanged_003Eb__12_2(UIAtlas atlas, string spriteName)
	{
	}

	private void _003COnDataChanged_003Eb__12_3(UIAtlas atlas, string spriteName)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
