using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityExchangePopupController : UIPopupWindowController
{
	private const int MinCount = 1;

	private const int MaxCount = 99;

	private const int UnlimitedCount = 999;

	private int m_Afford;

	private int m_Limit;

	private int m_Count;

	private UIModelActivity m_Activity;

	private ClientActivityDesc m_Desc;

	private List<GameObject> m_Token;

	private List<UISprite> m_TokenSprite;

	private List<UILabel> m_TokenLabel;

	private List<UIStandardItemMidController> m_AwardList;

	private List<UILabel> m_AwardName;

	private UIActivityExchangePopupView m_View;

	private int Count
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnMinusBtnClick()
	{
	}

	private void OnPlusBtnClick()
	{
	}

	private void OnMaxBtnClick()
	{
	}

	private void OnCountInputSubmit()
	{
	}

	private void OnRedeemClick()
	{
	}

	public void SetData(ClientActivityDesc desc)
	{
	}

	private void CalculateAffordAndLimit()
	{
	}

	private void SetAwards()
	{
	}

	private void SetTokens()
	{
	}

	private void SetTokenIcon(uint tokenID, UISprite sprite)
	{
	}

	private void SetTokenLabel(Item token, UILabel label)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
