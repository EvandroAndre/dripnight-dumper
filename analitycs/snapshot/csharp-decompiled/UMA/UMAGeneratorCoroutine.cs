using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UMA;

[Serializable]
public class UMAGeneratorCoroutine : WorkerCoroutine
{
	public class MaterialDefinitionComparer : IComparer<UMAData.MaterialFragment>
	{
		public int Compare(UMAData.MaterialFragment x, UMAData.MaterialFragment y)
		{
			return 0;
		}
	}

	private sealed class _003CworkerMethod_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UMAGeneratorCoroutine _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CworkerMethod_003Ed__21(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private TextureProcessBaseCoroutine textureProcessCoroutine;

	private MaxRectsBinPack packTexture;

	private UMAGeneratorBase umaGenerator;

	private UMAData umaData;

	private bool updateMaterialList;

	private int scaleFactor;

	private MaterialDefinitionComparer comparer;

	private List<UMAData.GeneratedMaterial> generatedMaterials;

	private List<UMAData.GeneratedMaterial> atlassedMaterials;

	private Dictionary<List<OverlayData>, UMAData.GeneratedMaterial> generatedMaterialLookup;

	private Dictionary<int, List<Material>> recycledMaterials;

	private List<UMAData.textureData> m_RecycledTextureData;

	private List<UMAData.MaterialFragment> m_RecycledMaterialFragments;

	private List<UMAData.GeneratedMaterial> m_RecycledGeneratedMaterials;

	private List<UMAData.GeneratedMaterial> m_RecycledGeneratedMaterialsList;

	private static T GetOrCreate<T>(List<T> list) where T : new()
	{
		return default(T);
	}

	public override void Reset()
	{
	}

	public void Prepare(UMAGeneratorBase _umaGenerator, UMAData _umaData, TextureProcessBaseCoroutine textureProcessCoroutine, Dictionary<int, List<Material>> recycledMaterials, bool updateMaterialList, int InitialScaleFactor)
	{
	}

	private UMAData.GeneratedMaterial FindOrCreateGeneratedMaterial(UMAMaterial umaMaterial, bool noMerge)
	{
		return null;
	}

	protected override void Start()
	{
	}

	protected override IEnumerator workerMethod()
	{
		return null;
	}

	protected override void Stop()
	{
	}

	private void GenerateAtlasData()
	{
	}

	private void UpdateSharedRect(UMAData.GeneratedMaterial generatedMaterial)
	{
	}

	private bool CalculateRects(UMAData.GeneratedMaterial material)
	{
		return false;
	}

	private void OptimizeAtlas()
	{
	}

	private void UpdateUV()
	{
	}

	private void ApplyMaskColors(UMAData.MaterialFragment matFragment)
	{
	}

	private void RecyckeGeneratedMaterialsList(List<UMAData.GeneratedMaterial> list)
	{
	}

	private static void RemoveTailRange<T>(List<T> list, int maxSize)
	{
	}
}
