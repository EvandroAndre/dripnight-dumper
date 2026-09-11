using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_CardProgressNodeController : UIBaseController, IBigEventTemplateIdentifier
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__12_0;

		internal BaseItemInfo _003COnClickBoxBtn_003Eb__12_0(AwardDesc item)
		{
			return null;
		}
	}

	private UIBigEvent_CardProgressNodeView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private CustomCardProgressRewardData mData;

	private ResourceID m_EffectVFXResID;

	private GameObject m_EffectVFXGO;

	private const string SHAKE_ANIM = "UIFX_Ui_Progress_Shake";

	private const string STAND_ANIM = "UIFX_Ui_Progress_Stand";

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

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	private void OnClickBoxBtn()
	{
	}

	private void Clear()
	{
	}

	private void InitCDN()
	{
	}

	public void SetData(CustomCardProgressRewardData data)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
