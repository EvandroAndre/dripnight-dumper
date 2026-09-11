using UnityEngine;

namespace COW;

public class ElitePassIngameRanking : MonoBehaviour
{
	public UILabel m_Nickname;

	public UILabel m_BadgeCount;

	public UISprite m_IconSprite;

	public UISprite m_PinIcon;

	public GameObject m_CelebrityEffect;

	public void SetData(string name, string count, CSSharedItemData itData, uint pinId = 0u, bool isCelebrity = false, bool useSpriteText = false)
	{
	}
}
