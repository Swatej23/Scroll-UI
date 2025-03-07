
using UnityEngine;

namespace ScrollViewExample01
{
    class ItemData
    {
        public string Message { get; }
        public Sprite ItemSprite { get; }

        public ItemData(string message, Sprite itemSprite)
        {
            Message = message;
            ItemSprite = itemSprite;
        }
    }
}
