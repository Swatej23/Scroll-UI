﻿
using CustomScrollView;
using UnityEngine;
using UnityEngine.UI;

namespace ScrollViewExample01
{
    class Cell : Cell<ItemData>
    {
        [SerializeField] Animator animator = default;
        [SerializeField] Text message = default;

        static class AnimatorHash
        {
            public static readonly int Scroll = Animator.StringToHash("scroll");
        }

        public override void UpdateContent(ItemData itemData)
        {
            message.text = itemData.Message;
        }

        public override void UpdatePosition(float position)
        {
            currentPosition = position;

            if (animator.isActiveAndEnabled)
            {
                animator.Play(AnimatorHash.Scroll, -1, position);
            }

            animator.speed = 0;
        }

        float currentPosition = 0;

        void OnEnable() => UpdatePosition(currentPosition);
    }
}
