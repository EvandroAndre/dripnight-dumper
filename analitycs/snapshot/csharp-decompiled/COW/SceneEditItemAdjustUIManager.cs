using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class SceneEditItemAdjustUIManager : SingletonModule<SceneEditItemAdjustUIManager>
{
	private EAdjustType m_AdjustType;

	public UIHudSceneEditInspectorController m_InspectorController;

	private SceneEditAgent m_Agent;

	private SceneEditAgent Agent => null;

	public EAdjustType AdjustType
	{
		get
		{
			return EAdjustType.None;
		}
		set
		{
		}
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void SetAttriUIHideCallback(Action attributeCloseBtnCallback)
	{
	}

	public void RefreshPartAttributeUI(ItemEditAttributeUIData_V2 uiData)
	{
	}

	public void ReplacePartAttributeUI(string entityType, int startIndex, List<ItemEditAttributeUIData_V2> uiDatas, List<EJAOBJCGLKD.JNHDMBBECJP> secondLevelUIDatas)
	{
	}
}
