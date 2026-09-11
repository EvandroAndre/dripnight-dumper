using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarV2RoundResultController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003CCreateBgVFX_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIClanWarV2RoundResultController _003C_003E4__this;

		private GameObject _003Cres_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreateBgVFX_003Ed__20(int _003C_003E1__state)
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

	private UIClanWarV2RoundResultView m_View;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UIModelClanWarV2 m_ModelClanWar;

	private uint m_CachedBoardIDV2;

	private ulong m_LeaderBoardID;

	private GameObject m_BgVfx;

	private ResourceID m_BgVfxRes;

	private Coroutine m_Cor;

	private const int EFFECT_WIDGET_DEPTH = 1;

	private Vector3 m_ScreenShotPos;

	private Vector3 m_OriginalPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void SetViewData(uint season, uint round)
	{
	}

	private void RefreshTitleIcon()
	{
	}

	private void RefreshScoreAndPercentage()
	{
	}

	private void RefreshRankChange()
	{
	}

	private IEnumerator CreateBgVFX()
	{
		return null;
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnEquipmentBtnClick()
	{
	}

	private void UpdateShareBtnAnchor()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
