using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using COW.Graphics;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTextEntityObject : BaseAutoGenIDLevelObject
{
	protected Transform m_Scaleable;

	protected UILabel m_Label;

	protected UIPanel m_Panel;

	protected MultiBillboard m_Billboard;

	protected UGCPrettyUI3DSize m_autoSize;

	protected BoxCollider m_BoxCollider;

	private const int FONTSIZE_MIN = 8;

	private Color m_selectColor;

	private bool m_activeSelf;

	private UIHUDUGC_TextIconMarkShowController m_Hud;

	private List<object> m_visiblePlayers;

	private Material m_noZMaterial;

	private string m_Text;

	private Color m_FontColor;

	private int m_FontSize;

	private string m_followTarget;

	private bool m_isIgnoreDepth;

	private bool m_isAlwaysInScreen;

	private bool m_isBillboard;

	private Vector3 m_OffsetPos;

	private int m_fontStyle;

	private string m_fontType;

	private int m_depth;

	private int m_width;

	private int m_height;

	private int m_overflowMode;

	public string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color FontColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public int FontSize
	{
		get
		{
			return 0;
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

	public int FontStyle
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string FontType
	{
		get
		{
			return null;
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

	public int OverflowMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Material GetNoZMaterial()
	{
		return null;
	}

	public bool IsVisibility()
	{
		return false;
	}

	protected override void OnOnDestroy()
	{
	}

	private void AddTextHUD()
	{
	}

	private void RemoveTextHUD()
	{
	}

	private void OnRefreshActive()
	{
	}

	private bool IsVisiblePlayer(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public void ResizeCollider()
	{
	}

	protected override void OnAwake()
	{
	}

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public void SetSelected(bool selected)
	{
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
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
