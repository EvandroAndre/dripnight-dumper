using GCommon;
using UnityEngine;

namespace COW;

public class TailorSlotItem : MonoBehaviour
{
	public GameObject Normal;

	public GameObject Lock;

	public UISprite Icon;

	public UISprite BG;

	public GameObject Empty;

	public GameObject Cant;

	public UISprite EmptyBG;

	public UISprite CantBG;

	public UISprite EmptyIcon;

	public GameObject Effect;

	public void SetLockActive(bool active)
	{
	}

	public void SetClothIcon(ResourceID resourceID)
	{
	}

	public void SetEmptyIcon(string spriteName)
	{
	}

	public void SetBG(Vector3 rotation, UIBasicSprite.Flip flip)
	{
	}

	public void SetEmptyState()
	{
	}

	public void SetNoClothState()
	{
	}

	public void SetNormalState()
	{
	}

	public void ShowEffect()
	{
	}
}
