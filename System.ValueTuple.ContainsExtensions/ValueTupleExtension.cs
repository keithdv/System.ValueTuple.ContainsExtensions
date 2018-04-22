

namespace System
{
    public static class ValueTupleExtension
    {


        public static bool Contains<T>(this ValueTuple<T> tuple, T item) where T : IComparable
        {

            if (tuple.Item1.CompareTo(item) == 0)
            {
                return true;
            }

            return false;
        }


        public static bool Contains<T>(this ValueTuple<T, T> tuple, T item) where T : IComparable
        {

            if (tuple.Item1.CompareTo(item) == 0 || tuple.Item2.CompareTo(item) == 0)
            {
                return true;
            }

            return false;
        }


        public static bool Contains<T>(this ValueTuple<T, T, T> tuple, T item) where T : IComparable
        {

            if (tuple.Item1.CompareTo(item) == 0 || tuple.Item2.CompareTo(item) == 0 || tuple.Item3.CompareTo(item) == 0)
            {
                return true;
            }

            return false;
        }


        public static bool Contains<T>(this ValueTuple<T, T, T, T> tuple, T item) where T : IComparable
        {

            if (tuple.Item1.CompareTo(item) == 0 || tuple.Item2.CompareTo(item) == 0 || tuple.Item3.CompareTo(item) == 0 || tuple.Item4.CompareTo(item) == 0)
            {
                return true;
            }

            return false;
        }


        public static bool Contains<T>(this ValueTuple<T, T, T, T, T> tuple, T item) where T : IComparable
        {

            if (tuple.Item1.CompareTo(item) == 0 || tuple.Item2.CompareTo(item) == 0 || tuple.Item3.CompareTo(item) == 0 || tuple.Item4.CompareTo(item) == 0 || tuple.Item5.CompareTo(item) == 0)
            {
                return true;
            }

            return false;
        }


        public static bool Contains<T>(this ValueTuple<T, T, T, T, T, T> tuple, T item) where T : IComparable
        {

            if (tuple.Item1.CompareTo(item) == 0 || tuple.Item2.CompareTo(item) == 0 || tuple.Item3.CompareTo(item) == 0 || tuple.Item4.CompareTo(item) == 0 || tuple.Item5.CompareTo(item) == 0 || tuple.Item6.CompareTo(item) == 0)
            {
                return true;
            }

            return false;
        }


        public static bool Contains<T>(this ValueTuple<T, T, T, T, T, T, T> tuple, T item) where T : IComparable
        {

            if (tuple.Item1.CompareTo(item) == 0 || tuple.Item2.CompareTo(item) == 0 || tuple.Item3.CompareTo(item) == 0 || tuple.Item4.CompareTo(item) == 0 || tuple.Item5.CompareTo(item) == 0 || tuple.Item6.CompareTo(item) == 0 || tuple.Item7.CompareTo(item) == 0)
            {
                return true;
            }

            return false;
        }


        public static bool Contains<T, TRest>(this ValueTuple<T, T, T, T, T, T, T, TRest> tuple, T item) where T : IComparable where TRest : struct
        {

            if (tuple.Item1.CompareTo(item) == 0 || tuple.Item2.CompareTo(item) == 0 || tuple.Item3.CompareTo(item) == 0 || tuple.Item4.CompareTo(item) == 0 || tuple.Item5.CompareTo(item) == 0 || tuple.Item6.CompareTo(item) == 0 || tuple.Item7.CompareTo(item) == 0)
            {
                return true;
            }

            return StructToValueTuple(tuple.Rest, item);
        }

        private static bool StructToValueTuple<T, TRest>(TRest tuple, T item) where T : IComparable where TRest : struct
        {
            if (tuple is ValueTuple<T>)
            {
                // I'm Stuck Here
				// It's great that 8+ tuple items recognize the extension method
				// But how do I deal with TRest??
                // return ((ValueTuple<T>)tuple).Contains(item);
            }

            throw new Exception("So close yet so far!");
        }

    }
}
