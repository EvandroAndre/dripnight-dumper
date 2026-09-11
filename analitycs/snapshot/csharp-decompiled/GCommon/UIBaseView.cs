using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIBaseView
{
	private class SpriteInfo
	{
		public UISprite sprite;

		public string name;

		public Color32 spriteColor;

		public UIAtlas altas;

		public SpriteInfo(UISprite sprite, string name, Color32 color, UIAtlas atlas)
		{
		}
	}

	protected Vector2 m_WindowsSize;

	private bool m_FullScreenUI;

	private bool[] m_Enable;

	private Vector3[] m_LocalPosition;

	private Quaternion[] m_LocalRotation;

	private Vector3[] m_LocalScale;

	private List<SpriteInfo> m_SpriteInfo;

	private Dictionary<UISprite, Color32> m_SpriteColor;

	private Dictionary<UISprite, string> m_SpritaName;

	private Dictionary<UISprite, UIAtlas> m_Altas;

	private Dictionary<UILabel, Color32> m_LableColor;

	private UIScrollView[] m_UIScrollViews;

	private UIAnchor[] m_UIAnchors;

	private Dictionary<UITweener, bool> m_UITweener;

	private SetPanelClip[] m_SetPanelClip;

	public Vector2 WindowsSize => default(Vector2);

	public bool FullScreenUI
	{
		set
		{
		}
	}

	public void Init(Transform rootTrans, Transform holder, bool needDump = false)
	{
	}

	protected virtual void OnInit(Transform holder)
	{
	}

	private void Dump(Transform holder)
	{
	}

	public void ReInit(Transform holder)
	{
	}
}
