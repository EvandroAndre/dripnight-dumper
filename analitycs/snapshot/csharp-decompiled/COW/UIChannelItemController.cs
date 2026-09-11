using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIChannelItemController : UIEasyListItemController, ITipsDelegate
{
	private UIChannelItemView m_View;

	private ChatChannelInfo m_Info;

	private ETipsType m_TipsType;

	private bool isSelect;

	public static Color32 UnseletColor;

	public static Color32 SelectColor;

	private static Dictionary<uint, string> m_StrKeyDic;

	private static Dictionary<uint, string> m_DictChannelTypeToLog;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshUnreadTips()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	void ITipsDelegate.OnTipsDataChange(ETipsType type, int num)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
