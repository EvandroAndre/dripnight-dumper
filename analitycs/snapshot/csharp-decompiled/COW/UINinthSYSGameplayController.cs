using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UINinthSYSGameplayController : UIPopupWindowController, UIModelNinthSYS.INinthSYSGamePlayContext
{
	private UINinthSYSGameplayView m_View;

	private UIModelNinthSYS m_ModelNinthSYS;

	private uint m_BRGoPos;

	private string m_BRSubGopos;

	private string m_BRBackupSubGopos;

	private uint m_CSGoPos;

	private string m_CSSubGopos;

	private string m_CSBackupSubGopos;

	private uint m_TutorialGoPos;

	private string m_CSTutorialSubGopos;

	private string m_BRTutorialSubGopos;

	protected bool m_IsOpenWebView;

	private uint _003CTabType_003Ek__BackingField;

	private uint _003CSubTabType_003Ek__BackingField;

	private List<UINinthSYSGameplaySubTabItemController> m_SubTabItemList;

	private ulong m_ShowTime;

	private List<NinthSysGamePlayDesc> m_NinthSysGamePlayDescList;

	private List<NinthSysSkillDesc> m_NinthSysSkillDescList;

	private Dictionary<uint, UINinthSYSGameplaySubRuleController> m_SubCtrls;

	private UINinthSYSGameplaySubRuleController m_CurrentSubRuleCtrl;

	protected string DEFAULT_LAN;

	public uint TabType
	{
		get
		{
			return _003CTabType_003Ek__BackingField;
		}
		private set
		{
			_003CTabType_003Ek__BackingField = value;
		}
	}

	public uint SubTabType
	{
		get
		{
			return _003CSubTabType_003Ek__BackingField;
		}
		private set
		{
			_003CSubTabType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetSubType(uint subType)
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}

	public void OnClickSubTabItem(uint subTabType)
	{
	}

	public void OnClickTutorialBtn(uint tabType)
	{
	}

	public void OnClickGoposBtn(uint tabType)
	{
	}

	public bool IsLastSubTabItem(uint subTabType)
	{
		return false;
	}

	private void OnWebViewOpen()
	{
	}

	protected virtual void OnWebViewClose(object[] data)
	{
	}

	private void InitSubTabItem()
	{
	}

	private uint GetFirstSubTabType(uint type)
	{
		return 0u;
	}

	private void OpenSubTabContainer(uint subTabType)
	{
	}

	private NinthSysGamePlayDesc GetGamePlayDescBySubTabType(uint subTabType)
	{
		return null;
	}

	private void ShowDeathBoxReviveContainer()
	{
	}

	private void ShowTeamZoneTaskContainer()
	{
	}

	private void ShowPlaneRouteContainer()
	{
	}

	private void ShowWeaponAwakenContainer()
	{
	}

	private void ShowPowerCharacterContainer()
	{
	}

	private void ShowAbilityEnhancedAirdropContainer()
	{
	}

	private void OnToggleTabSelect(UIToggleButton toggleButton)
	{
	}

	private void OnClickClose()
	{
	}

	private void OnClickLeftBtn()
	{
	}

	private void OnClickRightBtn()
	{
	}

	private uint GetNextSubTabType(uint subTabType, uint originSubTabType)
	{
		return 0u;
	}

	private uint GetPrevSubTabType(uint subTabType, uint originSubTabType)
	{
		return 0u;
	}

	private UIToggleButton GetToggleButtonByTabType(uint tabType)
	{
		return null;
	}

	private void LogClick(string posfix)
	{
	}

	private string GetGetBigEventParamStrByLangeFormat(string paramStr)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
