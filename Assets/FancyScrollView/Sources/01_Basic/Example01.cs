﻿/*
 * FancyScrollView (https://github.com/setchi/FancyScrollView)
 * Copyright (c) 2020 setchi
 * Licensed under MIT (https://github.com/setchi/FancyScrollView/blob/master/LICENSE)
 */

using System.Linq;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample01
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
