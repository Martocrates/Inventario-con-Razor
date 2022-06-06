#pragma checksum "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "499884a4492477c72b7463d77f1cf33de8e73a2a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<p>\r\n    <a href=\"wherehouse/addproducts\">Agregar Producto a Bodega</a>\r\n</p>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<label for=\"wherehouse\">Filtrar por bodega: </label>\r\n    ");
            __builder.OpenElement(5, "select");
            __builder.AddAttribute(6, "id", "wherehouse");
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
                                       WherehouseChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", true);
            __builder.AddContent(12, "Seleccionar bodega ...");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 13 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
         foreach (var wherehouse in wherehouses)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "            ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", 
#nullable restore
#line 15 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
                            wherehouse.WarehouseId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 15 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
__builder.AddContent(17, wherehouse.WarehouseName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 16 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<hr>\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "h3 text-center");
            __builder.AddMarkupContent(24, "\r\n    ");
#nullable restore
#line 21 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
__builder.AddContent(25, warehouseName);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n<hr>\r\n");
            __builder.OpenElement(28, "div");
            __builder.AddMarkupContent(29, "\r\n    Total productos registradas: ");
#nullable restore
#line 25 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
__builder.AddContent(30, storageTemp.Count);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n<hr>\r\n");
#nullable restore
#line 28 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
 if (storageTemp == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.AddMarkupContent(34, "<p><em>Cargando...</em></p>\r\n");
#nullable restore
#line 31 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.OpenElement(36, "table");
            __builder.AddAttribute(37, "id", "productsTable");
            __builder.AddAttribute(38, "class", "display table table-bordered table-hover");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.AddMarkupContent(40, "<thead>\r\n            <tr>\r\n                <th>Referencia</th>\r\n                <th>Producto</th>\r\n                <th>Bodega</th>\r\n                <th>Cantidad</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(41, "tbody");
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 46 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
             foreach (var storage in storageTemp)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
#nullable restore
#line 49 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
__builder.AddContent(47, storage.ProductId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
#nullable restore
#line 50 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
__builder.AddContent(50, storage.Product.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "td");
#nullable restore
#line 52 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
__builder.AddContent(53, storage.PartialQuantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "td");
#nullable restore
#line 53 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
__builder.AddContent(56, storage.Warehouse.WarehouseName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "td");
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "a");
            __builder.AddAttribute(61, "href", "storage/update/" + (
#nullable restore
#line 55 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
                                                 storage.StorageId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 58 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 61 "C:\Users\52999\source\repos\Platzi\Inventory\Inventory\Components\Wherehouse\LisProductsWherehouseComponent.razor"
}

#line default
#line hidden
#nullable disable
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
