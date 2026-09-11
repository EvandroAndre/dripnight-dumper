using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCIconEntity : MonoBehaviour
{
	private UISprite m_sprite;

	private UGCPrettySprite3DSize m_autoSize;

	private UGCEntityRepItem m_entityComm;

	private UGCPresentIconRepItem m_presentIconComm;

	private string m_entityID;

	private UGCResourceUIAtlas m_resAtlas;

	private bool m_isIgnoreDepth;

	private Vector3 m_userScale;

	private Vector3 m_sysScale;

	private string m_atlasUUID;

	private void OnColorChanged(int valueNew)
	{
	}

	private void OnScaleChanged(float valueNew)
	{
	}

	private void OnOffsetChanged(Vector3 valueNew)
	{
	}

	private void OnIgnoreDepthChanged(bool valueNew)
	{
	}

	private void OnAlwaysInScreenChanged(bool valueNew)
	{
	}

	private void UpdateSpriteScale()
	{
	}

	private void OnIconTypeChanged(string valueNew)
	{
	}

	private void OnFollowTargetChanged(string valueNew)
	{
	}

	private void OnIsBillboardChanged(bool valueNew)
	{
	}

	private void OnRotatorChanged(Vector3 valueNew)
	{
	}

	private void OnScaleVectorChanged(Vector3 valueNew)
	{
	}

	private void OnEnableChanged(bool valueNew)
	{
	}

	public static UGCIconEntity Create(UIPanel iconPanel, string entityID)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void _003COnIconTypeChanged_003Eb__16_0(UGCResourceUIAtlas atlasRes, string spriteName)
	{
	}
}
