

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
            return _Contains(tuple, item);
        }

        private static bool _Contains<T, TRest>(this ValueTuple<T, T, T, T, T, T, T, TRest> tuple, T item) where T : IComparable where TRest : struct
        {

            if (tuple.Item1.CompareTo(item) == 0 || tuple.Item2.CompareTo(item) == 0 || tuple.Item3.CompareTo(item) == 0 || tuple.Item4.CompareTo(item) == 0 || tuple.Item5.CompareTo(item) == 0 || tuple.Item6.CompareTo(item) == 0 || tuple.Item7.CompareTo(item) == 0)
            {
                return true;
            }

            var result = (bool)typeof(ValueTupleExtension).GetMethod(nameof(StructToValueTuple), Reflection.BindingFlags.NonPublic | Reflection.BindingFlags.Static)
                                                  .MakeGenericMethod(new Type[] { item.GetType(), tuple.Rest.GetType() })
                                                  .Invoke(null, new object[] { tuple.Rest, item });

            return StructToValueTuple(tuple.Rest, item);
        }

        private static bool StructToValueTuple<T, TRest>(TRest tuple, T item) where T : IComparable where TRest : struct
        {
            object obj = tuple;
            if (tuple is ValueTuple<T>)
            {
                return ((ValueTuple<T>)obj).Contains(item);
            }

            if (tuple is ValueTuple<T, T>)
            {
                return ((ValueTuple<T, T>)obj).Contains(item);
            }

            if (tuple is ValueTuple<T, T, T>)
            {
                return ((ValueTuple<T, T, T>)obj).Contains(item);
            }

            if (tuple is ValueTuple<T, T, T, T>)
            {
                return ((ValueTuple<T, T, T, T>)obj).Contains(item);
            }

            if (tuple is ValueTuple<T, T, T, T, T>)
            {
                return ((ValueTuple<T, T, T, T, T>)obj).Contains(item);
            }

            if (tuple is ValueTuple<T, T, T, T, T, T>)
            {
                return ((ValueTuple<T, T, T, T, T, T>)obj).Contains(item);
            }

            if (tuple is ValueTuple<T, T, T, T, T, T, T>)
            {
                return ((ValueTuple<T, T, T, T, T, T, T>)obj).Contains(item);
            }

            var tupleRestField = tuple.GetType().GetField("Rest");
            var rest = tupleRestField.GetValue(tuple);

            var result = (bool)typeof(ValueTupleExtension).GetMethod(nameof(_Contains), Reflection.BindingFlags.NonPublic | Reflection.BindingFlags.Static)
                                      .MakeGenericMethod(new Type[] { item.GetType(), rest.GetType() })
                                      .Invoke(null, new object[] { tuple, item });


            return result;

        }


    }
}
