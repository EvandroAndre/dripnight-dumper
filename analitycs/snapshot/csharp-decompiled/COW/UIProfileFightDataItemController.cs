using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileFightDataItemController : UIBaseController
{
	private sealed class _003CStartPlayAnim_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIProfileFightDataItemController _003C_003E4__this;

		private List<GameObject> _003Cm_currgameobj_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartPlayAnim_003Ed__48(int _003C_003E1__state)
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

	private UIProfileFightDataItemView m_View;

	private Vector3[] m_5DMapMeshVetex;

	private float[] m_NormalizedValue;

	private float[] m_OriginalValue;

	private List<GameObject> VFXObjectList;

	private List<UILabel> VfxLabelList;

	private List<GameObject> VFXObjectList2;

	private List<GameObject> VFXObjectList3;

	private List<Transform> VFXTransformList;

	private const int m_5DMapLength = 72;

	private Vector3[] m_3DMapMeshVetex;

	private float[] m_3DNormalizedValue;

	private float[] m_3DOriginalValue;

	private List<GameObject> CSVFXObjectList;

	private List<GameObject> CSVFXObjectList2;

	private List<GameObject> CSVFXObjectList3;

	private List<Transform> CSVFXTransformList;

	private const int m_3DMapLength = 59;

	private static Vector3 m_MapCenterOffset;

	private bool m_CanStartDraw5DMap;

	private bool m_CanStartDraw3Dmap;

	private uint m_type;

	private EModeType m_ModeType;

	private uint m_CurrentFightMode;

	private bool m_DetailDataPanelOpen;

	private uint m_DisbleCall;

	private uint m_DelayCallID;

	private uint m_DelayArrowId;

	private ProfileDataPunishSwitchConfig m_ProfileDataPunishConfig;

	private UIProfileMiniRankInfoController m_MiniRankInfoCtrl;

	private List<GameObject> m_ShowInfoList;

	public void SetProfileDataMasked(bool masked)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void InitVfxList2Label()
	{
	}

	private void InitVfxState()
	{
	}

	private void InitCsVfxState()
	{
	}

	private void CommonCallback()
	{
	}

	public void PlayCommonVfx()
	{
	}

	private void CSCallback()
	{
	}

	public void PlayCsVfx()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnDisableBtn(object[] data)
	{
	}

	private void OnCSRankRatingTipClick()
	{
	}

	private void OnRankRatingTipClick()
	{
	}

	private void OnDetailBtnClick()
	{
	}

	public void SetModeType(EModeType modeType)
	{
	}

	public void RefreshOneItemShowUI(uint type)
	{
	}

	private IEnumerator StartPlayAnim()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void RefreshTopLabel(int num)
	{
	}

	public void HideDetailPanel()
	{
	}

	public void ShowDetailPanel()
	{
	}

	public void RefreshProfileFightDataItemUI(uint type, PersonalRecordData data)
	{
	}

	public void SetCommonModeUI()
	{
	}

	public void DisableVFx()
	{
	}

	public void RefreshVfxState()
	{
	}

	private void Show5DimensionalMap(float[] fieldDatas, string[] fieldNames)
	{
	}

	private void ShowProfileFightDataItemUI(PersonalRecordData data, uint type)
	{
	}

	private void RefreshRating(double rating, uint medalGoldNumber, uint medalSilverNumber)
	{
	}

	private Vector3 SetVertexPos(int index, float normalizedValue)
	{
		return default(Vector3);
	}

	private Vector3 SetCSVertexPos(int index, float normalizedValue)
	{
		return default(Vector3);
	}

	public void RefreshPeriodicRankingData(CSPlayerPeriodicRankingInfoRes info)
	{
	}

	public void RefreshCSRankingData(CSLadderSeasonStatsInfo info)
	{
	}

	public void RefreshCSPeakTournamentData(PlayerCSPeakSeasonStats info)
	{
	}

	private void Set3DVertexData(float csleader, float cssupport, float cskill, float csdamage, float csparticipation)
	{
	}

	private void DrawFiveDMap()
	{
	}

	private void DrawThreeDMap()
	{
	}

	private void DrawLine(UISprite linesp, Vector3 startpos, Vector3 endpos)
	{
	}

	public void SetCurrentMode(uint mode)
	{
	}

	private void LateUpdate()
	{
	}

	private void PlayAnim(bool Forward)
	{
	}

	public void ResetArrowState()
	{
	}

	public void ResetState()
	{
	}

	public void RefreshOneItemShowUI()
	{
	}

	private void _003COnDisableBtn_003Eb__42_0()
	{
	}

	private void _003CResetArrowState_003Eb__72_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
