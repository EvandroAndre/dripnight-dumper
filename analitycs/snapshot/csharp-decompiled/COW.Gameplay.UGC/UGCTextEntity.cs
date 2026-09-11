using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTextEntity : MonoBehaviour
{
	private UILabel m_label;

	private UGCPrettySprite3DSize m_autoSize;

	private UGCEntityRepItem m_entityComm;

	private UGCPresentTextRepItem m_presentTextComm;

	private string m_entityID;

	private static Material m_noZMaterial;

	private static Material m_zMaterial;

	private Transform m_scaleTran;

	public void OnColorChanged(int valueNew)
	{
	}

	public void OnScaleChanged(float valueNew)
	{
	}

	public void OnOffsetChanged(Vector3 valueNew)
	{
	}

	public Material GetNoZMaterial()
	{
		return null;
	}

	public void OnIgnoreDepthChanged(bool valueNew)
	{
	}

	public void OnTextKeyChanged(string valueNew)
	{
	}

	public void OnFollowTargetChanged(string valueNew)
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

	private void OnFontSizeChangeEvent(int valueNew)
	{
	}

	private void OnEnableChanged(bool valueNew)
	{
	}

	public static UGCTextEntity Create(UIPanel iconPanel, string entityID)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
