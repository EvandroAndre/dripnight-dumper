using System;
using GCommon;
using proto;

namespace COW;

public class UIChoose1From3ItemController : UIBaseController
{
	private UIChoose1From3ItemView m_View;

	private Action<OptionalBundleShowData> m_OnClickItem;

	private OptionalBundleShowData m_Data;

	private bool m_HasRecharge;

	private BaseItemInfo m_Info;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(OptionalBundleShowData data, bool hasRecharge, Action<OptionalBundleShowData> onClickItem)
	{
	}

	public void ShowSelect(bool value)
	{
	}

	public void OnClickItem()
	{
	}

	public void SetQualityBG()
	{
	}

	public static void SetQualityBG(int Quality, UISprite QualityBG)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
