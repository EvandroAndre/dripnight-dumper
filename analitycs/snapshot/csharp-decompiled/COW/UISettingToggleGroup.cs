using UnityEngine;

namespace COW;

public class UISettingToggleGroup : MonoBehaviour
{
	public UIToggle[] m_Toggles;

	public int[] m_Contents;

	public UILabel[] m_Labels;

	public string m_SettingKey;

	public int m_DefaultContent;

	public bool isReloadingWorks;

	private bool isInitShow;

	private UIToggleValue[] m_ToggleValueItems;

	public OnToggleGroupValueChange OnToggleValueChange;

	public UILabel m_LocTitle;

	public UILabel m_OnLabel;

	public UILabel m_OffLabel;

	public Color OnColor;

	public Color OffColor;

	private bool m_HasInit;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void SetTogglesGroup()
	{
	}

	private void OnValueChange()
	{
	}

	public void SetToggleValue(int value)
	{
	}
}
