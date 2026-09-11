using System;
using GCommon;

namespace COW;

public abstract class UIMilestone_BaseCorePlayController : UIBaseController
{
	protected UIModelBigEvent_Milestone m_UIModelMilestone;

	protected int m_SpineRunSound;

	private bool _003CisPlaying_003Ek__BackingField;

	public bool isPlaying
	{
		get
		{
			return _003CisPlaying_003Ek__BackingField;
		}
		protected set
		{
			_003CisPlaying_003Ek__BackingField = value;
		}
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public abstract float PlayEnterAnim();

	public abstract void InitSetting();

	public abstract float PlayFirstInAnim();

	public abstract void InitInfo();

	public abstract bool PlayMileageAccAnim(uint mileage, Action callback);

	public abstract bool SkipAnim();

	public abstract void RefershRegionBackground();

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
