// using System.Collections;
// using System.Collections.Generic;

// namespace DesignPatterns.iterator
// {
//     public class MySpecialStorage : IEnumerable<Data>
//     {
//         MyIterator<Data> iter = new MyIterator<Data>();

//         public IEnumerator<Data> GetEnumerator()
//         {

//             return iter;
//         }

//         IEnumerator IEnumerable.GetEnumerator()
//         {
//             return data.GetEnumerator();
//         }
//     }
// }