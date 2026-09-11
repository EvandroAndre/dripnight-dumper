using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSPrizePoolPreviewController : UIPreviewPopUpWindowController, UIModelNinthSYS.IAwardPoolPreview, UIModelNinthSYS.IRewardPreview
{
	private sealed class _003CInitDepthCoroutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINinthSYSPrizePoolPreviewController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitDepthCoroutine_003Ed__25(int _003C_003E1__state)
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

	private UINinthSYSPrizePoolPreviewView m_View;

	private UIModelNinthSYS m_ModelNinthSYS;

	private List<UIModelNinthSYS.IAwardPoolDesc> m_AwardPoolDescList;

	private UIModelNinthSYS.ProgressAwardDesc m_ProgressAwardDesc;

	private UIModelNinthSYS.SeparatorAwardDesc m_SeparatorAwardDesc;

	private UINinthSYSPrizePoolProgressController m_ProgressController;

	private UINinthSYSPrizePoolSeparatorController m_SeparatorController;

	private UIModelNinthSYS.AwardPoolSelectedData m_SelectedData;

	private readonly Vector2 TITLE_SIZE;

	private readonly Vector2 ITEM_SIZE;

	private ulong m_StartShowTime;

	private Coroutine m_InitDepthCoroutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public UIModelNinthSYS.AwardPoolSelectedData GetAwardPoolSelectedData()
	{
		return default(UIModelNinthSYS.AwardPoolSelectedData);
	}

	public void OnPreviewClick(UIModelNinthSYS.AwardPoolSelectedData data)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}

	private void SetBackground()
	{
	}

	public override void OnNavigationBack()
	{
	}

	protected override void OnInitDepth()
	{
	}

	private IEnumerator InitDepthCoroutine()
	{
		return null;
	}

	private void LogClick(string posfix)
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private BaseItemInfo GetItemInfo()
	{
		return null;
	}

	private void InitTable2Template()
	{
	}

	private void InitRewardPoolView()
	{
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__29_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__29_1()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationBack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitDepth()
	{
	}
}
