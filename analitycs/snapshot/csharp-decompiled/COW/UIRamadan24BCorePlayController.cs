using System;
using GCommon;
using Spine.Unity;
using UnityEngine;

namespace COW;

public class UIRamadan24BCorePlayController : UIMilestone_BaseCorePlayController
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UIRamadan24BCorePlayController _003C_003E4__this;

		public Action callback;

		internal void _003CPlayMileageAccAnim_003Eb__0()
		{
		}
	}

	private UIRamadan24BCorePlayView m_View;

	private SkeletonAnimation m_KellySpineAnim;

	private readonly float NormalSpeed;

	private readonly float AccSpeed;

	private readonly string Walk;

	private readonly string Run;

	private readonly string Ramadan_Cutscene;

	private readonly string[] TreeAnims;

	private readonly float MinTreeSpineAnimPoint;

	private readonly float MaxTreeSpineAnimPoint;

	private uint m_DelayKey;

	private int m_BackgroundIndex;

	private GameObject[] m_BackgroundGos;

	private Animator m_BgAnimator;

	private Animator m_TreeAnimator;

	private SkeletonAnimation m_TreeSpineAnim;

	private float m_NextAnimPoint;

	private bool m_Start;

	private bool m_isFirst;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override float PlayFirstInAnim()
	{
		return 0f;
	}

	public override float PlayEnterAnim()
	{
		return 0f;
	}

	public override void InitSetting()
	{
	}

	public override void InitInfo()
	{
	}

	public override bool PlayMileageAccAnim(uint mileage, Action callback)
	{
		return false;
	}

	public override bool SkipAnim()
	{
		return false;
	}

	public override void RefershRegionBackground()
	{
	}

	private void RamdonTreeAnimation()
	{
	}

	private void Update()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
