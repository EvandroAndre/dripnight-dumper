using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICirclePieChartController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CirclePieChartData> _003C_003E9__28_0;

		public static Func<CirclePieChartData, float> _003C_003E9__28_1;

		public static Func<CirclePieChartData, float> _003C_003E9__31_0;

		public static Func<CirclePieChartData, float> _003C_003E9__36_1;

		internal int _003CSetViewData_003Eb__28_0(CirclePieChartData x, CirclePieChartData y)
		{
			return 0;
		}

		internal float _003CSetViewData_003Eb__28_1(CirclePieChartData x)
		{
			return 0f;
		}

		internal float _003CPlayCirclesTween_003Eb__31_0(CirclePieChartData x)
		{
			return 0f;
		}

		internal float _003COnNameplateClicked_003Eb__36_1(CirclePieChartData x)
		{
			return 0f;
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public uint clickedId;

		public Predicate<CirclePieChartData> _003C_003E9__0;

		internal bool _003COnNameplateClicked_003Eb__0(CirclePieChartData x)
		{
			return false;
		}
	}

	private sealed class _003CShowNameplateAnimInOrder_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICirclePieChartController _003C_003E4__this;

		private uint _003CframeCount_003E5__2;

		private List<UIOccupationNameplateController>.Enumerator _003C_003E7__wrap2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowNameplateAnimInOrder_003Ed__30(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UICirclePieChartView m_View;

	private List<CirclePieChartData> m_PieChartDatas;

	private Dictionary<uint, UISprite> m_SpriteDict;

	private Dictionary<uint, List<UISprite>> m_SpriteChooseDict;

	private Dictionary<uint, List<TweenFill>> m_TweenDict;

	private List<Transform> m_NameplatePosList;

	private GameObject m_EliteVFX;

	private List<UIOccupationNameplateController> m_NameplateCtrlList;

	private const uint MAX_NAMEPLATE_INFO = 3u;

	private float m_OutterRadius;

	private float m_InnerRadius;

	private int m_InvertTrd;

	private Vector3 m_CircleAngleOffset;

	public bool IsAnimPlaying;

	private uint m_DelayCall;

	private int NormalOffest;

	private int VerticalOffset;

	private Vector4 NameplateSize;

	private Vector4 ExtendNameplateSize;

	private Vector4 ExtendNameplateSizeSmall;

	private Coroutine m_NameplateCoroutine;

	private uint centerId;

	public uint CenterID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void SetEmptyStates(uint gamesNum, uint targetNum, uint matchMode = 0u)
	{
	}

	public void SetViewData(List<CirclePieChartData> pieChartDatas)
	{
	}

	private void PlayAnim()
	{
	}

	private IEnumerator ShowNameplateAnimInOrder()
	{
		return null;
	}

	public void PlayCirclesTween()
	{
	}

	private void UpdateNameplateTrans(Transform nameplateTran, Vector3 targetAngle, out Vector3 targetPos, bool isSmallBG)
	{
		targetPos = default(Vector3);
	}

	private void UpdateNameplatePosConfilct()
	{
	}

	private Rect GetExpendPosRect(Vector3 position, bool isExtendBig)
	{
		return default(Rect);
	}

	private void SetCircleCenter(CirclePieChartData data)
	{
	}

	public void OnNameplateClicked(uint clickedId, bool isExtend)
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnCircleBtnCliked()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void _003CPlayAnim_003Eb__29_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
