using System;
using System.Collections.Generic;
using UnityEngine;

public static class UGCGameObjectHelper
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public bool enableCollider;

		internal void _003CSetColliderEnable_003Eb__0(Collider c)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public uint layer;

		internal void _003CSetColliderLayer_003Eb__0(Collider c)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public uint layer;

		internal void _003CSetColliderExtraLayer_003Eb__0(Collider c)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public GameObject go;

		public string name;

		internal void _003CSetTexture_003Eb__0(bool succ, bool isReloaded, Texture2D tex)
		{
		}
	}

	private static List<Renderer> TmpRenderers;

	private static List<UIRect> TmpUIRenderers;

	private static List<Collider> cachedColliders;

	public static void ChangeColor(GameObject go, string name, Color color)
	{
	}

	public static void ChangeTexture(GameObject go, string name, Texture texture, string texCustomRef, bool isReloaded)
	{
	}

	public static void SetColor(GameObject go, string name, Color color)
	{
	}

	public static void SetTexture(GameObject go, string name, string texName)
	{
	}

	private static void ApplyTexture(GameObject go, string name, Texture texture)
	{
	}

	public static List<Renderer> GetMeshRenderers(Transform root)
	{
		return null;
	}

	public static void SetVisible(GameObject go, bool visible)
	{
	}

	public static void SetRenderersEnable(Transform trs, bool visible)
	{
	}

	public static void SetUIRenderersEnable(Transform trs, bool visible)
	{
	}

	public static void SetExtraRenderLayer(GameObject go, int layer)
	{
	}

	public static void SetColliderEnable(GameObject go, bool enableCollider)
	{
	}

	public static void SetColliderLayer(GameObject go, uint layer, bool shouldModifyTrigger)
	{
	}

	public static void SetColliderExtraLayer(GameObject go, uint layer, bool shouldModifyTrigger)
	{
	}

	public static void SetSelfExtraLayer(GameObject go, uint layer)
	{
	}

	private static void SetColliderLayerHandler(Collider c, uint layer)
	{
	}

	private static void SetColliderExtraLayerHandler(Collider c, uint layer)
	{
	}

	private static void OperationOnAllColliders(GameObject go, bool shouldModifyTrigger, Action<Collider> op)
	{
	}
}
