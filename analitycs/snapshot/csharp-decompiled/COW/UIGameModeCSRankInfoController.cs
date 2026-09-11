using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIGameModeCSRankInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CLoadVFX_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeCSRankInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadVFX_003Ed__31(int _003C_003E1__state)
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

	private sealed class _003CShowNewSeasonAnim_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeCSRankInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowNewSeasonAnim_003Ed__60(int _003C_003E1__state)
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

	private sealed class _003CShowSeasonEndAnim_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeCSRankInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowSeasonEndAnim_003Ed__62(int _003C_003E1__state)
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

	private UIGameModeCSRankInfoView m_View;

	private List<MapModeData> m_Data;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelLadderMatch m_LadderModel;

	private UIModelInventory m_ModelInventory;

	private UIModelGroup m_ModelGroup;

	private MapModeData m_SelectedMapModeData;

	public UIGameModeBaseItemController m_ParentController;

	private UIGameModeCSRankSpecialPlayController m_UIGameModeCSRankSpecialPlayController;

	private UIGameModeNewPlayerUnlockFeatureController m_NewPlayerUnlockFeatureCtrl;

	private UICSRankIconController m_CSRankIconController;

	private bool m_MapProtection;

	private bool m_IfConfigMapProtection;

	private bool m_IsCsSeasonCountDown;

	private IEnumerator m_NewSeaonCoroutine;

	private IEnumerator m_SeasonEndCoroutine;

	private bool m_VFXLoadFinish;

	private uint m_AsyncTicket;

	private Coroutine m_LoadVFXCoroutine;

	private string m_MapProtectTipsStr;

	private List<ResourceID> m_MapProtectResIDs;

	private ResourceID m_ProtectPointsBonusResIDs;

	private const string CSSpecialMatchTutorialUrl = "CSSpecialTutorial";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
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

	public void AdjustPanelDepthWithBase(int dropdownBaseDepth)
	{
	}

	public void SetUIData(List<MapModeData> data, bool showRankContainer)
	{
	}

	public void RefreshView(object[] data)
	{
	}

	private void UpdateGamePatternUI()
	{
	}

	public void CollapseCSRankSpecialPlayDropdown()
	{
	}

	private void PrepareCSRankSpecialMatchUI()
	{
	}

	public void UpdateCSRankSpecialUI()
	{
	}

	public void UpdateNewPlayerUnlockFeatureUI()
	{
	}

	public void UpdateCSRankSpecialMatchUI()
	{
	}

	private bool CheckLockMaskIsShow()
	{
		return false;
	}

	private void UpdateCSDataInfo()
	{
	}

	private void RefreshRankProtection()
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

	private void ShowHelpBtn(MapModeData data)
	{
	}

	private void RefreshCSLadderInfo()
	{
	}

	private void TryRefreshCSCrossModeView()
	{
	}

	private void OnHelpBtnCLick()
	{
	}

	private bool IsShowCSSpecialMatchTutorialUrl()
	{
		return false;
	}

	private void OnMapChangeBtnClick()
	{
	}

	private void OnBonusBtnClick()
	{
	}

	private void OnSeasonBtnClick()
	{
	}

	private void RefreshMapInfo()
	{
	}

	private void RefreshNewMapProtection()
	{
	}

	private void RefreshLeftTipsView()
	{
	}

	private void RefreshSeasonStartView()
	{
	}

	private IEnumerator ShowNewSeasonAnim()
	{
		return null;
	}

	private void RefreshSeasonEndView()
	{
	}

	private IEnumerator ShowSeasonEndAnim()
	{
		return null;
	}

	private void RefreshSeasonInfo()
	{
	}

	private void RefreshSeasonEndCountDownView()
	{
	}

	public void RefreshSeasonSwitchView(bool isShow)
	{
	}

	private void RefreshBonus()
	{
	}

	private void _003CRefreshSeasonEndCountDownView_003Eb__64_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
