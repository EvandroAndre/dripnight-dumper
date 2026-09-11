using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIProfileCreditController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	private enum ECreditBehaviorType
	{
		Normal
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ClientActivityDesc> _003C_003E9__28_0;

		public static Comparison<CreditScoreChangeInfo> _003C_003E9__30_0;

		internal int _003CSetUIData_003Eb__28_0(ClientActivityDesc a, ClientActivityDesc b)
		{
			return 0;
		}

		internal int _003CSetHistoryUIData_003Eb__30_0(CreditScoreChangeInfo a, CreditScoreChangeInfo b)
		{
			return 0;
		}
	}

	private UIProfileCreditView m_View;

	private UIModelCredit m_Model;

	private UIModelActivity m_ActivityModel;

	private const int MAX_REWARD_ITEMS_COUNT = 3;

	private UIProfileCreditRewardItemController[] m_AwardItemCtrlArray;

	private List<ActivityGroupDesc> CreditScoreGroupDescs;

	private List<ClientActivityDesc> CreditScoreActivityDesc;

	private const string RobotEyes_High_Big = "FF_UI_CreditScore_Robot_Eye_1_Big";

	private const string RobotEyes_Normal_Big = "FF_UI_CreditScore_Robot_Eye_2_Big";

	private const string RobotEyes_Low_Big = "FF_UI_CreditScore_Robot_Eye_3_Big";

	private const string RobotEyes_High_Small = "FF_UI_CreditScore_Robot_Eye_1_Small";

	private const string RobotEyes_Normal_Small = "FF_UI_CreditScore_Robot_Eye_2_Small";

	private const string RobotEyes_Low_Small = "FF_UI_CreditScore_Robot_Eye_3_Small";

	private const string StatusIcon1 = "FF_UI_CreditScore_Icon01";

	private const string StatusIcon2 = "FF_UI_CreditScore_Icon02";

	private const string StatusIconA = "FF_UI_CreditScore_Icon_Excellent";

	private UIProfileCreditBehaviorItemController m_CreditBehaviorItemTemplateCtrl;

	private int BehaviorScrollViewWidth;

	private UITable2.Margin BehaviorMargin;

	private const string m_CreditLevelChangeKey = "CreditLevelChangeKey";

	private CreditScoreInfoBasic m_CreditScoreInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitAwardItem()
	{
	}

	private void InitBtnOpenFF_Fairplay()
	{
	}

	private void InitCreditBehaviorTemplate()
	{
	}

	private Vector3 GetTopBarHelpPos()
	{
		return default(Vector3);
	}

	public void SetUIData(CreditScoreInfoBasic info)
	{
	}

	private void OnFairplayContainerChange()
	{
	}

	private void SetHistoryUIData(CSGetCreditScoreChangeInfoRes scoreChangeInfo)
	{
	}

	private void SetBehaviorUIData()
	{
	}

	private void OnClickOpenFF_Fairplay()
	{
	}

	private void OnCreditBehaviorStatusBtnClick()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private UITable2.IUITable2Item _003CInitCreditBehaviorTemplate_003Eb__26_0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
