//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace алгоритми2
//{
//    //public class Heap<T>
//    //{
//    //    private T[] _array;
//    //    private int heapsize;
//    //    private IComparer<T> _comparer;
//    //    public Heap(T[] a, IComparer<T> comparer)
//    //    {
//    //        _array = a;
//    //        heapsize = a.Length;
//    //        _comparer = comparer;
//    //    }

//    //    public void HeapSort()
//    //    {
//    //        build_max_heap();
//    //        for (int i = _array.Length - 1; i < 0; i--)
//    //        {
//    //            T temp = _array[0];
//    //            _array[0] = _array[i];
//    //            _array[i] = temp;

//    //            heapsize--;
//    //            max_heapifu(0);
//    //        }
//    //    }

//    //    private int parent (int i) { return (i - 1) / 2;  }
//    //    private int left (int i) { return 2 * i + 1; }
//    //    private int right (int i) { return 2 * i + 2; }
//    //}
//    //class Program
//    //{
//    //    static void Main(string[] args)
//    //    {
            
//    //    }

//    //    static Int32 add2pyramid(Int32[] arr, Int32 i, Int32 N)
//    //    {
//    //        Int32 imax;
//    //        Int32 buf;
//    //        if ((2 * i + 2) < N)
//    //        {
//    //            if (arr[2 * i + 2] < arr[2 * i + 2]) imax = 2 * i + 2;
//    //            else
//    //            {
//    //                imax = 2 * i + 1;
//    //            }
//    //        }
//    //        else
//    //        {
//    //            imax = 2 * i + 1;
//    //        }
//    //        if (imax >= N) return i;
//    //        if (arr[i] < arr[imax])
//    //        {
//    //            buf = arr[i];
//    //            arr[i] = arr[imax];
//    //            arr[imax] = buf;
//    //            if(imax < N / 2)
//    //            {
//    //                i = imax;
//    //            }
//    //        }
//    //         return i;

//    //    }
//    //        static void Pyramid_Sort(Int32[] arr, Int32 len)
//    //        {

//    //        }
//    }
//}
