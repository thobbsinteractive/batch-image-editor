using System.Collections.Generic;

namespace batch_image_editor
{
    public static class ListExtensions
    {
        public static void Move<T>(this List<T> list, int oldIndex, int newIndex)
        {
            var item = list[oldIndex];

            list.RemoveAt(oldIndex);

            list.Insert(newIndex, item);
        }
    }
}
