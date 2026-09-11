using UnityEngine;

namespace COW;

public class AvatarSelectionSkillSlot : MonoBehaviour
{
	public GameObject m_SlotContainer;

	public UISprite m_EquippedSkillIcon;

	public UISprite m_UnEquippedIcon;

	public GameObject m_LockSkillIcon;

	private Color semiColor;

	public void SetSkillIcon(uint skillID, bool isLock = false, bool semiAlphaView = false)
	{
	}
}
