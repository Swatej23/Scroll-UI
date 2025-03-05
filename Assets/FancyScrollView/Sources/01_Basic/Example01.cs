
using System.Linq;
using UnityEngine;

namespace ScrollViewExample01
{
    class Example01 : MonoBehaviour
    {
        [SerializeField] ScrollView scrollView = default;
        [SerializeField] int cellCount = 20;
        void Start()
        {
            var items = Enumerable.Range(0, cellCount)
                .Select(i => new ItemData($"Cell {i}"))
                .ToArray();

            scrollView.UpdateData(items);
        }
    }
}
