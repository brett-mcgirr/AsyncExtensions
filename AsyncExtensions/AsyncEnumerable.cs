using System.Linq;
using System.Threading.Tasks;

namespace AsyncExtensions
{
    public static class Enumerable
    {
        public static async Task<TSource> Aggregate<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TSource, TSource> func)
        {
            return (await source).Aggregate<TSource>(func);
        }

        public static async Task<TAccumulate> Aggregate<TSource, TAccumulate>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> func)
        {
            return (await source).Aggregate<TSource, TAccumulate>(seed, func);
        }

        public static async Task<TResult> Aggregate<TSource, TAccumulate, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> func, System.Func<TAccumulate, TResult> resultSelector)
        {
            return (await source).Aggregate<TSource, TAccumulate, TResult>(seed, func, resultSelector);
        }

        public static async Task<System.Boolean> All<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).All<TSource>(predicate);
        }

        public static async Task<System.Boolean> Any<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).Any<TSource>();
        }

        public static async Task<System.Boolean> Any<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).Any<TSource>(predicate);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> AsEnumerable<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).AsEnumerable<TSource>();
        }

        public static async Task<System.Double> Average(this Task<System.Collections.Generic.IEnumerable<System.Int32>> source)
        {
            return (await source).Average();
        }

        public static async Task<System.Nullable<System.Double>> Average(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>> source)
        {
            return (await source).Average();
        }

        public static async Task<System.Double> Average(this Task<System.Collections.Generic.IEnumerable<System.Int64>> source)
        {
            return (await source).Average();
        }

        public static async Task<System.Nullable<System.Double>> Average(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>> source)
        {
            return (await source).Average();
        }

        public static async Task<System.Single> Average(this Task<System.Collections.Generic.IEnumerable<System.Single>> source)
        {
            return (await source).Average();
        }

        public static async Task<System.Nullable<System.Single>> Average(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>> source)
        {
            return (await source).Average();
        }

        public static async Task<System.Double> Average(this Task<System.Collections.Generic.IEnumerable<System.Double>> source)
        {
            return (await source).Average();
        }

        public static async Task<System.Nullable<System.Double>> Average(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>> source)
        {
            return (await source).Average();
        }

        public static async Task<System.Decimal> Average(this Task<System.Collections.Generic.IEnumerable<System.Decimal>> source)
        {
            return (await source).Average();
        }

        public static async Task<System.Nullable<System.Decimal>> Average(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>> source)
        {
            return (await source).Average();
        }

        public static async Task<System.Double> Average<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int32> selector)
        {
            return (await source).Average<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Double>> Average<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Int32>> selector)
        {
            return (await source).Average<TSource>(selector);
        }

        public static async Task<System.Double> Average<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int64> selector)
        {
            return (await source).Average<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Double>> Average<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Int64>> selector)
        {
            return (await source).Average<TSource>(selector);
        }

        public static async Task<System.Single> Average<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Single> selector)
        {
            return (await source).Average<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Single>> Average<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Single>> selector)
        {
            return (await source).Average<TSource>(selector);
        }

        public static async Task<System.Double> Average<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Double> selector)
        {
            return (await source).Average<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Double>> Average<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Double>> selector)
        {
            return (await source).Average<TSource>(selector);
        }

        public static async Task<System.Decimal> Average<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Decimal> selector)
        {
            return (await source).Average<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Decimal>> Average<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Decimal>> selector)
        {
            return (await source).Average<TSource>(selector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> Cast<TResult>(this Task<System.Collections.IEnumerable> source)
        {
            return (await source).Cast<TResult>();
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Concat<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> first, System.Collections.Generic.IEnumerable<TSource> second)
        {
            return (await first).Concat<TSource>(second);
        }

        public static async Task<System.Boolean> Contains<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, TSource value)
        {
            return (await source).Contains<TSource>(value);
        }

        public static async Task<System.Boolean> Contains<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, TSource value, System.Collections.Generic.IEqualityComparer<TSource> comparer)
        {
            return (await source).Contains<TSource>(value, comparer);
        }

        public static async Task<System.Int32> Count<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).Count<TSource>();
        }

        public static async Task<System.Int32> Count<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).Count<TSource>(predicate);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> DefaultIfEmpty<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).DefaultIfEmpty<TSource>();
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> DefaultIfEmpty<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, TSource defaultValue)
        {
            return (await source).DefaultIfEmpty<TSource>(defaultValue);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Distinct<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).Distinct<TSource>();
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Distinct<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Collections.Generic.IEqualityComparer<TSource> comparer)
        {
            return (await source).Distinct<TSource>(comparer);
        }

        public static async Task<TSource> ElementAt<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Int32 index)
        {
            return (await source).ElementAt<TSource>(index);
        }

        public static async Task<TSource> ElementAtOrDefault<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Int32 index)
        {
            return (await source).ElementAtOrDefault<TSource>(index);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Except<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> first, System.Collections.Generic.IEnumerable<TSource> second)
        {
            return (await first).Except<TSource>(second);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Except<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer)
        {
            return (await first).Except<TSource>(second, comparer);
        }

        public static async Task<TSource> First<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).First<TSource>();
        }

        public static async Task<TSource> First<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).First<TSource>(predicate);
        }

        public static async Task<TSource> FirstOrDefault<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).FirstOrDefault<TSource>();
        }

        public static async Task<TSource> FirstOrDefault<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).FirstOrDefault<TSource>(predicate);
        }

        public static async Task<System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>>> GroupBy<TSource, TKey>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector)
        {
            return (await source).GroupBy<TSource, TKey>(keySelector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>>> GroupBy<TSource, TKey>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
        {
            return (await source).GroupBy<TSource, TKey>(keySelector, comparer);
        }

        public static async Task<System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>>> GroupBy<TSource, TKey, TElement>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector)
        {
            return (await source).GroupBy<TSource, TKey, TElement>(keySelector, elementSelector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>>> GroupBy<TSource, TKey, TElement>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
        {
            return (await source).GroupBy<TSource, TKey, TElement>(keySelector, elementSelector, comparer);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> GroupBy<TSource, TKey, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TSource>, TResult> resultSelector)
        {
            return (await source).GroupBy<TSource, TKey, TResult>(keySelector, resultSelector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> GroupBy<TSource, TKey, TElement, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult> resultSelector)
        {
            return (await source).GroupBy<TSource, TKey, TElement, TResult>(keySelector, elementSelector, resultSelector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> GroupBy<TSource, TKey, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TSource>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
        {
            return (await source).GroupBy<TSource, TKey, TResult>(keySelector, resultSelector, comparer);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> GroupBy<TSource, TKey, TElement, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
        {
            return (await source).GroupBy<TSource, TKey, TElement, TResult>(keySelector, elementSelector, resultSelector, comparer);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> GroupJoin<TOuter, TInner, TKey, TResult>(this Task<System.Collections.Generic.IEnumerable<TOuter>> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector)
        {
            return (await outer).GroupJoin<TOuter, TInner, TKey, TResult>(inner, outerKeySelector, innerKeySelector, resultSelector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> GroupJoin<TOuter, TInner, TKey, TResult>(this Task<System.Collections.Generic.IEnumerable<TOuter>> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
        {
            return (await outer).GroupJoin<TOuter, TInner, TKey, TResult>(inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Intersect<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> first, System.Collections.Generic.IEnumerable<TSource> second)
        {
            return (await first).Intersect<TSource>(second);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Intersect<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer)
        {
            return (await first).Intersect<TSource>(second, comparer);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> Join<TOuter, TInner, TKey, TResult>(this Task<System.Collections.Generic.IEnumerable<TOuter>> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector)
        {
            return (await outer).Join<TOuter, TInner, TKey, TResult>(inner, outerKeySelector, innerKeySelector, resultSelector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> Join<TOuter, TInner, TKey, TResult>(this Task<System.Collections.Generic.IEnumerable<TOuter>> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
        {
            return (await outer).Join<TOuter, TInner, TKey, TResult>(inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
        }

        public static async Task<TSource> Last<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).Last<TSource>();
        }

        public static async Task<TSource> Last<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).Last<TSource>(predicate);
        }

        public static async Task<TSource> LastOrDefault<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).LastOrDefault<TSource>();
        }

        public static async Task<TSource> LastOrDefault<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).LastOrDefault<TSource>(predicate);
        }

        public static async Task<System.Int64> LongCount<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).LongCount<TSource>();
        }

        public static async Task<System.Int64> LongCount<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).LongCount<TSource>(predicate);
        }

        public static async Task<System.Int64> Max(this Task<System.Collections.Generic.IEnumerable<System.Int64>> source)
        {
            return (await source).Max();
        }

        public static async Task<System.Nullable<System.Int64>> Max(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>> source)
        {
            return (await source).Max();
        }

        public static async Task<System.Double> Max(this Task<System.Collections.Generic.IEnumerable<System.Double>> source)
        {
            return (await source).Max();
        }

        public static async Task<System.Nullable<System.Double>> Max(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>> source)
        {
            return (await source).Max();
        }

        public static async Task<System.Single> Max(this Task<System.Collections.Generic.IEnumerable<System.Single>> source)
        {
            return (await source).Max();
        }

        public static async Task<System.Nullable<System.Single>> Max(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>> source)
        {
            return (await source).Max();
        }

        public static async Task<System.Decimal> Max(this Task<System.Collections.Generic.IEnumerable<System.Decimal>> source)
        {
            return (await source).Max();
        }

        public static async Task<System.Nullable<System.Decimal>> Max(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>> source)
        {
            return (await source).Max();
        }

        public static async Task<TSource> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).Max<TSource>();
        }

        public static async Task<System.Int32> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int32> selector)
        {
            return (await source).Max<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Int32>> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Int32>> selector)
        {
            return (await source).Max<TSource>(selector);
        }

        public static async Task<System.Int64> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int64> selector)
        {
            return (await source).Max<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Int64>> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Int64>> selector)
        {
            return (await source).Max<TSource>(selector);
        }

        public static async Task<System.Single> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Single> selector)
        {
            return (await source).Max<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Single>> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Single>> selector)
        {
            return (await source).Max<TSource>(selector);
        }

        public static async Task<System.Double> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Double> selector)
        {
            return (await source).Max<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Double>> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Double>> selector)
        {
            return (await source).Max<TSource>(selector);
        }

        public static async Task<System.Decimal> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Decimal> selector)
        {
            return (await source).Max<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Decimal>> Max<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Decimal>> selector)
        {
            return (await source).Max<TSource>(selector);
        }

        public static async Task<TResult> Max<TSource, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TResult> selector)
        {
            return (await source).Max<TSource, TResult>(selector);
        }

        public static async Task<System.Int32> Max(this Task<System.Collections.Generic.IEnumerable<System.Int32>> source)
        {
            return (await source).Max();
        }

        public static async Task<System.Nullable<System.Int32>> Max(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>> source)
        {
            return (await source).Max();
        }

        public static async Task<System.Int32> Min(this Task<System.Collections.Generic.IEnumerable<System.Int32>> source)
        {
            return (await source).Min();
        }

        public static async Task<System.Nullable<System.Int32>> Min(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>> source)
        {
            return (await source).Min();
        }

        public static async Task<System.Int64> Min(this Task<System.Collections.Generic.IEnumerable<System.Int64>> source)
        {
            return (await source).Min();
        }

        public static async Task<System.Nullable<System.Int64>> Min(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>> source)
        {
            return (await source).Min();
        }

        public static async Task<System.Single> Min(this Task<System.Collections.Generic.IEnumerable<System.Single>> source)
        {
            return (await source).Min();
        }

        public static async Task<System.Nullable<System.Single>> Min(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>> source)
        {
            return (await source).Min();
        }

        public static async Task<System.Double> Min(this Task<System.Collections.Generic.IEnumerable<System.Double>> source)
        {
            return (await source).Min();
        }

        public static async Task<System.Nullable<System.Double>> Min(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>> source)
        {
            return (await source).Min();
        }

        public static async Task<System.Decimal> Min(this Task<System.Collections.Generic.IEnumerable<System.Decimal>> source)
        {
            return (await source).Min();
        }

        public static async Task<System.Nullable<System.Decimal>> Min(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>> source)
        {
            return (await source).Min();
        }

        public static async Task<TSource> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).Min<TSource>();
        }

        public static async Task<System.Int32> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int32> selector)
        {
            return (await source).Min<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Int32>> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Int32>> selector)
        {
            return (await source).Min<TSource>(selector);
        }

        public static async Task<System.Int64> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int64> selector)
        {
            return (await source).Min<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Int64>> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Int64>> selector)
        {
            return (await source).Min<TSource>(selector);
        }

        public static async Task<System.Single> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Single> selector)
        {
            return (await source).Min<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Single>> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Single>> selector)
        {
            return (await source).Min<TSource>(selector);
        }

        public static async Task<System.Double> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Double> selector)
        {
            return (await source).Min<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Double>> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Double>> selector)
        {
            return (await source).Min<TSource>(selector);
        }

        public static async Task<System.Decimal> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Decimal> selector)
        {
            return (await source).Min<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Decimal>> Min<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Decimal>> selector)
        {
            return (await source).Min<TSource>(selector);
        }

        public static async Task<TResult> Min<TSource, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TResult> selector)
        {
            return (await source).Min<TSource, TResult>(selector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> OfType<TResult>(this Task<System.Collections.IEnumerable> source)
        {
            return (await source).OfType<TResult>();
        }

        public static async Task<System.Linq.IOrderedEnumerable<TSource>> OrderBy<TSource, TKey>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector)
        {
            return (await source).OrderBy<TSource, TKey>(keySelector);
        }

        public static async Task<System.Linq.IOrderedEnumerable<TSource>> OrderBy<TSource, TKey>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer)
        {
            return (await source).OrderBy<TSource, TKey>(keySelector, comparer);
        }

        public static async Task<System.Linq.IOrderedEnumerable<TSource>> OrderByDescending<TSource, TKey>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector)
        {
            return (await source).OrderByDescending<TSource, TKey>(keySelector);
        }

        public static async Task<System.Linq.IOrderedEnumerable<TSource>> OrderByDescending<TSource, TKey>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer)
        {
            return (await source).OrderByDescending<TSource, TKey>(keySelector, comparer);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Reverse<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).Reverse<TSource>();
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> Select<TSource, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TResult> selector)
        {
            return (await source).Select<TSource, TResult>(selector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> Select<TSource, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int32, TResult> selector)
        {
            return (await source).Select<TSource, TResult>(selector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> SelectMany<TSource, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> selector)
        {
            return (await source).SelectMany<TSource, TResult>(selector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> SelectMany<TSource, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int32, System.Collections.Generic.IEnumerable<TResult>> selector)
        {
            return (await source).SelectMany<TSource, TResult>(selector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> SelectMany<TSource, TCollection, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int32, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector)
        {
            return (await source).SelectMany<TSource, TCollection, TResult>(collectionSelector, resultSelector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> SelectMany<TSource, TCollection, TResult>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector)
        {
            return (await source).SelectMany<TSource, TCollection, TResult>(collectionSelector, resultSelector);
        }

        public static async Task<System.Boolean> SequenceEqual<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> first, System.Collections.Generic.IEnumerable<TSource> second)
        {
            return (await first).SequenceEqual<TSource>(second);
        }

        public static async Task<System.Boolean> SequenceEqual<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer)
        {
            return (await first).SequenceEqual<TSource>(second, comparer);
        }

        public static async Task<TSource> Single<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).Single<TSource>();
        }

        public static async Task<TSource> Single<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).Single<TSource>(predicate);
        }

        public static async Task<TSource> SingleOrDefault<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).SingleOrDefault<TSource>();
        }

        public static async Task<TSource> SingleOrDefault<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).SingleOrDefault<TSource>(predicate);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Skip<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Int32 count)
        {
            return (await source).Skip<TSource>(count);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> SkipWhile<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).SkipWhile<TSource>(predicate);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> SkipWhile<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int32, System.Boolean> predicate)
        {
            return (await source).SkipWhile<TSource>(predicate);
        }

        public static async Task<System.Int32> Sum(this Task<System.Collections.Generic.IEnumerable<System.Int32>> source)
        {
            return (await source).Sum();
        }

        public static async Task<System.Nullable<System.Int32>> Sum(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>> source)
        {
            return (await source).Sum();
        }

        public static async Task<System.Int64> Sum(this Task<System.Collections.Generic.IEnumerable<System.Int64>> source)
        {
            return (await source).Sum();
        }

        public static async Task<System.Nullable<System.Int64>> Sum(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>>> source)
        {
            return (await source).Sum();
        }

        public static async Task<System.Single> Sum(this Task<System.Collections.Generic.IEnumerable<System.Single>> source)
        {
            return (await source).Sum();
        }

        public static async Task<System.Nullable<System.Single>> Sum(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Single>>> source)
        {
            return (await source).Sum();
        }

        public static async Task<System.Double> Sum(this Task<System.Collections.Generic.IEnumerable<System.Double>> source)
        {
            return (await source).Sum();
        }

        public static async Task<System.Nullable<System.Double>> Sum(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Double>>> source)
        {
            return (await source).Sum();
        }

        public static async Task<System.Decimal> Sum(this Task<System.Collections.Generic.IEnumerable<System.Decimal>> source)
        {
            return (await source).Sum();
        }

        public static async Task<System.Nullable<System.Decimal>> Sum(this Task<System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>>> source)
        {
            return (await source).Sum();
        }

        public static async Task<System.Int32> Sum<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int32> selector)
        {
            return (await source).Sum<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Int32>> Sum<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Int32>> selector)
        {
            return (await source).Sum<TSource>(selector);
        }

        public static async Task<System.Int64> Sum<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int64> selector)
        {
            return (await source).Sum<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Int64>> Sum<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Int64>> selector)
        {
            return (await source).Sum<TSource>(selector);
        }

        public static async Task<System.Single> Sum<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Single> selector)
        {
            return (await source).Sum<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Single>> Sum<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Single>> selector)
        {
            return (await source).Sum<TSource>(selector);
        }

        public static async Task<System.Double> Sum<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Double> selector)
        {
            return (await source).Sum<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Double>> Sum<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Double>> selector)
        {
            return (await source).Sum<TSource>(selector);
        }

        public static async Task<System.Decimal> Sum<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Decimal> selector)
        {
            return (await source).Sum<TSource>(selector);
        }

        public static async Task<System.Nullable<System.Decimal>> Sum<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Nullable<System.Decimal>> selector)
        {
            return (await source).Sum<TSource>(selector);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Take<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Int32 count)
        {
            return (await source).Take<TSource>(count);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> TakeWhile<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).TakeWhile<TSource>(predicate);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> TakeWhile<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int32, System.Boolean> predicate)
        {
            return (await source).TakeWhile<TSource>(predicate);
        }

        public static async Task<System.Linq.IOrderedEnumerable<TSource>> ThenBy<TSource, TKey>(this Task<System.Linq.IOrderedEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector)
        {
            return (await source).ThenBy<TSource, TKey>(keySelector);
        }

        public static async Task<System.Linq.IOrderedEnumerable<TSource>> ThenBy<TSource, TKey>(this Task<System.Linq.IOrderedEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer)
        {
            return (await source).ThenBy<TSource, TKey>(keySelector, comparer);
        }

        public static async Task<System.Linq.IOrderedEnumerable<TSource>> ThenByDescending<TSource, TKey>(this Task<System.Linq.IOrderedEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector)
        {
            return (await source).ThenByDescending<TSource, TKey>(keySelector);
        }

        public static async Task<System.Linq.IOrderedEnumerable<TSource>> ThenByDescending<TSource, TKey>(this Task<System.Linq.IOrderedEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer)
        {
            return (await source).ThenByDescending<TSource, TKey>(keySelector, comparer);
        }

        public static async Task<TSource[]> ToArray<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).ToArray<TSource>();
        }

        public static async Task<System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionary<TSource, TKey>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector)
        {
            return (await source).ToDictionary<TSource, TKey>(keySelector);
        }

        public static async Task<System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionary<TSource, TKey>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
        {
            return (await source).ToDictionary<TSource, TKey>(keySelector, comparer);
        }

        public static async Task<System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionary<TSource, TKey, TElement>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector)
        {
            return (await source).ToDictionary<TSource, TKey, TElement>(keySelector, elementSelector);
        }

        public static async Task<System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionary<TSource, TKey, TElement>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
        {
            return (await source).ToDictionary<TSource, TKey, TElement>(keySelector, elementSelector, comparer);
        }

        public static async Task<System.Collections.Generic.List<TSource>> ToList<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source)
        {
            return (await source).ToList<TSource>();
        }

        public static async Task<System.Linq.ILookup<TKey, TSource>> ToLookup<TSource, TKey>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector)
        {
            return (await source).ToLookup<TSource, TKey>(keySelector);
        }

        public static async Task<System.Linq.ILookup<TKey, TSource>> ToLookup<TSource, TKey>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
        {
            return (await source).ToLookup<TSource, TKey>(keySelector, comparer);
        }

        public static async Task<System.Linq.ILookup<TKey, TElement>> ToLookup<TSource, TKey, TElement>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector)
        {
            return (await source).ToLookup<TSource, TKey, TElement>(keySelector, elementSelector);
        }

        public static async Task<System.Linq.ILookup<TKey, TElement>> ToLookup<TSource, TKey, TElement>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
        {
            return (await source).ToLookup<TSource, TKey, TElement>(keySelector, elementSelector, comparer);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Union<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> first, System.Collections.Generic.IEnumerable<TSource> second)
        {
            return (await first).Union<TSource>(second);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Union<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer)
        {
            return (await first).Union<TSource>(second, comparer);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Where<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Boolean> predicate)
        {
            return (await source).Where<TSource>(predicate);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TSource>> Where<TSource>(this Task<System.Collections.Generic.IEnumerable<TSource>> source, System.Func<TSource, System.Int32, System.Boolean> predicate)
        {
            return (await source).Where<TSource>(predicate);
        }

        public static async Task<System.Collections.Generic.IEnumerable<TResult>> Zip<TFirst, TSecond, TResult>(this Task<System.Collections.Generic.IEnumerable<TFirst>> first, System.Collections.Generic.IEnumerable<TSecond> second, System.Func<TFirst, TSecond, TResult> resultSelector)
        {
            return (await first).Zip<TFirst, TSecond, TResult>(second, resultSelector);
        }

    }
}


