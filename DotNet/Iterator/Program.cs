using System.Collections;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo1
            int[] arr = { 1, 2, 3, 4, 5, 6};
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            List<int> list = new List<int>();
            list.Add(11);
            list.Add(12);
            list.Add(13);
            #endregion
            Console.WriteLine("-------------------------------------------------");

            #region CustomCollection Demo2
            MyCollection mycollection = new MyCollection();
            mycollection.AddElement(1);
            mycollection.AddElement(2);
            mycollection.AddElement(3);
            mycollection.AddElement(4);

            var result = mycollection.GetEnumerator();

            //foreach (var ele in mycollection)
            //{
            //    Console.WriteLine(ele);
            //}
            #endregion

            #region Demo3
            MyCollection2 mycollection2 = new MyCollection2();
            foreach(var item in mycollection2)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }

    public class MyCollection : IEnumerable
    {
        private ArrayList arr = new ArrayList();

        public ArrayList list
        {
            set { arr.Add(value); }
            get { return arr; }
        }

        public void AddElement(int ele)
        {
            arr.Add(ele);
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < arr.Count; i++)
            {
                yield return arr[i];
            }
        }
    }

    public class MyCollection2 : IEnumerable
    {
        private string[] arr = { "Sakshi", "Sanika", "Prachi", "Patil", "Chavan" };

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }
    }
}
