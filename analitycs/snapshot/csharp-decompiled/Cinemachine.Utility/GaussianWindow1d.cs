namespace Cinemachine.Utility;

internal abstract class GaussianWindow1d<T>
{
	protected T[] mData;

	protected float[] mKernel;

	protected float mKernelSum;

	protected int mCurrentPos;

	private float _003CSigma_003Ek__BackingField;

	public float Sigma
	{
		get
		{
			return _003CSigma_003Ek__BackingField;
		}
		private set
		{
			_003CSigma_003Ek__BackingField = value;
		}
	}

	public int KernelSize => 0;

	public int BufferLength => 0;

	private void GenerateKernel(float sigma, int maxKernelRadius)
	{
	}

	protected abstract T Compute(int windowPos);

	public GaussianWindow1d(float sigma, int maxKernelRadius = 10)
	{
	}

	public void Reset()
	{
	}

	public bool IsEmpty()
	{
		return false;
	}

	public void AddValue(T v)
	{
	}

	public T Value()
	{
		return default(T);
	}
}
