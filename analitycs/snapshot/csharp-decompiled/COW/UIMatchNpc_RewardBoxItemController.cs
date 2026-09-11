using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMatchNpc_RewardBoxItemController : UIBaseController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__22_0;

		internal BaseItemInfo _003CSetViewData_003Eb__22_0(AwardDesc item)
		{
			return null;
		}
	}

	private UIMatchNpc_RewardBoxItemView m_View;

	private uint m_RequestNum;

	private List<BaseItemInfo> m_ShowRewardBaseItemInfoList;

	private UIModelBigEvent_MatchNPC m_ModelMatchNpc;

	private UIModelBigEventTemplate m_ModelTemplate;

	private bool isGrandReward;

	private bool m_ShowVFX;

	private bool m_ShowRedTexture;

	private GameObject m_NormalRewardBoxEffectGO;

	private GameObject m_GrandRewardBoxEffectGO;

	private GameObject m_RewardBoxSpecialEffect;

	private GameObject m_PoolGetResGO;

	private ResourceID m_PoolGetResID;

	private CustomEventMatchNPCProcessDesc m_ProcessDesc;

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

	private void InitRewardBoxEffect()
	{
	}

	private void InitRewardTextShowColor()
	{
	}

	private void OnRewardClick()
	{
	}

	private GameObject GetTipsObject()
	{
		return null;
	}

	public void SetViewData(uint request_Num)
	{
	}

	private void RefreshEffecShowState()
	{
	}

	public void RefreshTips()
	{
	}

	private void RefreshBoxIconShowState(uint processs_amount = 0u)
	{
	}

	private void CloseBoxEffect()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
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

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
