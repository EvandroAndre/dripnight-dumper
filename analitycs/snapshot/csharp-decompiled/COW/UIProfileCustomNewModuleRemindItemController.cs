using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomNewModuleRemindItemController : UIBaseController
{
	private Dictionary<uint, Vector2> m_DictPathTypeToSize;

	private Dictionary<uint, Vector2> m_DictPathTypeToTagTransform;

	private UIProfileCustomNewModuleRemindItemView m_View;

	private ProfileNewModuleData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ProfileNewModuleData data)
	{
	}

	private void RefreshNewModuleView()
	{
	}

	private void RefreshIconView()
	{
	}

	private void ShowNewModuleTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
