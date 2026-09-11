using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

public class LStreamer
{
	public struct Coordinate
	{
		public int X;

		public int Y;

		public int Z;

		public bool Equals(ref Coordinate r)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}

	public class Tile
	{
		public Coordinate Coord;

		public List<LEntity> DynamicLEntitys;

		public List<LEntity> StaticLEntitys;

		public int ProcessDynamicEntity(Vector3 min, Vector3 max)
		{
			return 0;
		}

		public int ProcessStaticEntity(Vector3 min, Vector3 max)
		{
			return 0;
		}

		public static void ProcessEntity(LEntity lEntity, Vector3 min, Vector3 max)
		{
		}
	}

	private sealed class _003CProcessStaticEntityCo_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LStreamer _003C_003E4__this;

		private HashSet<Tile>.Enumerator _003C_003E7__wrap1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CProcessStaticEntityCo_003Ed__49(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	public const int TileRangeY = 5000;

	public const int InValidTile = -1;

	public int TileExtend;

	public int MapHeight;

	public int MapWidth;

	public int TileSizeX;

	public int TileSizeY;

	public int TileSizeZ;

	public int TileIndexMax_X;

	public int TileIndexMax_Y;

	public int TileIndexMax_Z;

	public int TileCountX;

	public int TileCountY;

	public int TileCountZ;

	public Vector3 TileOrigin;

	public Tile[] Tiles;

	public StreamerType StreamerType;

	private Coordinate m_LastCoord;

	public List<LEntity> DynamicLEntitys;

	private int m_DynamicCallBackCount;

	private int m_StaticCallBackCount;

	private HashSet<Tile> m_LastTiles;

	private HashSet<Tile> m_LastSmallTiles;

	private HashSet<Tile> m_CurTiles;

	private HashSet<Tile> m_CurSmallTiles;

	private HashSet<Tile> m_ProcessTiles;

	private IEnumerator m_StaticFCO;

	private Vector3 m_StaticMin;

	private Vector3 m_StaticMax;

	private FTimer m_Timer;

	// C# has no syntax for parameterized property 'Item'.
	public Tile get_Item(int tileIndex)
	{
		return null;
	}

	public void InitLStreamer(StreamerType streamerType, Vector3 tileOrigin, Vector3 mapSize, int _TileSizeX, int _TileSizeZ)
	{
	}

	public void Attach(LEntity lEntity, bool isDynamic)
	{
	}

	public void Detach(LEntity lEntity, bool isDynamic)
	{
	}

	private void AddToTile(LEntity lEntity, bool isDynamic, ref Coordinate coord)
	{
	}

	private void RemoveFromTile(LEntity lEntity, bool isDynamic, ref Coordinate coord)
	{
	}

	public void GetCoord(ref Coordinate coord, LTransform ltransform)
	{
	}

	public void GetCoord(ref Coordinate coord, Vector3 origin)
	{
	}

	public Vector3 GetCoordMin(int X, int Z)
	{
		return default(Vector3);
	}

	public Vector3 GetCoordMax(int X, int Z)
	{
		return default(Vector3);
	}

	public static int Clamp(int value, int min, int max)
	{
		return 0;
	}

	public void GetInRangeTile(ref Coordinate coord, HashSet<Tile> tiles, HashSet<Tile> tilesSmall, HashSet<Tile> allTiles)
	{
	}

	public void CheckPosition(Vector3 pos, bool forceUpdate = false)
	{
	}

	public void DispatchAllDynamic(ref Coordinate lastCoord, ref Coordinate coord, Vector3 min, Vector3 max)
	{
	}

	public void SetLastCordInvalid()
	{
	}

	public void DispatchAllTileStatic(ref Coordinate lastCoord, ref Coordinate coord, Vector3 min, Vector3 max)
	{
	}

	public IEnumerator ProcessStaticEntityCo()
	{
		return null;
	}
}
