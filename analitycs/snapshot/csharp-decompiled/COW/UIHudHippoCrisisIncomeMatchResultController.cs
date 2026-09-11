using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudHippoCrisisIncomeMatchResultController : UIPopupWindowController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<HippoCrisisOutGameItemUIData> _003C_003E9__16_0;

		internal int _003CSetResultData_003Eb__16_0(HippoCrisisOutGameItemUIData a, HippoCrisisOutGameItemUIData b)
		{
			return 0;
		}
	}

	private sealed class _003CCoShowScore_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float sec;

		public UIHudHippoCrisisIncomeMatchResultController _003C_003E4__this;

		public uint statrValue;

		public uint endValue;

		private float _003CcurrentStep_003E5__2;

		private float _003CstepDuration_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShowScore_003Ed__22(int _003C_003E1__state)
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

	private sealed class _003CCoSpawnItem_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<HippoCrisisOutGameItemUIData> showItems;

		public UIHudHippoCrisisIncomeMatchResultController _003C_003E4__this;

		private int _003CcurCnt_003E5__2;

		private int _003CmaxItemCnt_003E5__3;

		private uint _003CcurScore_003E5__4;

		private int _003CselectCnt_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSpawnItem_003Ed__21(int _003C_003E1__state)
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

	private UIHudHippoCrisisIncomeMatchResultView m_View;

	private UIHippoCrisisItemBriefBoxController m_ItemBriefBoxController;

	private MatchStats m_Stats;

	private List<HippoCrisisOutGameItemUIData> m_IncomeItems;

	private Dictionary<uint, Transform> m_ScoreLevelToEffect;

	private Transform m_CurScoreLevelEffect;

	private Dictionary<uint, Transform> m_ItemLevelToEffect;

	private Transform m_CurItemLevelEffect;

	private bool m_IsPlayingScoreLevelEffect;

	private Animation m_GradeLevelUpAnim;

	private string m_GradeLevelUpAnimName;

	private ResourceID m_LastGradeIconResID;

	private Dictionary<uint, ResourceID> m_ScoreLevelToAudioSource;

	private UIMaleAvatar m_Avatar;

	private IEnumerator m_SpawnItemCoroutine;

	private IEnumerator m_ScoreCoroutine;

	private uint m_CurScoreLevel;

	private int m_ScoreIncreaseStep;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetResultData(MatchIncome incomeData, MatchStats statsData, UIMaleAvatar avatar)
	{
	}

	private IEnumerator CoSpawnItem(List<HippoCrisisOutGameItemUIData> showItems)
	{
		return null;
	}

	private IEnumerator CoShowScore(float sec, uint statrValue, uint endValue)
	{
		return null;
	}

	private float GetShowSingleItemTimeByLevel(int level)
	{
		return 0f;
	}

	private void PlayGradeLevelUpAnimToEnd()
	{
	}

	private void ShowGradeIcon(uint score, bool playAnim)
	{
	}

	private void SkipAnim()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnNextBtnClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	UIEasyListItemController IEasyList.OpenItemController(Transform parent)
	{
		return null;
	}

	void IEasyList.CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void ShowItemBriefBox(object[] param)
	{
	}

	public UITexture GetBG()
	{
		return null;
	}

	public override void AfterScreenshot()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	private bool IsDoubleWeild(WeaponSkinData data)
	{
		return false;
	}

	private void ShowGunAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}
}
