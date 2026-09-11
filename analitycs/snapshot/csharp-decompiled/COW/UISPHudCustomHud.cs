using UnityEngine;

namespace COW;

public class UISPHudCustomHud : MonoBehaviour
{
	public static readonly string FolderName;

	public string CustomPictureName;

	private bool m_hasCustomHUDUsed;

	private UITexture m_CustomTexture;

	public UITexture CustomTexture => null;
}
