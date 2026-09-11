using UnityEngine;

namespace COW;

public class ProfileCustomDragTemplate : MonoBehaviour
{
	public const float SCALE = 0.85f;

	public UIWidget FrameWidget;

	public ProfileCustomModuleData ModuleData;

	public Bounds CachedBounds;

	public UISprite TabSprite;

	private Vector2Int m_CellSize;

	public Vector2Int CellSize
	{
		get
		{
			return default(Vector2Int);
		}
		set
		{
		}
	}

	public void RefreshBounds(Transform relativeTrans)
	{
	}

	public void SetSpriteByTabType()
	{
	}
}
