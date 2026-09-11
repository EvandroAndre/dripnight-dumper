using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using COW.Graphics;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCIconEntityObject : BaseAutoGenIDLevelObject
{
	private Color m_selectColor;

	protected MultiBillboard m_Billboard;

	protected UISprite m_Sprite;

	protected UIPanel m_Panel;

	protected Transform m_Scaleable;

	protected UGCPrettyUI3DSize m_autoSize;

	private UGCResourceUIAtlas m_resAtlas;

	private bool m_activeSelf;

	private List<object> m_visiblePlayers;

	private UIHUDUGC_TextIconMarkShowController m_Hud;

	private string m_iconType;

	private Color m_IconColor;

	private string m_followTarget;

	private bool m_isIgnoreDepth;

	private bool m_isAlwaysInScreen;

	private bool m_isBillboard;

	private Vector3 m_OffsetPos;

	private int m_Width;

	private int m_Height;

	private int m_RenderType;

	private int m_depth;

	public string IconType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color IconColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public string FollowTarget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsIgnoreDepth
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAlwaysInScreen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Billboard
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 OffsetPos
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public int Width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int RenderType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Depth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsVisibility()
	{
		return false;
	}

	public void SetSelected(bool selected)
	{
	}

	private void ResizeCollider()
	{
	}

	protected override void OnAwake()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	private void OnIconTypeChanged(string valueNew)
	{
	}

	private void LoadAtlasResAndSprite(string atlasAndSpriteStr, Action<UGCResourceUIAtlas, string> callback)
	{
	}

	private void OnRefreshActive()
	{
	}

	private bool IsVisiblePlayer(BHGGAEEHJCO playerID)
	{
		return false;
	}

	private void AddIconHUD()
	{
	}

	private void RemoveIconHUD()
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	private void _003COnIconTypeChanged_003Eb__60_0(UGCResourceUIAtlas atlasRes, string spriteName)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
