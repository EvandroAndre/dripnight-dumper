using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class ElitePassWaittingRoomRanking : MonoBehaviour
{
	public UILabel m_Nickname;

	public UILabel m_BadgeCount;

	public UISprite m_IconSprite;

	public GameObject m_BPCon;

	public UISprite m_BPIconSprite;

	public UISprite m_BPBgSprite;

	public GameObject m_BPMaxLevelVFX;

	public UISprite m_PinIcon;

	public GameObject m_CelebrityEffect;

	public bool m_FixNamePosition;

	public Transform BRCSRankUIContianer;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	public void SetData(string name, uint count, uint id, uint pinId = 0u, bool isCelebrity = false, bool useSpriteText = false, bool isFP = true)
	{
	}

	public void ResetMode()
	{
	}

	public void SetSocialModeRankData(UIBaseController parentUI, UIInGameRankBillboardController.JIOLBAOFPOD rankType, string rankIconSpriteName, string name, bool isFP, uint uintRankValue, uint rankParam1, uint rankParam2)
	{
	}

	private void ShowNormalIconSprite(bool isShow)
	{
	}

	private void ShowCount(bool isShow)
	{
	}

	public Transform GetPrivilegeIconTransform()
	{
		return null;
	}
}
