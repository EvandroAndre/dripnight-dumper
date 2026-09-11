using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIGameModeRankInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CLoadVFX_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeRankInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadVFX_003Ed__21(int _003C_003E1__state)
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

	private sealed class _003CShowNewSeasonAnim_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeRankInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowNewSeasonAnim_003Ed__39(int _003C_003E1__state)
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

	private sealed class _003CShowSeasonEndAnim_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeRankInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowSeasonEndAnim_003Ed__41(int _003C_003E1__state)
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

	private UIGameModeRankInfoView m_View;

	private List<MapModeData> m_Data;

	private UIModelLadderMatch m_ladderModel;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelInventory m_ModelInventory;

	private float m_BrRp;

	private bool m_MapProtection;

	private bool m_IfConfigMapProtection;

	private bool m_VFXLoadFinish;

	private uint m_AsyncTicket;

	private Coroutine m_LoadVFXCoroutine;

	private IEnumerator m_NewSeaonCoroutine;

	private IEnumerator m_SeasonEndCoroutine;

	private MapModeData m_SelectedMapModeData;

	private bool m_IsSeasonCountDown;

	private const string SHOW_SEASON_TIPS = "Season_Restart_tips";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnAsyncLoadEffectFinish(uint ticket, bool success, UnityEngine.Object obj)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator LoadVFX()
	{
		return null;
	}

	private void RefreshRankProtection()
	{
	}

	public void SetUIData(List<MapModeData> data, bool showRankContainer)
	{
	}

	private void SetSelectedMapUIData(MapModeData data)
	{
	}

	public bool IsTagActive()
	{
		return false;
	}

	public int GetHelpButtonPanelDepth()
	{
		return 0;
	}

	public void SetHelperButtonDepth(int depth)
	{
	}

	private void OnMapChangeButtonClicked()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshView(object[] data)
	{
	}

	private void OnBonusBtnClick()
	{
	}

	private void OnSeasonBtnClick()
	{
	}

	private void RefreshNewMapProtection()
	{
	}

	private void RefreshMapInfo()
	{
	}

	private void UpdateGamePatternUI()
	{
	}

	private void RefreshLeftTipsView()
	{
	}

	public void RefreshSeasonStartView()
	{
	}

	private IEnumerator ShowNewSeasonAnim()
	{
		return null;
	}

	public void RefreshSeasonEndView()
	{
	}

	private IEnumerator ShowSeasonEndAnim()
	{
		return null;
	}

	public void SetNewSeasonTipsState(bool show)
	{
	}

	public void SetSeasonEndTipsState(bool show)
	{
	}

	private void RefreshSeasonEndCountDownView()
	{
	}

	public void RefreshSeasonSwitchView(bool isShow)
	{
	}

	private void RefreshSeasonInfo()
	{
	}

	private void RefreshBRRadioLabel()
	{
	}

	private void RefreshBonus()
	{
	}

	private void OnHelpBtnCLick()
	{
	}

	private void ShowHelpBtn(MapModeData data)
	{
	}

	private void _003CRefreshSeasonEndCountDownView_003Eb__44_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
