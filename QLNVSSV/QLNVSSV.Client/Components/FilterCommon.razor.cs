using Microsoft.AspNetCore.Components;
using QLNVSSV.Models.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNVSSV.Client.Components
{
    public partial class FilterCommon
    {
        private List<Positions> listPosition { get; set; } = new();
        private List<Title> listTitle { get; set; } = new();
        protected override async Task OnInitializedAsync()
        {
            listPosition = await ApiIntergration.GetData<Positions>.GetList("http://localhost:37919/api/Position/GetAll");
            listTitle = await ApiIntergration.GetData<Title>.GetList("http://localhost:37919/api/Title/GetAll");
        }
    }
}
