using COW.GamePlay;
using UnityEngine;

namespace COW;

public class UIHudMetropolisStoreTabItem : MonoBehaviour
{
	public UIButton ItemBtn;

	public GameObject SelectContent;

	public GameObject NormalContent;

	public UISprite SelectWeaponIcon;

	public UISprite SelectCollectIcon;

	public UISprite NormalWeaponIcon;

	public UISprite NormalCollectIcon;

	private HBNOCDIKBCM TabData;

	private UIHudMetropolisWeaponStoreController m_Ctrl;

	public void SetTabData(UIHudMetropolisWeaponStoreController ctrl, HBNOCDIKBCM data)
	{
	}

	public void OnClickTab(bool collect, int weaponType)
	{
	}

	private void OnItemClick()
	{
	}
}
