using UnityEngine;
using message;

namespace COW;

public class UIShopPointMapIconController : MonoBehaviour
{
	public UISprite shopSprite;

	public HEOJAGLBHLJ shopType;

	public uint ShopID;

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	public void OnShopDiscount()
	{
	}

	public void ChangeShopIconRes(string icon)
	{
	}
}
