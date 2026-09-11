using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFlagBattleChooseItemController : UIBaseController
{
	public UISprite BgSprite;

	public UILabel Desc;

	public uint AttributeId;

	public UIButton Btn;

	public byte Lv;

	public Transform VFXPos;

	private ResourceID vfxResId;

	private GameObject vfxG0;

	private JECFNLMHNME m_Config;

	protected override void OnUIInit()
	{
	}

	public void SetData(FlagBattleAttributesInfoData data, JECFNLMHNME config, byte lv)
	{
	}

	public void OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
