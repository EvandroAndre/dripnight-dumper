using UnityEngine;

namespace COW;

public class UIHDStandLobbyItem : MonoBehaviour
{
	public enum EHDStandLobbyItemType
	{
		None,
		EP,
		WeaponRack,
		Vehicle,
		IceWall,
		Skyboard,
		IPMusic
	}

	private EHDStandLobbyItemType m_Type;

	private bool m_IsInTeam;

	private bool m_IsClickSelf;

	private float m_DeltaTime;

	private Vector2 m_ClickPos;

	private float m_DpiFactor;

	private const float IPHONE_DPI = 326f;

	private UIHDStandLobbyManager m_Manager;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public static bool IsOverGUIElements(Vector2 screenPosition)
	{
		return false;
	}

	private bool CheckIsTouchSelf(Vector2 touchPos)
	{
		return false;
	}

	private void OnClickItem()
	{
	}

	private void OnLobbyGroupEnter(object[] data)
	{
	}

	private void OnGroupQuit()
	{
	}
}
