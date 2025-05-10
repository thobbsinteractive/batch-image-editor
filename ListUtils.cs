using System.Collections.Generic;

namespace batch_image_editor
{
    internal static class ListUtils
    {
        public struct QuiltSettings
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Cols { get; set; }
            public int Rows { get; set; }
            public double AspectRatio { get; set; }
            public int CellWidth { get; set; }
            public int CellHeight { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        };

        public static QuiltSettings[] PopulateDropDownList(bool includeEmpty = false)
        {
            List<QuiltSettings> list = new List<QuiltSettings>();

            if (includeEmpty)
            {
                list.Add(new QuiltSettings
                {
                    Id = 0,
                    Name = "None"
                });
            }

            list.Add(new QuiltSettings
            {
                Id = 1,
                Name = "Looking Glass Go",
                Cols = 11,
                Rows = 6,
                AspectRatio = 0.75,
                CellWidth = 372,
                CellHeight = 682,
                Width = 4092,
                Height = 4092
            });
            list.Add(new QuiltSettings
            {
                Id = 2,
                Name = "Looking Glass Portrait",
                Cols = 8,
                Rows = 6,
                AspectRatio = 0.75,
                CellWidth = 420,
                CellHeight = 560,
                Width = 3360,
                Height = 3360
            });

            list.Add(new QuiltSettings
            {
                Id = 3,
                Name = "Looking Glass 16\" Light Field Display (Landscape)",
                Cols = 7,
                Rows = 7,
                AspectRatio = 1.777,
                CellWidth = 857,
                CellHeight = 857,
                Width = 5999,
                Height = 5999
            });
            list.Add(new QuiltSettings
            {
                Id = 4,
                Name = "Looking Glass 16\" Light Field Display (Portrait)",
                Cols = 11,
                Rows = 6,
                AspectRatio = 1.777,
                CellWidth = 545,
                CellHeight = 1000,
                Width = 5995,
                Height = 6000
            });
            list.Add(new QuiltSettings
            {
                Id = 5,
                Name = "Looking Glass 32\" Light Field Display (Landscape)",
                Cols = 7,
                Rows = 7,
                AspectRatio = 1.777,
                CellWidth = 1170,
                CellHeight = 1170,
                Width = 8190,
                Height = 8190
            });
            list.Add(new QuiltSettings
            {
                Id = 6,
                Name = "Looking Glass 32\" Light Field Display (Portrait)",
                Cols = 11,
                Rows = 6,
                AspectRatio = 1.777,
                CellWidth = 744,
                CellHeight = 1364,
                Width = 8184,
                Height = 8184
            });
            return list.ToArray();
        }
    }
}
