using Eterna.Models;
using System.Collections.Generic;

namespace Eterna.DataAccess
{
    public static class Data
    {
        public static List<Feature> Features = new List<Feature>
        {
            new Feature{Id=1,Title="Lorem Ipsum 11",Icon="bi bi-card-checklist",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new Feature{Id=1,Title="Lorem Ipsum 22",Icon="bi bi-bar-chart",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new Feature{Id=1,Title="Lorem Ipsum 33",Icon="bi bi-binoculars",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
        };
    }
}
