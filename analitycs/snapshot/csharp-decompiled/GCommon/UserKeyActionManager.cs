using System.Collections.Generic;
using COW;
using UnityEngine;

namespace GCommon;

public class UserKeyActionManager : SingletonModule<UserKeyActionManager>
{
	public enum EActionGroup
	{
		Normal,
		Inventory,
		MiniMap,
		Shopping,
		Setting,
		ChatRoulette,
		ChatMenu,
		Grenade,
		TeamParachute,
		MedKit,
		AuxAim,
		Chat,
		Observer,
		MatchResult,
		TeamLeaderChangeMenu,
		DualActiveSkillSelect,
		All
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public uint requestCurGroup;

		internal bool _003CSetPreviousActiveGroup_003Eb__0(uint a)
		{
			return false;
		}
	}

	private List<uint> m_ActionGroupStack;

	private Dictionary<string, List<UIButton>> m_ActionButtons;

	private Dictionary<string, KeyActionSettingData> m_KeyCodeMapping;

	private string _003CKeyActionForEscape_003Ek__BackingField;

	public Dictionary<string, KeyCode> ChangedKeyActionSettingMapping;

	private Dictionary<string, KeyCode> m_DefaultKeyCodeMapping;

	private Dictionary<uint, KeyCodeDescSettingData> m_KeyCodeDescMapping;

	private static readonly string[] ActionGroupKey;

	public const string KEY_ACTION_SETTING_CHANGE_SAVE_KEY = "KeyActionSetting_ChangeSaveKey";

	public string KeyActionForEscape
	{
		get
		{
			return _003CKeyActionForEscape_003Ek__BackingField;
		}
		private set
		{
			_003CKeyActionForEscape_003Ek__BackingField = value;
		}
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void LoadPresetKeyCodeMapping()
	{
	}

	private void LoadKeyCodeDescMapping()
	{
	}

	private void LoadChangedKeyActionSettingFromKeyValue()
	{
	}

	public KeyCodeDescSettingData GetKeyCodeDescData(KeyCode keyCode)
	{
		return null;
	}

	public void UpdateKeyCodeMappingToInputSDK()
	{
	}

	public Dictionary<string, KeyActionSettingData> GetKeyCodeMap()
	{
		return null;
	}

	public void ResetDefaultKeyActionSetting()
	{
	}

	public KeyCode GetBindKeyCode(string name)
	{
		return KeyCode.None;
	}

	public void RebindKeyCode(string name, KeyCode kc)
	{
	}

	public void RegisterActionButton(string name, UIButton btn)
	{
	}

	public void UnRegisterActionButton(string name)
	{
	}

	public Dictionary<string, List<UIButton>> GetKeyActionButtons()
	{
		return null;
	}

	public bool ShouldLockCameraRotation()
	{
		return false;
	}

	public bool ShouldLockKeyCodeAction(string kcMapName)
	{
		return false;
	}

	public void SetCursorLocked(bool b)
	{
	}

	public void ClearActionGroup()
	{
	}

	public void SetCurActionGroup(uint cur)
	{
	}

	private void SetCurActionGroupInternal(uint cur)
	{
	}

	public bool IgnoreWhenUIHover(string kcName)
	{
		return false;
	}

	public uint CurActionGroup()
	{
		return 0u;
	}

	public void SetPreviousActiveGroup(uint requestCurGroup = 0u)
	{
	}

	public UILabel SetButtonKeyCodeNameLabel(string kcName, Transform parent)
	{
		return null;
	}

	public string GetKeyCodeDescByKeyAction(string keyAction)
	{
		return null;
	}

	public void Clean()
	{
	}
}
