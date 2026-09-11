using GCommon;

namespace COW.Gameplay.UGC;

public class UGCHudTexture : UGCHudWidget
{
	protected UITexture m_Texture;

	protected UINetworkTexture m_NetworkTexture;

	private string m_TextureName;

	private string m_ShaderName;

	public UITexture Texture => null;

	public UINetworkTexture NetworkTexture => null;

	public string TextureName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ShaderName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}
}
