using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIMenu : MonoBehaviour
{
	public enum Pivot
	{
		HorizontalCenter,
		RightToLeft,
		LeftToRight,
		TopToBottom
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string id;

		internal bool _003CTrySelectByID_003Eb__0(UIMenuItem e)
		{
			return false;
		}
	}

	public UIMenuItem menuTemplate;

	public Pivot pivot;

	public float space;

	public bool exActiveAsClick;

	private List<UIMenuItem> m_Menus;

	private UIMenuItem m_SelectedMenu;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	public void TrySelectByID(string id)
	{
	}

	public void Reposion()
	{
	}

	private void OnMenuSelected(UIMenuItem selectMenu)
	{
	}

	public static Vector3 LocalPositionSetY(Transform target, float y)
	{
		return default(Vector3);
	}

	public static Vector3 LocalPositionSetX(Transform target, float x)
	{
		return default(Vector3);
	}
}
