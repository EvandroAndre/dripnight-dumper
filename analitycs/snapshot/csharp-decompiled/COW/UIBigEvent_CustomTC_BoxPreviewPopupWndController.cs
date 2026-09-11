using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_CustomTC_BoxPreviewPopupWndController : UIPopupWindowController, IEasyList, IBigEventTemplateIdentifier
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BundleShowData, BaseItemInfo> _003C_003E9__10_0;

		public static Converter<OptionalBundleShowData, BaseItemInfo> _003C_003E9__10_1;

		public static Converter<TreasureBoxShowData, BaseItemInfo> _003C_003E9__10_2;

		internal BaseItemInfo _003CSetViewData_003Eb__10_0(BundleShowData temp)
		{
			return null;
		}

		internal BaseItemInfo _003CSetViewData_003Eb__10_1(OptionalBundleShowData temp)
		{
			return null;
		}

		internal BaseItemInfo _003CSetViewData_003Eb__10_2(TreasureBoxShowData temp)
		{
			return null;
		}
	}

	private UIBigEvent_CustomTC_BoxPreviewPopupWndView m_View;

	private List<UIStandardItemMiniController> m_ShowRewardItemLIst;

	private UIModelBigEvent_CustomTC m_UIModelCustomTC;

	private UIModelStoreBox m_ModelStoreBox;

	private bool m_ShowTexture;

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

	protected override void OnSetNavigationController()
	{
	}

	private void OnClickClose()
	{
	}

	private void InitRewardRepeatWndBg()
	{
	}

	public void SetViewData(BaseItemInfo rewardInfo, Vector3 pos)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
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

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}
}
