#pragma checksum "/Users/Molnar.Peter/Projects/Harvester/HarvesterApp/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d75e66ffa35479b0b2b6a55193818e7e91b79ef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HarvesterApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace HarvesterApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/Molnar.Peter/Projects/Harvester/HarvesterApp/Pages/_ViewImports.cshtml"
using HarvesterApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d75e66ffa35479b0b2b6a55193818e7e91b79ef7", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8a231c9892479322cb1b98a1eea16767865cf40", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/Molnar.Peter/Projects/Harvester/HarvesterApp/Pages/Index.cshtml"
  
    ViewData["Title"] = "Próba feladat";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid main-page"">
    <div class=""row"">
        <div class=""col-12 text-center my-4"">
            <h1 class=""m-0"">Activities</h1>
        </div>
    </div>
    <div class=""row mt-4"">
        <div class=""col"">
            <div class=""date p-2"">
                <div class=""row"">
                    <div class=""col-12"">
                        <h2 class=""m-0"">name of the day</h2>
                    </div>
                    <div class=""col-12"">
                        <h3 class=""m-0"">date</h3>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""date p-2"">
                <div class=""row"">
                    <div class=""col-12"">
                        <h2 class=""m-0"">name of the day</h2>
                    </div>
                    <div class=""col-12"">
                        <h3 class=""m-0"">date</h3>
                    </div>
                </div>
            </div>
    ");
            WriteLiteral(@"    </div>
        <div class=""col"">
            <div class=""date p-2"">
                <div class=""row"">
                    <div class=""col-12"">
                        <h2 class=""m-0"">name of the day</h2>
                    </div>
                    <div class=""col-12"">
                        <h3 class=""m-0"">date</h3>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""date p-2"">
                <div class=""row"">
                    <div class=""col-12"">
                        <h2 class=""m-0"">name of the day</h2>
                    </div>
                    <div class=""col-12"">
                        <h3 class=""m-0"">date</h3>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""date p-2"">
                <div class=""row"">
                    <div class=""col-12"">
                        <h2 class=""m-0"">name of th");
            WriteLiteral(@"e day</h2>
                    </div>
                    <div class=""col-12"">
                        <h3 class=""m-0"">date</h3>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""date p-2"">
                <div class=""row"">
                    <div class=""col-12"">
                        <h2 class=""m-0"">name of the day</h2>
                    </div>
                    <div class=""col-12"">
                        <h3 class=""m-0"">date</h3>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""date p-2"">
                <div class=""row"">
                    <div class=""col-12"">
                        <h2 class=""m-0"">name of the day</h2>
                    </div>
                    <div class=""col-12"">
                        <h3 class=""m-0"">date</h3>
                    </div>
                </div>
            </div");
            WriteLiteral(@">
        </div>
    </div>
    <div class=""row mt-4"">
        <div class=""col-10 mx-auto daily-list"">
            <div class=""list-item p-3 mb-2""><!--Start: repeatable list item. Made by adding a new record for that day-->
                <div class=""row"">
                    <div class=""col-12"">
                        Category / Subcategory
                    </div>
                </div>
                <div class=""row align-items-center"">
                    <div class=""col-6"">
                        comment section
                    </div>
                    <div class=""col-2 text-center"">
                        from
                    </div>
                    <div class=""col-2 text-center"">
                        to
                    </div>
                    <div class=""col-2 text-right"">
                        <button type=""button"" class=""btn btn-warning"">Modify Record</button><!--Allows the user the modify the record manually-->
                    </div>
      ");
            WriteLiteral(@"          </div>
            </div><!--End: repeatable list item. Made by adding a new record for that day-->
            <div class=""list-item p-3 mb-2""><!--Start: repeatable list item. Made by adding a new record for that day-->
                <div class=""row"">
                    <div class=""col-12"">
                        Backend / Database Management
                    </div>
                </div>
                <div class=""row align-items-center"">
                    <div class=""col-6"">
                        Connected SQL database with the application, made categories and subcategories records, that can be listed
                        at the daily activities.
                    </div>
                    <div class=""col-2 text-center"">
                        2020.05.20 15:00
                    </div>
                    <div class=""col-2 text-center"">
                        2020.05.20 16:38
                    </div>
                    <div class=""col-2 text-right"">
   ");
            WriteLiteral(@"                     <button type=""button"" class=""btn btn-warning"">Modify Record</button><!--Allows the user the modify the record manually-->
                    </div>
                </div>
            </div><!--End: repeatable list item. Made by adding a new record for that day-->
        </div>
    </div>
    <div class=""row mt-5"">
        <div class=""col-3 mx-auto text-center"">
            <button type=""button"" class=""btn btn-primary"">Make Summary</button><!--Make a summary about the whole day manually-->
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
