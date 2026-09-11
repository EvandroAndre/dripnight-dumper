using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSMysteryBoxOptionItemView : MonoBehaviour
{
	public class MysterBoxData
	{
		public uint boxItemID;

		public uint boxUniqueID;

		public uint boxIndexID;

		public uint itemID;
	}

	public UIToggleButton ItemBtn;

	public UILabel ItemName;

	public UISprite ItemSprite;

	public UIButton HelpBtn;

	public GameObject SelectedHL;

	private MysterBoxData m_BoxData;

	private UIHudCommonlTipsController m_CurrentTips;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetUIData(MysterBoxData data)
	{
	}

	private void OnItemBtnClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnOptionSelected(object[] data)
	{
	}
}
