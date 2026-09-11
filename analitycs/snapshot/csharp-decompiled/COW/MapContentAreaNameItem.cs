using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class MapContentAreaNameItem : MonoBehaviour
{
	private enum FontColor : byte
	{
		None,
		Normal,
		OnWhiteBg,
		OnBlueBg
	}

	private static readonly Color m_FontColorLight;

	private static readonly Color m_FontOutlineLight;

	private static readonly Color m_FontColorDark;

	private static readonly Color m_FontOutlineDark;

	public string MapNameID;

	public UILabel NameLabel;

	public UISprite MainBgSprite;

	public UISprite SideBgSprite;

	public GameObject BgContainer;

	public UISprite CoinSprite;

	public UILabel CoinCountLabel;

	public UISprite BgSprite;

	private Vector3 m_MapLocalPos;

	private byte m_FontColor;

	private int m_OriginBGRightAnchorAbs;

	private UIHudMapContentAreaNamesView m_OwnerView;

	public void Init(UIHudMapContentAreaNamesView view)
	{
	}

	public void RefreshPOIDisplayInfo()
	{
	}

	public void HidePOIDisplayInfo()
	{
	}

	public void SetFontColorBySafeZone(SafeZone safeZone)
	{
	}
}
