using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISeasonReplayBattleStyleController : UIBaseController, IUISeasonReplayItem, IUIModelDataChangeObserver
{
	private struct RoleColorStruct
	{
		public Color RoleBG;

		public Color RoleBGLine;

		public Color RoleBGLight;

		public Color RoleBGLine01;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<RankingSeasonLeaderboardInfo> _003C_003E9__34_0;

		public static Predicate<OccupationHistory> _003C_003E9__39_0;

		public static Predicate<OccupationHistory> _003C_003E9__39_1;

		public static Predicate<OccupationHistory> _003C_003E9__39_2;

		public static Predicate<OccupationHistory> _003C_003E9__39_3;

		public static Predicate<OccupationHistory> _003C_003E9__39_4;

		public static Predicate<OccupationHistory> _003C_003E9__39_10;

		public static Predicate<OccupationHistory> _003C_003E9__39_11;

		public static Predicate<OccupationHistory> _003C_003E9__39_12;

		public static Predicate<OccupationHistory> _003C_003E9__39_13;

		public static Predicate<OccupationHistory> _003C_003E9__39_14;

		internal int _003CInitLeaderBoardInfo_003Eb__34_0(RankingSeasonLeaderboardInfo a, RankingSeasonLeaderboardInfo b)
		{
			return 0;
		}

		internal bool _003CInitOccupationData_003Eb__39_0(OccupationHistory x)
		{
			return false;
		}

		internal bool _003CInitOccupationData_003Eb__39_1(OccupationHistory x)
		{
			return false;
		}

		internal bool _003CInitOccupationData_003Eb__39_2(OccupationHistory x)
		{
			return false;
		}

		internal bool _003CInitOccupationData_003Eb__39_3(OccupationHistory x)
		{
			return false;
		}

		internal bool _003CInitOccupationData_003Eb__39_4(OccupationHistory x)
		{
			return false;
		}

		internal bool _003CInitOccupationData_003Eb__39_10(OccupationHistory x)
		{
			return false;
		}

		internal bool _003CInitOccupationData_003Eb__39_11(OccupationHistory x)
		{
			return false;
		}

		internal bool _003CInitOccupationData_003Eb__39_12(OccupationHistory x)
		{
			return false;
		}

		internal bool _003CInitOccupationData_003Eb__39_13(OccupationHistory x)
		{
			return false;
		}

		internal bool _003CInitOccupationData_003Eb__39_14(OccupationHistory x)
		{
			return false;
		}
	}

	private sealed class _003CPlayInAnim_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISeasonReplayBattleStyleController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayInAnim_003Ed__48(int _003C_003E1__state)
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

	private sealed class _003CShowLeaderBoardInfo_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISeasonReplayBattleStyleController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowLeaderBoardInfo_003Ed__31(int _003C_003E1__state)
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

	private RoleColorStruct[] RoleColorStructList;

	private UISeasonReplayBattleStyleView m_View;

	private UIModelSeasonReplay m_ModelSeasonReplay;

	private UIModelActivity m_ModelActivity;

	private UIModelProfile m_ModelProfile;

	private SeasonReplayThresholdData m_data;

	private float[] m_TargetValue;

	private bool m_IsBR;

	private OccupationHistory m_CurSelectOccupationInfo;

	private const int TagNum = 5;

	private const int RoleTagNum = 4;

	private const int LeaderBoardNum = 7;

	private uint m_Ticket_SEASONREPLAYBATTLESTYLEREC_UIFX;

	private uint m_Ticket_SEASONREPLAYBATTLESTYLETITLE_UIFX;

	private List<GameObject> m_LeaderBoardItems;

	private Dictionary<uint, GameObject> m_OccupationTransDic;

	private Dictionary<uint, GameObject> m_OccupationVFXDic;

	private GameObject m_MainOccupationEliteVFX;

	private bool m_IsInitLeaderBoardInfo;

	private Color DefaultValueColor;

	private Color IncreaseValueColor;

	private UICSRankIconController m_CSRankIconController;

	private UIBRRankIconController m_BRRankIconController;

	private List<OccupationHistory> m_OccupationDataList;

	private string ProfileRedPointKey => null;

	private string ShareRedPointKey => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnAnimEvent(object[] data)
	{
	}

	private IEnumerator ShowLeaderBoardInfo()
	{
		return null;
	}

	private void OnShareBtnClick()
	{
	}

	public void Init(bool isBR)
	{
	}

	private void InitLeaderBoardInfo()
	{
	}

	private void UpdateProfileData()
	{
	}

	private void UpdateClanName()
	{
	}

	private void InitBannerData()
	{
	}

	private void InitOccupationData()
	{
	}

	private void RefreshMainRole()
	{
	}

	private void SetRoleView(UISprite sprite, UILabel name, UILabel lv, OccupationHistory occupationInfo, bool isMainRole = false)
	{
	}

	private void OnOccupationSwitchBtn()
	{
	}

	private void OnOccupationSwitchMaskBtn()
	{
	}

	private void InitSeasonStatsData()
	{
	}

	private void SetSeasonStatsData(UILabel value, UILabel name, GameObject increaseGo, SeasonReplayUpwardData seasonReplayUpwardData, Animation increaseAnim)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void Selected(bool isFirstEnter)
	{
	}

	private IEnumerator PlayInAnim()
	{
		return null;
	}

	public void UnSelected()
	{
	}

	public void HideView()
	{
	}

	public void HidePreview()
	{
	}

	public void RecoverPreview()
	{
	}

	private void OnStartSeasonBtnClicked()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public CombineScreenshotData BeforeCombineShare()
	{
		return default(CombineScreenshotData);
	}

	public void AfterCombineShare()
	{
	}

	public void PrepareControllerBeforeScreenshot()
	{
	}

	private void _003CInitOccupationData_003Eb__39_5()
	{
	}

	private void _003CInitOccupationData_003Eb__39_6()
	{
	}

	private void _003CInitOccupationData_003Eb__39_7()
	{
	}

	private void _003CInitOccupationData_003Eb__39_8()
	{
	}

	private void _003CInitOccupationData_003Eb__39_9()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
