#pragma checksum "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "117b75575829b80108406b36bcb46bed325ff33c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EADCA3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\_Imports.razor"
using EADCA3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\_Imports.razor"
using EADCA3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\Pages\Index.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\Pages\Index.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\Users\dj_ra\source\repos\EADCA3\EADCA3\Pages\Index.razor"
      
    //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    private bool found;

    private Root data;

    private bool nullString;
    private bool invalidInput;
    private String meal;
    private string errorMessage;

    public String getMeal()
    {
        return this.meal;
    }

    public void setMeal(string m)
    {
        this.meal = m;
    }

    public bool getInvalidInput()
    {
        return this.invalidInput;
    }

    public async Task getFoodAsync()
    {
        try
        {

            string uri = "https://www.themealdb.com/api/json/v1/1/search.php?s=" + this.meal;
            data = await Http.GetFromJsonAsync<Root>(uri);
            found = true;
            errorMessage = String.Empty;
        }
        catch (Exception e)
        {
            found = false;
            errorMessage = e.Message;
        }
    }

    //for testing
    public int totalRecipes(string meal)
    {
        this.meal = meal;

        int total = data.meals.Count;

        return total;
    }

    //Lifecycle method
    protected override async Task OnInitializedAsync()
    {
        await getFoodAsync();
    }

    public async void searchRecipe()
    {
        Regex rx = new Regex(@"^[a-zA-Z0-9\s]+$");
        if (this.meal != null)
        {
           this.nullString = false;
           if (rx.IsMatch(this.meal) == false)
            {
                this.invalidInput = true;
            }
            else
            {
                await getFoodAsync();
                StateHasChanged();
                this.invalidInput = false;
            }
        }
        else
        {
            this.nullString = true;
        }

    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Meal
    {

        public string idMeal { get; set; }
        public string strMeal { get; set; }
        public object strDrinkAlternate { get; set; }
        public string strCategory { get; set; }
        public string strArea { get; set; }
        public string strInstructions { get; set; }
        public string strMealThumb { get; set; }
        public string strTags { get; set; }
        public string strYoutube { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
        public string strIngredient4 { get; set; }
        public string strIngredient5 { get; set; }
        public string strIngredient6 { get; set; }
        public string strIngredient7 { get; set; }
        public string strIngredient8 { get; set; }
        public string strIngredient9 { get; set; }
        public string strIngredient10 { get; set; }
        public string strIngredient11 { get; set; }
        public string strIngredient12 { get; set; }
        public string strIngredient13 { get; set; }
        public string strIngredient14 { get; set; }
        public string strIngredient15 { get; set; }
        public object strIngredient16 { get; set; }
        public object strIngredient17 { get; set; }
        public object strIngredient18 { get; set; }
        public object strIngredient19 { get; set; }
        public object strIngredient20 { get; set; }
        public string strMeasure1 { get; set; }
        public string strMeasure2 { get; set; }
        public string strMeasure3 { get; set; }
        public string strMeasure4 { get; set; }
        public string strMeasure5 { get; set; }
        public string strMeasure6 { get; set; }
        public string strMeasure7 { get; set; }
        public string strMeasure8 { get; set; }
        public string strMeasure9 { get; set; }
        public string strMeasure10 { get; set; }
        public string strMeasure11 { get; set; }
        public string strMeasure12 { get; set; }
        public string strMeasure13 { get; set; }
        public string strMeasure14 { get; set; }
        public string strMeasure15 { get; set; }
        public object strMeasure16 { get; set; }
        public object strMeasure17 { get; set; }
        public object strMeasure18 { get; set; }
        public object strMeasure19 { get; set; }
        public object strMeasure20 { get; set; }
        public object strSource { get; set; }
        public object dateModified { get; set; }

    }

    public class Root
    {
        public List<Meal> meals { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
