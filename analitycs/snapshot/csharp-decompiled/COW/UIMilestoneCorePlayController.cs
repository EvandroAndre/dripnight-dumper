using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIMilestoneCorePlayController : UIMilestone_BaseCorePlayController, IBigEventTemplateIdentifier
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UIMilestoneCorePlayController _003C_003E4__this;

		public int nextIndex;

		internal void _003CSetCoreBackgroundCdn_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UINetworkTextureExt preCoreBackground;
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public TweenAlpha alphaTween;

		public _003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals1;

		internal void _003CStartBackgroundTransition_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UIMilestoneCorePlayController _003C_003E4__this;

		public Action callback;

		internal void _003CPlayMileageAccAnim_003Eb__0()
		{
		}
	}

	private UIMilestoneCorePlayView m_View;

	private GameObject m_SpineGo;

	private uint m_DelayKey;

	private int m_BackgroundIndex;

	private string[] m_BackgroundCdns;

	private UINetworkTextureExt[] m_CoreBackgroundTextures;

	private int m_CoreBackgroundIndex;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
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

	private void SetCoreBackgroundCdn(string cdnUrl)
	{
	}

	private void StartBackgroundTransition(int newIndex)
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

	public EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	private string GetStageCdnUrl(int stageIndex)
	{
		return null;
	}

	private float GetStageDuration(int stageIndex)
	{
		return 0f;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
