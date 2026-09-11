using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class ItemGeneratorHint : MonoBehaviour
{
	public UISprite m_Icon;

	public UISprite m_BgIcon;

	public UILabel m_InfoText;

	public UISprite m_InfoBg;

	private const string LIFE_SPIRE = "";

	private const string AMMO_SPIRE = "";

	private const string ARMOR_SPIRE = "";

	private MutableString m_CountStr;

	private OPICPDCLKAG m_ObjectType;

	private bool m_IsOpen;

	private int m_CurrentCountDown;

	private void Start()
	{
	}

	public void SetInfo(OPICPDCLKAG objType, bool isMyTeam)
	{
	}

	private void Update()
	{
	}

	public void SetInfo(OPICPDCLKAG objType, string IconName, bool open = false)
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}
}
