using UnityEngine;

public class RegisterUIRender : MonoBehaviour, UISuspendable
{
	public bool m_UseSharedMat;

	public Renderer[] m_Renderers;

	private bool m_Suspended;

	private UIPanel m_Panel;

	private void RetrieveRenderers()
	{
	}

	private void RegisterUIPanel()
	{
	}

	private void UnregisterUIPanel()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Suspend()
	{
	}

	public void Resume()
	{
	}
}
