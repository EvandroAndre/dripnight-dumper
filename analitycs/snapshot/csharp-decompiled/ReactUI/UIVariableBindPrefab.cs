using GCommon;
using UnityEngine;

namespace ReactUI;

public sealed class UIVariableBindPrefab : UIVariableBind
{
	private static ResourceManager m_Res;

	private string prefabResourceID;

	private string prefabScale;

	private string prefabRotateYaw;

	private string prefabRotatePitch;

	private UIVariable prefabResIDVariable;

	private UIVariable prefabScaleVariable;

	private UIVariable prefabRotYawVariable;

	private UIVariable prefabRotPitchVariable;

	protected Vector3 m_childScale;

	protected Vector3 m_childEmuler;

	private GameObject m_instObject;

	private float m_maxDuration;

	private float m_nextReplayTime;

	private Renderer[] CacheRenders;

	public Color m_color;

	protected override void BindVariables()
	{
	}

	protected override void UnbindVariables()
	{
	}

	private void RefreshScaleRot()
	{
	}

	private void Update()
	{
	}

	public void RefreshPrefab()
	{
	}
}
