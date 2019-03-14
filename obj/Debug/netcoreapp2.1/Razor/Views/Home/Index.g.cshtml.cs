#pragma checksum "/Users/dschenck/src/mylocation/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dca4e21cda1b496da5545a3255b6b2fcf30f8aa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/dschenck/src/mylocation/Views/_ViewImports.cshtml"
using mylocation;

#line default
#line hidden
#line 2 "/Users/dschenck/src/mylocation/Views/_ViewImports.cshtml"
using mylocation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca4e21cda1b496da5545a3255b6b2fcf30f8aa0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76bb825af59b62dd385ad35484929a56734e12bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/dschenck/src/mylocation/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2283, true);
            WriteLiteral(@"
<h2>
    Click Submit to get your location based on your IP address of <div id=""ipaddress""></div>
</h2>
<button type=""button"" class=""btn btn-primary"" onclick=""getLocation()"">Submit</button>
<div class=""row"">
<row>
    <div>query:</div>
    <div id='query'></div>
</row>    
<div id=""resultArea""></div>
</div>

<script src=""//code.jquery.com/jquery-2.1.1.min.js"" type=""text/javascript""></script>

<script type=""application/javascript"">
  function getIP(json) {
      document.getElementById('ipaddress').innerHTML=json.ip;
  }
</script>

<script type=""application/javascript"" src=""https://api.ipify.org?format=jsonp&callback=getIP""></script>

<script type=""application/javascript"">
    function getLocation() {
        //document.getElementById('locationdiv').innerHTML = ""Result here"";
        var ipAddress = document.getElementById('ipaddress').innerHTML;
        jQuery.get(""http://locationms-kubex.192.168.99.100.nip.io/"" + ipAddress, function(data) {
            var parsedJSON = JSON.parse");
            WriteLiteral(@"(data);
            var outstring = ""query: "" + parsedJSON[""query""];
            outstring = outstring + ""status: "" + parsedJSON[""status""];
            outstring = outstring + ""country: "" + parsedJSON[""country""];
            outstring = outstring + ""countryCode: "" + parsedJSON[""countryCode""];
            outstring = outstring + ""region: "" + parsedJSON[""region""];
            outstring = outstring + ""regionName: "" + parsedJSON[""regionName""];
            outstring = outstring + ""city: "" + parsedJSON[""city""];
            outstring = outstring + ""zip: "" + parsedJSON[""zip""];
            outstring = outstring + ""lat: "" + parsedJSON[""lat""];
            outstring = outstring + ""lon: "" + parsedJSON[""lon""];
            outstring = outstring + ""timezone: "" + parsedJSON[""timezone""];
            outstring = outstring + ""isp: "" + parsedJSON[""isp""];
            outstring = outstring + ""org: "" + parsedJSON[""org""];
            outstring = outstring + ""as: "" + parsedJSON[""as""];
            $('#query').text(parsed");
            WriteLiteral("JSON[\'query\']);\r\n            $(\'#resultArea\').html(outstring);\r\n        }).fail(function(){\r\n            document.getElementById(\'locationdiv\').innerHTML = \"Call to service failed.\";\r\n        });\r\n        return data;\r\n    }\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
