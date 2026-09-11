using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_Template_MissionItemBaseController : UIEasyListItemController, IBigEventTemplateIdentifier
{
	protected UIModelBigEventTemplate m_UIModelBigEventTemplate;

	protected List<UIStandardItemMiniController> m_ListRewardItemCtrl;

	protected ClientActivityDesc m_ActivityDesc;

	protected EActivity.State m_ActivityState;

	protected int MAXTASKNUM;

	protected UILabel LabelDescription;

	protected GameObject LabelReceived;

	protected UIButton BtnReceive;

	protected GameObject GoAwarded;

	protected UINetworkTexture TextureBg;

	protected UILabel LabelProcess;

	protected UIGrid GridAwards;

	protected GameObject GotoBtnGo;

	protected UIButton GotoBtn;

	protected UINavigationUtil.UINavigationFrom From;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	protected virtual UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

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

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected virtual string GetMissionItemBGUrl()
	{
		return null;
	}

	protected virtual EActivity.State GetActivityState(ActivityClientInfo info)
	{
		return EActivity.State.State_RECEIVED;
	}

	protected virtual Color GetMissionDescColor()
	{
		return default(Color);
	}

	protected virtual bool RefreshView()
	{
		return false;
	}

	protected virtual void RefreshAward()
	{
	}

	private void OnClickBtnReceive()
	{
	}

	protected virtual void OnClickGotoBtn()
	{
	}

	protected virtual void ShowOrHideFinishEffect(bool result)
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

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
