// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Components.Wherehouse
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
    public partial class LisProductsWherehouseComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
       
    private List<WarehouseEntity> wherehouses = new List<WarehouseEntity>();
    private List<StorageEntity> storages = new List<StorageEntity>();
    private List<StorageEntity> storageTemp = new List<StorageEntity>();

    private string warehouseName;

    protected override async Task OnInitializedAsync()
    {
        wherehouses = B_Warehouse.WarehouseList();
        storages = B_Storage.StorageList();

        storageTemp = storages;
    }

    private void WherehouseChanged(ChangeEventArgs e)
    {
        var warehouseId = e.Value.ToString();

        if (string.IsNullOrEmpty(warehouseId))
        {
            storageTemp = storages;
            warehouseName = "";
        }
        else
        {
            storageTemp = storages.Where(st => st.WarehouseId == warehouseId).ToList();
            warehouseName = storageTemp.LastOrDefault().Warehouse.WarehouseName;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
