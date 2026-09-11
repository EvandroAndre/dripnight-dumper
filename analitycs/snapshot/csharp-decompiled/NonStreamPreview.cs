using System.Collections.Generic;
using UnityEngine;

public class NonStreamPreview : MonoBehaviour, IPreviewLayer
{
	private Dictionary<string, GameObject> previewGameObjects;

	private void Awake()
	{
	}

	public void OriginLoaded(string previewName)
	{
	}

	public void OriginUnloaded(string previewName)
	{
	}

	public void AddPreview(string previewName, GameObject previewGO)
	{
	}

	public void RemovePreview(string previewName)
	{
	}
}
